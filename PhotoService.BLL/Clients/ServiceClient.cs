using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Clients;

public class ServiceClient : IServiceClient
{
    private readonly IMapper _mapper;

    public ServiceClient()
    {
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }

    public ServiceOutputModel AddService(ServiceInputModel service)
    {
        int typeId = service.Type;
        var type = SingletoneStorage.GetStorage().Storage.Types.
            FirstOrDefault(t => t.Id == typeId);
        
        var userId = SingletoneStorage.GetStorage().UserId;
        var user = SingletoneStorage.GetStorage().Storage.Users
            .FirstOrDefault(u => u.Id == userId);
        
        if (type == null)
        {
            throw new Exception("Тип услуги не найден");
        }
        var newService = new ServicesDto()
        {
            Title = service.Title,
            Price = service.Price,
            Description = service.Description,
            Executor = user,
            Type = type,
            IsDeleted = false,
        };
        var serviceOutputModel = _mapper.Map<ServiceOutputModel>(newService);
        SingletoneStorage.GetStorage().Storage.Services.Add(newService);
        SingletoneStorage.GetStorage().Storage.SaveChanges();
        
        return serviceOutputModel;
    }

    public List<ServiceOutputModel> GetAllServices()
    {
        var services = SingletoneStorage.GetStorage().Storage.Services
            .Include(s => s.Executor)
            .Include(s => s.Type)
            .ToList();

        // var user = SingletoneStorage.GetStorage().Storage.Users.
        //     Include(u => u.Id).
        //     ToList();
        
        var serviceOutputModel = _mapper.Map<List<ServiceOutputModel>>(services);

        foreach (var service in serviceOutputModel)
        {
            if (service.Executor != null)
                service.ExecutorName = service.Executor.Name;

            if (service.Type != null)
                service.TypeName = service.Type.Title;
        }

        return serviceOutputModel;
    }

    public ServiceOutputModel GetServiceById(int id)
    {
        var serviceId = SingletoneStorage.GetStorage().Storage.Services.Where(s => s.Id == id);
        var serviceOutputModel = _mapper.Map<ServiceOutputModel>(serviceId);
        return serviceOutputModel;
    }
}