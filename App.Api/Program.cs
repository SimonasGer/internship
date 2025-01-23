using App.Api.Data;
using App.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("App");
builder.Services.AddSqlite<QuizContext>(connString);

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();
app.UseCors("AllowSpecificOrigin");

app.MapQuestionEndpoints();
app.MapQuestionTypesEndpoints();
app.MapScoreEndpoints();
app.MapAnswerEndpoints();

await app.MigrateDbAsync();

app.Run();
