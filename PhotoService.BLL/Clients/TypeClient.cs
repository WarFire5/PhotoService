using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoService.BLL.Clients;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Clients;

public class TypeClient :ITypeClient
{
    private readonly SingletoneStorage _storage;
    private readonly IMapper _mapper;
    
    public TypeClient()
    {
        _storage = SingletoneStorage.GetStorage();
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }
    
    public List<TypeOutputModel> GetAllTypes()
    {
        var types = SingletoneStorage.GetStorage().Storage.Types
            .Include(t => t.Title).ToList();
        var typeOutputModel = _mapper.Map<List<TypeOutputModel>>(types);
        return typeOutputModel;
    }
}