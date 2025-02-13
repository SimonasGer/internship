﻿// <auto-generated />
using System;
using App.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Api.Data.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20250122144024_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("App.Api.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ScoreId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1",
                            Points = 0,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "2",
                            Points = 0,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "3",
                            Points = 0,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "4",
                            Points = 100,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "1",
                            Points = 0,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "2",
                            Points = 0,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "3",
                            Points = 0,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "4",
                            Points = 100,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "0",
                            Points = 100,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "1",
                            Points = 0,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "2",
                            Points = 0,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "3",
                            Points = 0,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            Name = "1",
                            Points = 100,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            Name = "2",
                            Points = 0,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            Name = "3",
                            Points = 0,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            Name = "4",
                            Points = 0,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 17,
                            Name = "a",
                            Points = 100,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 18,
                            Name = "1",
                            Points = 0,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 19,
                            Name = "2",
                            Points = 0,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 20,
                            Name = "*",
                            Points = 0,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 21,
                            Name = "a",
                            Points = 0,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 22,
                            Name = "1",
                            Points = 50,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 23,
                            Name = "2",
                            Points = 50,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 24,
                            Name = "*",
                            Points = 0,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 25,
                            Name = "a",
                            Points = 0,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 26,
                            Name = "2",
                            Points = 0,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 27,
                            Name = "3",
                            Points = 0,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 28,
                            Name = "*",
                            Points = 100,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 29,
                            Name = "a",
                            Points = 25,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 30,
                            Name = "1",
                            Points = 25,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 31,
                            Name = "2",
                            Points = 25,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 32,
                            Name = "*",
                            Points = 25,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 33,
                            Name = "present connection",
                            Points = 100,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 34,
                            Name = "simonas gerulis",
                            Points = 100,
                            QuestionId = 10
                        });
                });

            modelBuilder.Entity("App.Api.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "2 + 2",
                            QuestionTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "2 * 2",
                            QuestionTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "2 - 2",
                            QuestionTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "2 / 2",
                            QuestionTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Select Latin alphabet letters",
                            QuestionTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Select Numbers",
                            QuestionTypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Select symbols",
                            QuestionTypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Select everything",
                            QuestionTypeId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Enter the name of the company",
                            QuestionTypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Enter the name of the maker of this app",
                            QuestionTypeId = 3
                        });
                });

            modelBuilder.Entity("App.Api.Entities.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Radio"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Select"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Freeform"
                        });
                });

            modelBuilder.Entity("App.Api.Entities.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answers = "1,5",
                            CreateDate = new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test@mail.com",
                            Points = 500
                        });
                });

            modelBuilder.Entity("App.Api.Entities.Answer", b =>
                {
                    b.HasOne("App.Api.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Api.Entities.Score", null)
                        .WithMany("AnswersFull")
                        .HasForeignKey("ScoreId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("App.Api.Entities.Question", b =>
                {
                    b.HasOne("App.Api.Entities.QuestionType", "QuestionType")
                        .WithMany()
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionType");
                });

            modelBuilder.Entity("App.Api.Entities.Score", b =>
                {
                    b.Navigation("AnswersFull");
                });
#pragma warning restore 612, 618
        }
    }
}
