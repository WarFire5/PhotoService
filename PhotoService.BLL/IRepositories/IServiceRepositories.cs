using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IRepositories;

public interface IServiceRepositories
{
  public ServiceOutputModel AddService(ServiceInputModel service);

  public List<ServiceOutputModel> GetAllServices();

  public ServiceOutputModel GetServiceById(int id);
}