using App.Api.Dtos;
using App.Api.Entities;

namespace App.Api.Mapping;

public static class ScoreMapping
{
    public static Score ToEntity(this CreateScoreDto score)
    {
        return new Score()
        {
            Email = score.Email,
            Answers = score.Answers,
            AnswersFull = score.AnswersFull,
            CreateDate = score.CreateDate,
        };
    }
    public static ScoreDto ToScoreDto(this Score score)
    {
        return new(
            score.Id, 
            score.Email, 
            score.Points,
            score.Answers,
            score.CreateDate);
    } 
}
