using AutoMapper;
using TestingPlatform.Responses;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<ProjectDto, ProjectResponse>();
    }
}

