using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL;

public class OrderMock : IOrderClient
{
    private List<OrderOutputModelForMock> _orderOutputModel;

    public OrderMock()
    {
        _orderOutputModel = new List<OrderOutputModelForMock>()
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

    public OrderOutputModelForMock AddOrder(OrderInputModel order)
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

    public List<OrderOutputModelForMock> GetAllOrders()
    {
        return _orderOutputModel;
    }

    public OrderOutputModelForMock GetOrderById(int id)
    {
        if (id >= 0 && id <= _orderOutputModel.Count)
        {
            return _orderOutputModel[id];
        }
        else
        {
            // Обработка ситуации, когда индекс находится вне допустимого диапазона
            throw new ArgumentOutOfRangeException(nameof(id), "Index is out of range");
        }
    }
}