using PhotoService.BLL.Models.InputModels;

namespace PhotoService.BLL.IClients;

public interface IUserClient
{
    public bool CheckAuthentication(LoginInputModel loginInputModel);
    
    // public void AddUser(UserInputModel userInputModel);
}