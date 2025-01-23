using App.Api.Data;
using App.Api.Entities;
using App.Api.Dtos;
using App.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Api.Endpoints;

public static class ScoreEndpoints
{
    public static RouteGroupBuilder MapScoreEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("score");

        group.MapGet("/", async (QuizContext dbContext) =>
            await dbContext.Scores
                           .OrderByDescending(score => score.Points)
                           .Take(10)
                           .Select(score => score.ToScoreDto())
                           .AsNoTracking()
                           .ToListAsync());

        group.MapPost("/", async (CreateScoreDto newScore, QuizContext dbContext) =>
        {
            Score score = newScore.ToEntity();

            var answers = await dbContext.Answers
                        .Where(answer => score.Answers.Contains(answer.Id))
                        .Include(answer => answer.Question)
                        .Select(answer => answer.ToAnswerDto())
                        .AsNoTracking()
                        .ToListAsync();
            
            var points = 0;
            foreach (var answer in answers){
                points += answer.Points;
            }
            score.Points = points;
            var email = score.Email;
            var createDate = score.CreateDate;

            dbContext.Scores.Add(score);
            await dbContext.SaveChangesAsync();

            return Results.Created($"/score/{score.Id}", new 
            {
                answers,
                points,
                email,
                createDate
            });
        });
        return group;
    }
}