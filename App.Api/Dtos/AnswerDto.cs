namespace App.Api.Dtos;

public record class AnswerDto(
    int Id, 
    string Name, 
    int Points,
    string Question);
