using AutoMapper;
using practice.Requests.User;
using practice.Responses.User;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, UserResponse>()
            .ForMember(dest => dest.Password, opt => opt.Ignore());

        CreateMap<UpdateUserRequest, UserDto>();

        CreateMap<CreateUserRequest, UserDto>();
    }
}