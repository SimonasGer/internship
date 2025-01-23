using App.Api.Dtos;
using App.Api.Entities;

namespace App.Api.Mapping;

public static class QuestionTypeMapping
{
    public static QuestionTypeDto ToQuestionTypeDto(this QuestionType questionType)
    {
        return new QuestionTypeDto(
            questionType.Id, 
            questionType.Name);
    }
}
