using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Application.Interfaces;
using TestingPlatform.Domain.Enums;
using TestingPlatform.Domain.Models;
using practice.Responses.Test;
using practice.Requests.Test;
using static System.Net.Mime.MediaTypeNames;

namespace practice.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TestController(ITestRepository testRepository, IMapper mapper) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetTests()
    {
        var tests = await testRepository.GetAllAsync(null, new List<int>(), new List<int>());
        return Ok(mapper.Map<IEnumerable<TestResponse>>(tests));
    }
    [HttpGet(("{Id:int}"))]
    public async Task<IActionResult> GetByIdAsync(int Id)
    {
        var id = await testRepository.GetByIdAsync(Id);
        return Ok(mapper.Map<IEnumerable<TestResponse>>(id));
    }
    [HttpPost]
    public async Task<IActionResult> CreateTest([FromBody] CreateTestRequest test)
    {
        var testDto = new TestDto()
        {
            Title = test.Title,
            Description = test.Description,
            IsRepeatable = test.IsRepeatable,
            Type = test.Type,
            PublishedAt = test.PublishedAt,
            Deadline = test.Deadline,
            DurationMinutes = test.DurationMinutes,
            IsPublic = test.IsPublic,
            PassingScore = test.PassingScore,
            MaxAttempts = test.MaxAttempts
        };
        var testId = await testRepository.CreateAsync(testDto);
        return StatusCode(StatusCodes.Status201Created, new { Id = testId });
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTest([FromBody] UpdateTestRequest test)
    {
        await testRepository.UpdateAsync(mapper.Map<TestDto>(test));
        return NoContent();
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteTest(int id)
    {
        await testRepository.DeleteAsync(id);
        return NoContent();
    }

}

