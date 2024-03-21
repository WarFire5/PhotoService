using AutoMapper;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL;

public class UserClient: IUserClient
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
            List<UsersOutputModel> usersList = new List<UsersOutputModel>();
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

}