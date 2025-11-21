using AutoMapper;
using practice.Requests.Attempt;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class AttemptProfile : Profile
{
   public AttemptProfile()
   {
       CreateMap<CreateAttemptRequest, AttemptDto>();
       CreateMap<UpdateAttemptRequest, AttemptDto>();
   }
}

