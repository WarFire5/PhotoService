﻿using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;

namespace PhotoService.BLL.IClients;

public interface IUserClient
{
    public bool CheckAuthentication(LoginInputModel loginInputModel);
    public List<UsersOutputModel> GetAllUsers();
    public List<UsersOutputModel> GetAllExecutors();
    public List<UsersOutputModel> GetAllCustomers();
    public string GetUserNameByEmail(string email);
    public int GetUserIdByEmail(string email);
    public void AddUser(UserParametersForRegistrationInputModel userParametersForRegistrationInputModel);
    public bool CheckIsBlocked(LoginInputModel loginInputModel);

}