using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhotoService.BLL.IClients;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Clients;

public class RoleClient: IRoleClient
{
    private readonly SingletoneStorage _storage;
    private readonly IMapper _mapper;

    public RoleClient()
    {
        _storage = SingletoneStorage.GetStorage();
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }
    
    public RolesDto GetRoleByEmail(string mail)
    {
        var users = SingletoneStorage.GetStorage().Storage.Users.Include(u => u.Role).Where(u=>u.Mail==mail).ToList();
        foreach (var user in users)
        {
            if (user.Mail == mail)
            {
                return user.Role;
            }
        }

        return null;
    }
}