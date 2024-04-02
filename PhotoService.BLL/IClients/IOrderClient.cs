using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface IOrderClient
{
    // public OrderOutputModelForMock AddOrderForMock (OrderInputModelForMock order);
    
    public List<OrderOutputModelForMock> GetOrdersForMock();
    
    public OrderOutputModelForMock GetOrderByIdForMock(int id);
    
    // public List<OrderOutputModel> GetOrders();
    
    // public OrderOutputModel GetOrderById(int id);
    
    public List<OrderOutputModel> GetOrdersByCustomerIdAsync(int userId);

    public OrderOutputModel AddOrder(int serviceId, OrderInputModel order);

}