using System.ComponentModel.DataAnnotations;
using App.Api.Entities;

namespace App.Api.Dtos;

public record class CreateScoreDto(
    [Required][StringLength(50)] string Email,
    [Required] DateTime CreateDate,
    [Required] int [] Answers,
    List<Answer> AnswersFull
);