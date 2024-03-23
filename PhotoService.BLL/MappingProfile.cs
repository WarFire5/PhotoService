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
    }
}