using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface ITypeClient
{
    public List<TypeOutputModel> GetAllTypes();
}