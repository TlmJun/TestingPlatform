using AutoMapper;
using Presentation_Layer.Responses.Direction;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class DirectionProfile : Profile
{
    public DirectionProfile()
    {
        CreateMap<DirectionDto, DirectionResponse>();
    }
}