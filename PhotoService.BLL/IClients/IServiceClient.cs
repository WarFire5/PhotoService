using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface IServiceClient
{
  public ServiceOutputModel AddService(ServiceInputModel service);

  public List<ServiceOutputModel> GetAllServices();

  public ServiceOutputModel GetServiceById(int id);
}