﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Questionnaire.Infrastructure.Persistence.Postgres;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Questionnaire.Domain.Entities.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Score")
                        .HasColumnType("double precision");

                    b.Property<Guid>("SurveyQuestionQuestionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SurveyQuestionSurveyId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SurveyQuestionSurveyId", "SurveyQuestionQuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.Lecturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Advice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"),
                            Advice = "dosen memberikan kesempatan bertanya di dalam kelas",
                            Section = "kesempatan bertanya",
                            Title = "dosen memberikan kesempatan bertanya di dalam kelas?"
                        },
                        new
                        {
                            Id = new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"),
                            Advice = "dosen memberikan kesempatan bertanya di luar kelas",
                            Section = "kesempatan bertanya",
                            Title = "dosen memberikan kesempatan bertanya di luar kelas?"
                        },
                        new
                        {
                            Id = new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"),
                            Advice = "dosen memanfaatkan forum yang sudah tersedia",
                            Section = "penggunaan elearning",
                            Title = "dosen menggunakan forum e-learning?"
                        },
                        new
                        {
                            Id = new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"),
                            Advice = "dosen memanfaatkan kuis yang sudah tersedia",
                            Section = "penggunaan elearning",
                            Title = "dosen menggunakan kuis e-learning?"
                        },
                        new
                        {
                            Id = new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"),
                            Advice = "dosen memanfaatkan konferensi yang sudah tersedia",
                            Section = "penggunaan elearning",
                            Title = "dosen menggunakan konferensi video e-learning?"
                        },
                        new
                        {
                            Id = new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"),
                            Advice = "dosen memberikan nilai tugas secara terbuka",
                            Section = "transparansi nilai",
                            Title = "dosen secara terbuka menyampaikan hasil tugas"
                        },
                        new
                        {
                            Id = new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"),
                            Advice = "dosen memberikan nilai kuis secara terbuka",
                            Section = "transparansi nilai",
                            Title = "dosen secara terbuka menyampaikan hasil kuis"
                        },
                        new
                        {
                            Id = new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"),
                            Advice = "dosen memberikan nilai uts dan uas secara terbuka",
                            Section = "transparansi nilai",
                            Title = "dosen secara terbuka menyampaikan hasil uts dan uas"
                        },
                        new
                        {
                            Id = new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"),
                            Advice = "dosen hadir tepat waktu (maksimal 15 menit)",
                            Section = "kedisiplinan waktu",
                            Title = "dosen hadir tepat waktu"
                        },
                        new
                        {
                            Id = new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"),
                            Advice = "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan",
                            Section = "kedisiplinan waktu",
                            Title = "perkuliahan dilaksanakan sesuai dengan alokasi waktu"
                        },
                        new
                        {
                            Id = new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"),
                            Advice = "menyampaikan materi sesuai dengan kontrak kuliah",
                            Section = "rencana kontrak kuliah",
                            Title = "materi yang disampaikan sudah sesuai dengan rpp dan rps?"
                        },
                        new
                        {
                            Id = new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"),
                            Advice = "memberikan tugas sesuai dengan kontrak kuliah",
                            Section = "rencana kontrak kuliah",
                            Title = "tugas yang diberikan sesuai dengan beban studi?"
                        },
                        new
                        {
                            Id = new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"),
                            Advice = "mencari referensi terkait materi yang diajarkan",
                            Section = "penguasaan materi",
                            Title = "dosen menguasai materi perkuliahan dengan baik?"
                        });
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.Survey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AspectCount")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("LecturerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuestionCount")
                        .HasColumnType("integer");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LecturerId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.SurveyQuestion", b =>
                {
                    b.Property<Guid>("SurveyId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.HasKey("SurveyId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("SurveyQuestions");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.Answer", b =>
                {
                    b.HasOne("Questionnaire.Domain.Entities.SurveyQuestion", "SurveyQuestion")
                        .WithMany()
                        .HasForeignKey("SurveyQuestionSurveyId", "SurveyQuestionQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SurveyQuestion");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.Survey", b =>
                {
                    b.HasOne("Questionnaire.Domain.Entities.Lecturer", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.SurveyQuestion", b =>
                {
                    b.HasOne("Questionnaire.Domain.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Questionnaire.Domain.Entities.Survey", "Survey")
                        .WithMany("SurveyQuestions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Questionnaire.Domain.Entities.Survey", b =>
                {
                    b.Navigation("SurveyQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
