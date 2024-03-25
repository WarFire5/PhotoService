using AutoMapper;
using PhotoService.BLL.Models.OutputModels;
using PhotoService.DAL.DTO;

namespace PhotoService.BLL;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<OrdersDto, OrderOutputModel>();
        CreateMap<OrderOutputModel,OrdersDto >();
        CreateMap<UsersDto, UsersOutputModel>();
        CreateMap<UsersOutputModel, UsersDto>();
        CreateMap<TypesDto, TypeOutputModel>();
        CreateMap<TypeOutputModel,TypesDto>();
    }
}