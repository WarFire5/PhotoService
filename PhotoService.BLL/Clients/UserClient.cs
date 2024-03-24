using AutoMapper;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
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
    
    public string GetUserNameByEmail(string email)
    {
        using (var context = new Context())
        {
            var user = context.Users.SingleOrDefault(u => u.Mail == email);
            return user != null ? user.Name : null;
        }
    }
}