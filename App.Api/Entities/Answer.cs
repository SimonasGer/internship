namespace App.Api.Entities;

public class Answer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int QuestionId { get; set; }
    public int Points { get; set; }
    public Question? Question { get; set; }
}