using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface IOrderClient
{
    public OrderOutputModelForMock AddOrder(OrderInputModel order);

    public List<OrderOutputModelForMock> GetAllOrders();

    public OrderOutputModelForMock GetOrderById(int id);
    public List<OrderOutputModel> GetOrders();
}