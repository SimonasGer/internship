using App.Api.Data;
using App.Api.Dtos;
using App.Api.Entities;
using App.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Api.Endpoints;

public static class QuestionsEndpoints
{
    public static RouteGroupBuilder MapQuestionEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("questions")
                       .WithParameterValidation();

        // GET /questions
        group.MapGet("/", async (QuizContext dbContext) => 
            await dbContext.Questions
                     .Include(question => question.QuestionType)
                     .Select(question => question.ToQuestionDto())
                     .AsNoTracking()
                     .ToListAsync());

        return group;
    }
}
