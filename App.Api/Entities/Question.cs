namespace App.Api.Entities;

public class Question
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int QuestionTypeId { get; set; }
    public QuestionType? QuestionType { get; set; }
}
