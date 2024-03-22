using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Clients;

public class UserClient : IUserClient
{
    private readonly SingletoneStorage _storage;
    private readonly IMapper _mapper;

    public UserClient()
    {
        _storage = SingletoneStorage.GetStorage();
        IConfigurationProvider config = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });
        _mapper = new Mapper(config);
    }

    public bool CheckAuthentication(LoginInputModel loginInputModel)
    {
        using (var context = new Context())
        {
            var usersList = context.Users.ToList();

            foreach (var user in usersList)
            {
                if (loginInputModel.Mail == user.Mail && loginInputModel.Password == user.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
    
    public RolesDto GetRoleByEmail(string mail)
    {
        var users = SingletoneStorage.GetStorage().Storage.Users.Include(u => u.Role);
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