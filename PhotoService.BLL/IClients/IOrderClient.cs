using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface IOrderClient
{
    public OrderOutputModelForMock GetOrderByIdForMock(int id);
    
    public List<OrderOutputModel> GetOrdersByCustomerIdAsync(int userId);

    public OrderOutputModel AddOrder(int serviceId, OrderInputModel order);

    public List<OrderOutputModel> GetOrdersByExecutor();

}