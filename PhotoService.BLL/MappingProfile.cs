using AutoMapper;
using PhotoService.BLL.Clients;
using PhotoService.BLL.IClients;
using PhotoService.BLL.Models.InputModels;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<UsersDto, UsersOutputModel>();
        CreateMap<UsersOutputModel, UsersDto>();
        CreateMap<UsersDto, UsersInputModel>();
        CreateMap<UserParametersForRegistrationInputModel, UsersDto>();
        CreateMap<UsersDto, UserParametersForRegistrationInputModel>();
        CreateMap<UserParametersForRegistrationInputModel, UsersDto>();
        
        CreateMap<TypesDto, TypeOutputModel>();
        CreateMap<TypeOutputModel,TypesDto>();
        
        CreateMap<ServicesDto, ServiceOutputModel>();
        CreateMap<ServiceOutputModel, ServicesDto>();
        
        CreateMap<OrderOutputModel,OrdersDto>();
        CreateMap<IOrderClient, OrderClient>();
        CreateMap<OrdersDto, OrderOutputModel>();
    }
}