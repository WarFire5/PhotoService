using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Clients;

public class OrderClient: IOrderClient
{
    private readonly SingletoneStorage _storage;
    private readonly IMapper _mapper;

    public OrderClient()
    {
        _storage = SingletoneStorage.GetStorage();
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }
    
    OrderOutputModelForMock IOrderClient.GetOrderByIdForMock(int id)
    {
        OrderOutputModelForMock model = new OrderOutputModelForMock();
        using (var context = new Context())
        {
            List<OrdersDto> ordersDto = context.Orders.ToList();
            var orderOutputModelsForMock  = _mapper.Map<List<OrderOutputModelForMock>>(ordersDto);
            foreach (var order in orderOutputModelsForMock)
            {
                if (order.Id == id)
                {
                    model = order;
                    break;
                }
            }
        }

        return model;
    }
    
    public List<OrderOutputModel> GetOrdersByCustomerIdAsync(int userId)
    {
        using (var context = new Context())
        {
            var customerRole = context.Roles.FirstOrDefault(r => r.Title == "Заказчик");

            if (customerRole != null)
            {
                var customers = context.Users.Where(u => u.Role.Id == customerRole.Id && u.Id == userId);

                if (customers.Any())
                {
                    var ordersDto = context.Orders.Include(o => o.Customer).Include(o => o.Service.Executor).Where(o => customers.Any(c => c.Id == o.Customer.Id)).ToList();
                    var orderOutputModels = _mapper.Map<List<OrderOutputModel>>(ordersDto);
                    return orderOutputModels;
                }
            }

            return new List<OrderOutputModel>();
        }
    }

    public List<OrderOutputModel> GetOrdersByExecutor()
    {
        var user = SingletoneStorage.GetStorage().UserId;
        var executorRole = SingletoneStorage.GetStorage().Storage.Roles.FirstOrDefault(r => r.Id == 2);
    
        if (executorRole != null)
        {
            var orders = SingletoneStorage.GetStorage().Storage.Orders
                .Include(o => o.Customer)
                .Include(o => o.Service)
                .Where(o => o.Service.Executor != null && o.Service.Executor.Id == user)
                .ToList();

            var orderOutputModels = _mapper.Map<List<OrderOutputModel>>(orders);
            return orderOutputModels;
        }

        return new List<OrderOutputModel>();
    }
    
    public OrderOutputModel AddOrder(int serviceId, OrderInputModel order)
    {
        var serviceDto = SingletoneStorage.GetStorage().Storage.Services.FirstOrDefault(s => s.Id == serviceId);

        var userId = SingletoneStorage.GetStorage().UserId;
        var user = SingletoneStorage.GetStorage().Storage.Users
            .FirstOrDefault(u => u.Id == userId);

        if (serviceDto == null)
        {
            return null;
        }

        var newOrder = new OrdersDto()
        {
            Status = "Новый",
            Service = serviceDto,
            Customer = user,
            CreationDate = DateTime.Now,
            IsDeleted = false,
            Comment = order.Comment,
        };
        var orderOutputModel = _mapper.Map<OrderOutputModel>(newOrder);
        SingletoneStorage.GetStorage().Storage.Orders.Add(newOrder);
        SingletoneStorage.GetStorage().Storage.SaveChanges();

        return orderOutputModel;
    }
}