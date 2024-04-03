using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL;

public class OrderMock : IOrderClient
{
    private List<OrderOutputModelForMock> _orderOutputModelForMock;

    public OrderMock()
    {
        _orderOutputModelForMock = new List<OrderOutputModelForMock>()
        {
            new OrderOutputModelForMock()
            {
                Id = 1,
                CustomerId = 1,
                СreationDate = new DateTime(2023,01,23),
                Comment = "Какой-то комментарий",
                ServiceId = 1,
                Status = "Активный"
            },
            new OrderOutputModelForMock()
            {
                Id = 2,
                CustomerId = 2,
                СreationDate = new DateTime(2023,03,12),
                Comment = "Какой-то комментарий",
                ServiceId = 2,
                Status = "В работе"
            },
            new OrderOutputModelForMock()
            {
                Id = 2,
                CustomerId = 2,
                СreationDate = new DateTime (2023,03,1),
                Comment = "Прежде всего, граница обучения кадров играет определяющее значение для новых предложений. Являясь всего лишь частью общей картины, активно развивающие",
                ServiceId = 3,
                Status = "Завершен"
            },
        };
    }

    public OrderOutputModelForMock AddOrderForMock (OrderInputModelForMock order)
    {
        return new OrderOutputModelForMock()
        {
            Id = 1,
            CustomerId = order.CustomerId,
            СreationDate = order.СreationDate,
            Comment = order.Comment,
            ServiceId = order.ServiceId,
            Status = order.Status
        };
    }

    public List<OrderOutputModelForMock> GetOrdersForMock()
    {
        return _orderOutputModelForMock;
    }

    public OrderOutputModelForMock GetOrderByIdForMock(int id)
    {
        if (id >= 0 && id <= _orderOutputModelForMock.Count)
        {
            return _orderOutputModelForMock[id];
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(id), "Index is out of range");
        }
    }

    public List<OrderOutputModel> GetOrdersByCustomerIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public OrderOutputModel AddOrder(int serviceId, OrderInputModel order)
    {
        throw new NotImplementedException();
    }

    public List<OrderOutputModel> GetOrdersByExecutor()
    {
        throw new NotImplementedException();
    }
}