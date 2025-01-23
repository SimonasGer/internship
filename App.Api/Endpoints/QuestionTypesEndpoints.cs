using App.Api.Data;
using App.Api.Entities;
using App.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Api.Endpoints;

public static class QuestionTypesEndpoints
{
    public static RouteGroupBuilder MapQuestionTypesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("questiontypes");

        group.MapGet("/", async (QuizContext dbContext) =>
            await dbContext.QuestionTypes
                           .Select(questionType => questionType.ToQuestionTypeDto())
                           .AsNoTracking()
                           .ToListAsync());

        return group;
    }
}
