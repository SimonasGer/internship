using App.Api.Dtos;
using App.Api.Entities;

namespace App.Api.Mapping;

public static class QuestionMapping
{
    public static QuestionDto ToQuestionDto(this Question question)
    {
        return new(
            question.Id,
            question.Name,
            question.QuestionType!.Name
        );
    }    
}
