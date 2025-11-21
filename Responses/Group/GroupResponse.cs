using TestingPlatform.Responses;
using Presentation_Layer.Responses.Course;
using Presentation_Layer.Responses.Direction;
using Presentation_Layer.Responses.Project;
namespace Presentation_Layer.Responses.Group;

public class GroupResponse : BaseResponse
{
    public DirectionResponse? Direction { get; set; }
    public CourseResponse? Course { get; set; }
    public ProjectResponse? Project { get; set; }
    public class ShortGroupResponse : BaseResponse;
}


