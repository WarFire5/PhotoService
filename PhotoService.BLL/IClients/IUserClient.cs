using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL.IClients;

public interface IUserClient
{
    public bool CheckAuthentication(LoginInputModel loginInputModel);
    public List<UsersOutputModel> GetAllUsers();
    
    public UsersOutputModel GetAllUsersById(int id);
    public List<UsersOutputModel> GetAllExecutors();
    public string GetUserNameByEmail(string email);
    public int GetUserIdByEmail(string email);

    // public void AddUser(UserInputModel userInputModel);
}