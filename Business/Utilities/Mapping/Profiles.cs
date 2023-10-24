using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>().ReverseMap();
        CreateMap<User, UserProfileDto>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();

        CreateMap<CategoryCreateDto, Category>().ReverseMap();
        CreateMap<CategoryUpdateDto, Category>().ReverseMap();
        CreateMap<Category, CategoryInfoDto>().ReverseMap();

    }
}