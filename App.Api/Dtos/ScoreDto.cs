namespace App.Api.Dtos;

public record class ScoreDto(
    int Id, 
    string Email, 
    int Points,
    int[] Answers,
    DateTime CreateDate);