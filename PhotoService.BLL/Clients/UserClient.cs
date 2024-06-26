﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        bool result = false;
        using (var context = new Context())
        {
            var usersList = context.Users.ToList();

            foreach (var user in usersList)
            {
                if (loginInputModel.Mail == user.Mail && loginInputModel.Password == user.Password)
                {
                    result = true;
                }
            }

            return result;
        }
    }
    
    public bool CheckIsBlocked(LoginInputModel loginInputModel)
    {
        bool result = false;
        using (var context = new Context())
        {
            var usersList = context.Users.ToList();

            foreach (var user in usersList)
            {
                if (loginInputModel.Mail == user.Mail && loginInputModel.Password == user.Password && user.IsBlocked == false)
                {
                    result = true;
                }
            }

            return result;
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
        var users = SingletoneStorage.GetStorage().Storage.Users.Where(r => r.Role.Id == 2)
            .Include(s => s.Specialization).ToList();

        var userOutputModel = _mapper.Map<List<UsersOutputModel>>(users);

        foreach (var user in userOutputModel)
        {
            if (user.Specialization != null)
            {
                user.TypeSpecialization = user.Specialization.Id;
            }
        }

        return userOutputModel;
    }

    public List<UsersOutputModel> GetAllCustomers()
    {
        var users = SingletoneStorage.GetStorage().Storage.Users.Where(r => r.Role.Id == 3).ToList();

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

    public void AddUser(UserParametersForRegistrationInputModel userParametersForRegistrationInputModel)
    {
        UsersDto user = _mapper.Map<UsersDto>(userParametersForRegistrationInputModel);
        _storage.Storage.Users.Add(user);
        _storage.Storage.SaveChanges();
    }
}