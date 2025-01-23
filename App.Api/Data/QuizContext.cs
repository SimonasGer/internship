using App.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Api.Data;

public class QuizContext(DbContextOptions<QuizContext> options)
    : DbContext(options)
{
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<QuestionType> QuestionTypes => Set<QuestionType>();
    public DbSet<Score> Scores => Set<Score>();
    public DbSet<Answer> Answers => Set<Answer>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QuestionType>().HasData(
            new { Id = 1, Name = "Radio" },
            new { Id = 2, Name = "Select" },
            new { Id = 3, Name = "Freeform" }
        );

        modelBuilder.Entity<Question>().HasData(
            new { Id = 1, QuestionTypeId = 1, Name = "2 + 2" },
            new { Id = 2, QuestionTypeId = 1, Name = "2 * 2" },
            new { Id = 3, QuestionTypeId = 1, Name = "2 - 2" },
            new { Id = 4, QuestionTypeId = 1, Name = "2 / 2" },
            new { Id = 5, QuestionTypeId = 2, Name = "Select Latin alphabet letters" },
            new { Id = 6, QuestionTypeId = 2, Name = "Select Numbers" },
            new { Id = 7, QuestionTypeId = 2, Name = "Select symbols" },
            new { Id = 8, QuestionTypeId = 2, Name = "Select everything" },
            new { Id = 9, QuestionTypeId = 3, Name = "Enter the name of the company" },
            new { Id = 10, QuestionTypeId = 3, Name = "Enter the name of the maker of this app" }

        );

        modelBuilder.Entity<Score>().HasData(
            new { Id = 1, Email = "test@mail.com", Points = 500, Answers = new[] { 1, 5 }, CreateDate = DateTime.Parse("2011-12-30")}
        );

        modelBuilder.Entity<Score>()
            .Property(s => s.Answers)
            .HasConversion(
                v => string.Join(",", v), // Serialize to JSON
                v => v.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray() // Deserialize from JSON
            );

        modelBuilder.Entity<Answer>().HasData(
            new { Id = 1, Name = "1", QuestionId = 1, Points = 0, },
            new { Id = 2, Name = "2", QuestionId = 1, Points = 0, },
            new { Id = 3, Name = "3", QuestionId = 1, Points = 0, },
            new { Id = 4, Name = "4", QuestionId = 1, Points = 100, },

            new { Id = 5, Name = "1", QuestionId = 2, Points = 0, },
            new { Id = 6, Name = "2", QuestionId = 2, Points = 0, },
            new { Id = 7, Name = "3", QuestionId = 2, Points = 0, },
            new { Id = 8, Name = "4", QuestionId = 2, Points = 100, },

            new { Id = 9, Name = "0", QuestionId = 3, Points = 100, },
            new { Id = 10, Name = "1", QuestionId = 3, Points = 0, },
            new { Id = 11, Name = "2", QuestionId = 3, Points = 0, },
            new { Id = 12, Name = "3", QuestionId = 3, Points = 0, },

            new { Id = 13, Name = "1", QuestionId = 4, Points = 100, },
            new { Id = 14, Name = "2", QuestionId = 4, Points = 0, },
            new { Id = 15, Name = "3", QuestionId = 4, Points = 0, },
            new { Id = 16, Name = "4", QuestionId = 4, Points = 0, },

            new { Id = 17, Name = "a", QuestionId = 5, Points = 100, },
            new { Id = 18, Name = "1", QuestionId = 5, Points = 0, },
            new { Id = 19, Name = "2", QuestionId = 5, Points = 0, },
            new { Id = 20, Name = "*", QuestionId = 5, Points = 0, },

            new { Id = 21, Name = "a", QuestionId = 6, Points = 0, },
            new { Id = 22, Name = "1", QuestionId = 6, Points = 50, },
            new { Id = 23, Name = "2", QuestionId = 6, Points = 50, },
            new { Id = 24, Name = "*", QuestionId = 6, Points = 0, },

            new { Id = 25, Name = "a", QuestionId = 7, Points = 0, },
            new { Id = 26, Name = "2", QuestionId = 7, Points = 0, },
            new { Id = 27, Name = "3", QuestionId = 7, Points = 0, },
            new { Id = 28, Name = "*", QuestionId = 7, Points = 100, },

            new { Id = 29, Name = "a", QuestionId = 8, Points = 25, },
            new { Id = 30, Name = "1", QuestionId = 8, Points = 25, },
            new { Id = 31, Name = "2", QuestionId = 8, Points = 25, },
            new { Id = 32, Name = "*", QuestionId = 8, Points = 25, },

            new { Id = 33, Name = "present connection", QuestionId = 9, Points = 100, },
            new { Id = 34, Name = "simonas gerulis", QuestionId = 10, Points = 100, }
        );
    }
}