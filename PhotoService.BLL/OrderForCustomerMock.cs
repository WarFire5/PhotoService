using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL;

public class OrderForCustomerMock : IOrderClient
{
    private List<OrderOutputModelForMock> _orderOutputModelForMock;

    public OrderForCustomerMock()
    {
        _orderOutputModelForMock = new List<OrderOutputModelForMock>()
        {
            new OrderOutputModelForMock()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 04, 4),
                Status = "Новый",
                ServiceTitle = "Съёмка Ваших мероприятий",
                ExecutorName = "Ангелина Владиславовна Мнишек",
                ServicePrice = "От 1500 р./ч.",
                CancellationReason =""
            },
            new OrderOutputModelForMock()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 04, 1),
                Status = "В работе",
                ServiceTitle = "Портретная съёмка в студии",
                ExecutorName = "Арсений Артемьевич Серебрянников",
                ServicePrice = "5 000р. за 3 часа",
                CancellationReason =""
            },
            new OrderOutputModelForMock()
            {
                Comment = "Какой-то комментарий",
                СreationDate = new DateTime (2024, 03, 19),
                Status = "Завершён",
                ServiceTitle = "Свадебный фотограф",
                ExecutorName = "Иванов Иван Иванович",
                ServicePrice = "15 000 р. за съёмочный день",
                CancellationReason =""
            },
            new OrderOutputModelForMock()
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

    public List<OrderOutputModelForMock> GetOrdersForMock()
    {
        return _orderOutputModelForMock;
    }

    public List<OrderOutputModel> GetOrders()
    {
        throw new NotImplementedException();
    }
    
    // public OrderOutputModel GetOrderById(int id)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public List<OrdersDto> GetOrdersByCustomerId(int userId)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public OrderOutputModelForMock AddOrder(OrderInputModelForMock order)
    // {
    //     return new OrderOutputModelForMock()
    //     {
    //         Id = 1,
    //         CustomerId = order.CustomerId,
    //         СreationDate = order.СreationDate,
    //         Comment = order.Comment,
    //         ServiceId = order.ServiceId,
    //         Status = order.Status
    //     };
    // }
}