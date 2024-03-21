using PhotoService.DAL.DTO;

namespace PhotoService.DAL.IRepositories;

public interface IServiceRepository
{
    public List<ServicesDto> GetAllServices();
    public List<ServicesDto> GetServiceById();
    public ServicesDto AddService(ServicesDto services);
}