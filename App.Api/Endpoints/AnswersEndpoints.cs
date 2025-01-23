using App.Api.Data;
using App.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Api.Endpoints;

public static class AnswersEndpoints
{
    public static RouteGroupBuilder MapAnswerEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("answers")
                       .WithParameterValidation();

        // GET /answers/{id}
        group.MapGet("/{id:int}", async (int id, QuizContext dbContext) =>
        {
            var answer = await dbContext.Answers
                                .Include(answer => answer.Question)
                                .Where(answer => answer.QuestionId == id)
                                .Select(answer => answer.ToAnswerDto())
                                .AsNoTracking()
                                .ToListAsync();

            return answer is not null 
                ? Results.Ok(answer)
                : Results.NotFound(new { Message = $"Answer with ID {id} not found." });
        });

        return group;
    }
}
