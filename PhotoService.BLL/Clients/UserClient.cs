using AutoMapper;
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

    public List<UsersOutputModel> GetAllUsers()
    {
            var users = SingletoneStorage.GetStorage().Storage.Users.ToList();
            var userOutputModel = _mapper.Map<List<UsersOutputModel>>(users);
            return userOutputModel;
    }
    
    public List<UsersOutputModel> GetAllExecutors()
    {
        var users = SingletoneStorage.GetStorage().Storage.Users
            .Where(r => r.Role.Id == 2)
            .ToList();
        
        var userOutputModel = _mapper.Map<List<UsersOutputModel>>(users);
        return userOutputModel;
    }
    
    public string GetUserNameByEmail(string email)
    {
        using (var context = new Context())
        {
            var user = context.Users.SingleOrDefault(u => u.Mail == email);
            return user != null ? user.Name : null;
        }
    }    
    
    public int GetUserIdByEmail(string email)
    {
        using (var context = new Context())
        {
            var user = context.Users.SingleOrDefault(u => u.Mail == email);
            return user != null ? user.Id : default;
        }
    }

    public void AddUser(UserInputModel userInputModel)
    {
        UsersDto user = _mapper.Map<UsersDto>(userInputModel);
        _storage.Storage.Users.Add(user);
        _storage.Storage.SaveChanges();
    }
}