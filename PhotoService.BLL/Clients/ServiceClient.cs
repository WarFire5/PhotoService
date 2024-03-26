using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoService.BLL.Clients;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Clients;

public class ServiceClient :IServiceClient
{
    private readonly SingletoneStorage _storage;
    private readonly IMapper _mapper;

    public ServiceClient()
    {
        _storage = SingletoneStorage.GetStorage();
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }
    public ServiceOutputModel AddService(ServiceInputModel service)
    {
        throw new NotImplementedException();
    }

    public List<ServiceOutputModel> GetAllServices()
    {
        var services = SingletoneStorage.GetStorage().Storage.Services.
            Include(s=>s.Executor).
            Include(t=>t.Type).
            ToList();
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
        var serviceId = SingletoneStorage.GetStorage().Storage.Services.
            Where(s => s.Id == id);
        var serviceOutputModel = _mapper.Map<ServiceOutputModel>(serviceId);
        return serviceOutputModel;
    }
}