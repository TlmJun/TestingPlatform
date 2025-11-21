using AutoMapper;
using practice.Requests.Question;
using practice.Responses.Question;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Domain.Models;

namespace TestingPlatform.Infrastructure.Mappings;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<Question, QuestionDto>().ReverseMap();
        CreateMap<QuestionDto, QuestionResponse>();
        CreateMap<CreateQuestionRequest, QuestionDto>();
        CreateMap<UpdateQuestionRequest, QuestionDto>();
    }
}