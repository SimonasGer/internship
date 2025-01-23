using App.Api.Dtos;
using App.Api.Entities;

namespace App.Api.Mapping;

public static class AnswerMapping
{
    
    public static AnswerDto ToAnswerDto(this Answer answer)
    {
        return new(
            answer.Id,
            answer.Name,
            answer.Points,
            answer.Question!.Name
        );
    }    
}
