using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL;

public class ServiceMock : IServiceClient
{
    private List<ServiceOutputModel> _serviceOutputModels;
    private IServiceClient _serviceClientImplementation;

    public ServiceMock()
    {
        _serviceOutputModels = new List<ServiceOutputModel>()
        {
            new ServiceOutputModel()
            {
                Id = 1,
                Title = "Делаю быстрые фото",
                Description =
                    "Меня зовут Евгений и я Ваш фотограф). Веду запись на осень, торопись! (Свяжитесь со мной прямо сейчас, чтобы узнать, «свободна ли ваша дата»). ",
                ExecutorName = "Евгения Иванова",
                TypeName = "Фотограф",
                Price = "5500"
            },
            new ServiceOutputModel()
            {
                Id = 2,
                Title = "Видео для свадьбы",
                Description =
                    "Качественная видеосъёмка свадьбы, банкета, Лавстори, Будуар, Студия. Профессиональное оборудование. Большой опыт.",
                ExecutorName = "Никита Громов",
                TypeName= "Видеограф",
                Price = "10000"
            },
            new ServiceOutputModel()
            {
                Id = 3,
                Title = "Фотоуслуги",
                Description =
                    "Акция спец цены на фотосессию выписка из роддома. Подробности в сообщениях. Детский и семейный фотограф в Санкт-Петербурге. -семейная фотосъемка",
                ExecutorName = "Наталья Крик",
                TypeName = "Фотограф",
                Price = "2999"
            }
        };
    }

    public ServiceOutputModel AddService(ServiceInputModel service, UsersDto? executorId)
    {
        return new ServiceOutputModel()
        {
            Id = 1,
            Title = service.Title,
            Description = service.Description,
            TypeName = service.TypeName,
            Price = service.Price
        };
    }

    public ServiceOutputModel AddService(ServiceInputModel service)
    {
        throw new NotImplementedException();
    }

    public ServiceOutputModel AddService(ServiceInputModel service, int userId)
    {
        throw new NotImplementedException();
    }

    public List<ServiceOutputModel> GetAllServices(int id)
    {
        throw new NotImplementedException();
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