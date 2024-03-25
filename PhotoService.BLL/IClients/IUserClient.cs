using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.IClients;

public interface IUserClient
{
    public bool CheckAuthentication(LoginInputModel loginInputModel);

    public List<UsersOutputModel> GetAllUsers();
    public List<UsersOutputModel> GetAllExecutors();
    

    // public void AddUser(UserInputModel userInputModel);
}