using AutoMapper;
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

    // public void AddOrder(OrdersOutputModel model)
    // {
    //     using (var context = new Context())
    //     {
    //         var dto = _mapper.Map<OrdersDto>(model);
    //         context.Orders.Add(dto);
    //         context.SaveChanges();
    //     }
    // }

    OrderOutputModelForMock IOrderClient.GetOrderById(int id)
    {
        throw new NotImplementedException();
    }

    public List<OrderOutputModel> GetOrders()
    {
        using (var context = new Context())
        {
            List<OrdersDto> ordersDto = context.Orders.ToList();
            var orderOutputModels  = _mapper.Map<List<OrderOutputModel>>(ordersDto);
            return orderOutputModels;
        }
    }

    public OrderOutputModelForMock AddOrder(OrderInputModel order)
    {
        throw new NotImplementedException();
    }

    public List<OrderOutputModelForMock> GetAllOrders()
    {
        throw new NotImplementedException();
    }

    public OrderOutputModel GetOrderById(int id)
    {
        OrderOutputModel model = new OrderOutputModel();
        using (var context = new Context())
        {
            List<OrdersDto> ordersDto = context.Orders.ToList();
            var orderOutputModels  = _mapper.Map<List<OrderOutputModel>>(ordersDto);
            foreach (var order in orderOutputModels)
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

}