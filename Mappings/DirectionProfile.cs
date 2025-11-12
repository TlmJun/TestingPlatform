using AutoMapper;
using TestingPlatform.Responses;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class DirectionProfile : Profile
{
    public DirectionProfile()
    {
        CreateMap<DirectionDto, DirectionResponse>();
    }
}