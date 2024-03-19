using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL;

public class OrderForCustomerMock : IOrderClient
{
    private List<OrderOutputModel> _orderOutputModel;

    public OrderForCustomerMock()
    {
        _orderOutputModel = new List<OrderOutputModel>()
        {
            new OrderOutputModel()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 04, 4),
                Status = "Новый",
                ServiceTitle = "Съёмка Ваших мероприятий",
                ExecutorName = "Ангелина Владиславовна Мнишек",
                ServicePrice = "От 1500 р./ч.",
                CancellationReason =""
            },
            new OrderOutputModel()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 04, 1),
                Status = "В работе",
                ServiceTitle = "Портретная съёмка в студии",
                ExecutorName = "Арсений Артемьевич Серебрянников",
                ServicePrice = "5 000р. за 3 часа",
                CancellationReason =""
            },
            new OrderOutputModel()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 03, 19),
                Status = "Завершён",
                ServiceTitle = "Свадебный фотограф",
                ExecutorName = "Иванов Иван Иванович",
                ServicePrice = "15 000 р. за съёмочный день",
                CancellationReason =""
            },
            new OrderOutputModel()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 03, 19),
                Status = "Отменён",
                ServiceTitle = "Фотограф-анималист",
                ExecutorName = "Елизавета Александровна Михеева",
                ServicePrice = "3000 р./ч.",
                CancellationReason ="Исполнитель не сможет выполнить работу в желаемую дату."
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