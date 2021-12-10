using AutoMapper;
using RayWebAPI.Entities;
using RayWebAPI.Models.Users;

namespace RayWebAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(um => um.Login, x => x.MapFrom(um => um.Email));
            CreateMap<RegisterModel, User>()
                .ForMember(u => u.Email, x => x.MapFrom(um => um.Login));
            CreateMap<UpdateModel, User>()
                .ForMember(u => u.Email, x => x.MapFrom(um => um.Login));
        }
    }
}