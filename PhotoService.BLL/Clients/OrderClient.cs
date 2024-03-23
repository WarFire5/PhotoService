using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoService.BLL.Clients;
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
    
    public List<OrderOutputModelForMock> GetOrdersForMock()
    {
        using (var context = new Context())
        {
            List<OrdersDto> ordersDto = context.Orders.ToList();
            var orderOutputModelsForMock  = _mapper.Map<List<OrderOutputModelForMock>>(ordersDto);
            return orderOutputModelsForMock;
        }
    }
    
    public List<OrderOutputModel> GetOrders()
    {
        using (var context = new Context())
        {
            List<OrdersDto> ordersDto = context.Orders.Include(o=>o.Customer).Include(o=>o.Service.Executor).ToList();
            var orderOutputModels  = _mapper.Map<List<OrderOutputModel>>(ordersDto);
            return orderOutputModels;
        }
    }

    // public OrderOutputModel GetOrderById(int id)
    // {
    //     OrderOutputModel model = new OrderOutputModel();
    //     using (var context = new Context())
    //     {
    //         List<OrdersDto> ordersDto = context.Orders.ToList();
    //         var orderOutputModels = GetOrders();
    //         
    //         foreach (var order in orderOutputModels)
    //         {
    //             if (order.Id == id)
    //             {
    //                 model = order;
    //                 break;
    //             }
    //         }
    //     }
    //
    //     return model;
    // }
    
    // public List<OrdersDto> GetOrdersByCustomerId(int userId)
    // {
    //     using (var context = new Context())
    //     {
    //         var customerRole = context.Roles.FirstOrDefault(r => r.Title == "Заказчик");
    //
    //         if (customerRole != null)
    //         {
    //             var customers = context.Users.Where(u => u.Role.Id == customerRole.Id && u.Id == userId);
    //
    //             if (customers.Any())
    //             {
    //                 var orders = context.Orders.Where(o => customers.Any(c => c.Id == o.Customer.Id)).ToList();
    //                 return orders;
    //             }
    //         }
    //
    //         return new List<OrdersDto>();
    //     }
    // }

    // public void AddOrder(OrdersOutputModel model)
    // {
    //     using (var context = new Context())
    //     {
    //         var dto = _mapper.Map<OrdersDto>(model);
    //         context.Orders.Add(dto);
    //         context.SaveChanges();
    //     }
    // }

}