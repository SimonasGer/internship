using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Points = table.Column<int>(type: "INTEGER", nullable: false),
                    Answers = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Points = table.Column<int>(type: "INTEGER", nullable: false),
                    ScoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Scores_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Scores",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Radio" },
                    { 2, "Select" },
                    { 3, "Freeform" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "Answers", "CreateDate", "Email", "Points" },
                values: new object[] { 1, "1,5", new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@mail.com", 500 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Name", "QuestionTypeId" },
                values: new object[,]
                {
                    { 1, "2 + 2", 1 },
                    { 2, "2 * 2", 1 },
                    { 3, "2 - 2", 1 },
                    { 4, "2 / 2", 1 },
                    { 5, "Select Latin alphabet letters", 2 },
                    { 6, "Select Numbers", 2 },
                    { 7, "Select symbols", 2 },
                    { 8, "Select everything", 2 },
                    { 9, "Enter the name of the company", 3 },
                    { 10, "Enter the name of the maker of this app", 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Name", "Points", "QuestionId", "ScoreId" },
                values: new object[,]
                {
                    { 1, "1", 0, 1, null },
                    { 2, "2", 0, 1, null },
                    { 3, "3", 0, 1, null },
                    { 4, "4", 100, 1, null },
                    { 5, "1", 0, 2, null },
                    { 6, "2", 0, 2, null },
                    { 7, "3", 0, 2, null },
                    { 8, "4", 100, 2, null },
                    { 9, "0", 100, 3, null },
                    { 10, "1", 0, 3, null },
                    { 11, "2", 0, 3, null },
                    { 12, "3", 0, 3, null },
                    { 13, "1", 100, 4, null },
                    { 14, "2", 0, 4, null },
                    { 15, "3", 0, 4, null },
                    { 16, "4", 0, 4, null },
                    { 17, "a", 100, 5, null },
                    { 18, "1", 0, 5, null },
                    { 19, "2", 0, 5, null },
                    { 20, "*", 0, 5, null },
                    { 21, "a", 0, 6, null },
                    { 22, "1", 50, 6, null },
                    { 23, "2", 50, 6, null },
                    { 24, "*", 0, 6, null },
                    { 25, "a", 0, 7, null },
                    { 26, "2", 0, 7, null },
                    { 27, "3", 0, 7, null },
                    { 28, "*", 100, 7, null },
                    { 29, "a", 25, 8, null },
                    { 30, "1", 25, 8, null },
                    { 31, "2", 25, 8, null },
                    { 32, "*", 25, 8, null },
                    { 33, "present connection", 100, 9, null },
                    { 34, "simonas gerulis", 100, 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_ScoreId",
                table: "Answers",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "QuestionTypes");
        }
    }
}
