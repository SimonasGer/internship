namespace App.Api.Entities;
public class Score
{
    public int Id { get; set; }
    public int Points { get; set; }
    public required int[] Answers { get; set; }
    public required List<Answer> AnswersFull { get; set; }
    public required string Email { get; set; }
    public required DateTime CreateDate { get; set; }
}