using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL;

public class ServiceMock : IClients.IServiceClient
{
    private List<ServiceOutputModel> _serviceOutputModels;

    public ServiceMock()
    {
        _serviceOutputModels = new List<ServiceOutputModel>()
        {
            new ServiceOutputModel()
            {
                Id = 1,
                Name = "Делаю быстрые фото",
                Description =
                    "Меня зовут Евгений и я Ваш фотограф). Веду запись на осень, торопись! (Свяжитесь со мной прямо сейчас, чтобы узнать, «свободна ли ваша дата»). ",
                ExecutorName = "Евгения Иванова",
                Rating = 4,
                ServiceType = "Фотограф",
                Cost = 5500
            },
            new ServiceOutputModel()
            {
                Id = 2,
                Name = "Видео для свадьбы",
                Description =
                    "Качественная видеосъёмка свадьбы, банкета, Лавстори, Будуар, Студия. Профессиональное оборудование. Большой опыт.",
                ExecutorName = "Никита Громов",
                Rating = 5,
                ServiceType = "Видеограф",
                Cost = 10000
            },
            new ServiceOutputModel()
            {
                Id = 3,
                Name = "Фотоуслуги",
                Description =
                    "Акция спец цены на фотосессию выписка из роддома. Подробности в сообщениях. Детский и семейный фотограф в Санкт-Петербурге. -семейная фотосъемка",
                ExecutorName = "Наталья Крик",
                Rating = 5,
                ServiceType = "Фотограф",
                Cost = 2999
            }
        };
    }

    public ServiceOutputModel AddService(ServiceInputModel service)
    {
        return new ServiceOutputModel()
        {
            Id = 1,
            Name = service.Name,
            Description = service.Description,
            ExecutorName = service.ExecutorName,
            Rating = service.Rating,
            ServiceType = service.ServiceType,
            Cost = service.Cost
        };
    }

    public List<ServiceOutputModel> GetAllServices()
    {
        return _serviceOutputModels;
    }

    public ServiceOutputModel GetServiceById(int id)
    {
        return _serviceOutputModels[id-1];
    }
}