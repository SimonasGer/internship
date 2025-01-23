namespace App.Api.Dtos;

public record class QuestionDto(
    int Id, 
    string Name, 
    string QuestionType);
