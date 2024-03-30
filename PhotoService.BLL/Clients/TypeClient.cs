using AutoMapper;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.Clients;

public class TypeClient : ITypeClient
{
    private readonly IMapper _mapper;

    public TypeClient()
    {
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }

    public List<TypeOutputModel> GetAllTypes()
    {
        var types = SingletoneStorage.GetStorage().Storage.Types.ToList();
        var typeOutputModel = _mapper.Map<List<TypeOutputModel>>(types);
        return typeOutputModel;
    }
}