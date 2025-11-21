namespace practice.Requests.Attempt;
public class CreateAttemptRequest
{
    public int TestId { get; set; }

    public int StudentId { get; set; }
}
public class UpdateAttemptRequest
{
    public int Id { get; set; }
    public int StudentId { get; set; }
}

