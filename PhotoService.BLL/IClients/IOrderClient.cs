using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface IOrderClient
{
    public OrderOutputModel AddOrder(OrderInputModel order);

    public List<OrderOutputModel> GetAllOrders();

    public OrderOutputModel GetOrderById(int id);
}