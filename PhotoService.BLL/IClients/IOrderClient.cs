using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.IClients;

public interface IOrderClient
{
    public OrderOutputModelForMock GetOrderByIdForMock(int id);
    
    public List<OrderOutputModelForMock> GetOrdersForMock();
    
    public List<OrderOutputModel> GetOrders();
    
    // public OrderOutputModel GetOrderById(int id);

    // public List<OrdersDto> GetOrdersByCustomerId(int userId);

    // public OrderOutputModelForMock AddOrder(OrderInputModelForMock order);
}