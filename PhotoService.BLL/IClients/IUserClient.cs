using PhotoService.BLL.Models.InputModels;

namespace PhotoService.BLL.IClients;

public interface IUserClient
{
    public bool CheckAuthentication(LoginInputModel loginInputModel);

    public string GetUserNameByEmail(string email);
    public int GetUserIdByEmail(string email);

    // public void AddUser(UserInputModel userInputModel);
}