using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL;

public class OrderMock : IOrderClient
{
    private List<OrderOutputModel> _orderOutputModel;

    public OrderMock()
    {
        _orderOutputModel = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Id = 1,
                CustomerId = 1,
                СreationDate = "23.01.2023",
                Comment = "Какой-то комментарий",
                ServiceId = 1,
                Status = "Активный"
            },
            new OrderOutputModel()
            {
                Id = 2,
                CustomerId = 2,
                СreationDate = "12.03.2023",
                Comment = "Какой-то комментарий",
                ServiceId = 2,
                Status = "В работе"
            },
            new OrderOutputModel()
            {
                Id = 2,
                CustomerId = 2,
                СreationDate = "1.03.2023",
                Comment = "Прежде всего, граница обучения кадров играет определяющее значение для новых предложений. Являясь всего лишь частью общей картины, активно развивающие",
                ServiceId = 3,
                Status = "Завершен"
            },
        };
    }

    public OrderOutputModel AddOrder(OrderInputModel order)
    {
        return new OrderOutputModel()
        {
            Id = 1,
            CustomerId = order.CustomerId,
            СreationDate = order.СreationDate,
            Comment = order.Comment,
            ServiceId = order.ServiceId,
            Status = order.Status
        };
    }

    public List<OrderOutputModel> GetAllOrders()
    {
        return _orderOutputModel;
    }

    public OrderOutputModel GetOrderById(int id)
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