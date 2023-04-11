using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Tests.Message;

public static class Generator
{
    private static QuestionSection GetQuestionSection()
    {
        var sections = new List<QuestionSection>
        {
            QuestionSection.KedisiplinanWaktu,
            QuestionSection.KesempatanBertanya,
            QuestionSection.PenggunaanElearning,
            QuestionSection.PenguasaanMateri,
            QuestionSection.TransparansiNilai,
            QuestionSection.RencanaKontrakKuliah
        };
        return Util.GetRandom(sections);
    }

    private static double GetScore()
    {
        var score = new List<double>
        {
            1,
            2,
            3,
            4,
            5
        };
        return Util.GetRandom(score);
    }

    private static Lecturer GetLecturer()
    {
        var lecturers = new List<Lecturer>
        {
            new Lecturer { Id = Guid.NewGuid(), Name = "Budi", Title = LecturerTitle.Pak },
            new Lecturer { Id = Guid.NewGuid(), Name = "Joni", Title = LecturerTitle.Pak },
            new Lecturer { Id = Guid.NewGuid(), Name = "Susi", Title = LecturerTitle.Bu }
        };
        return Util.GetRandom(lecturers);
    }

    private static SurveyQuestion GenerateSurveyQuestions(
        Survey survey,
        Question question)
    {
        var sq = new SurveyQuestion
        {
            Question = question,
            QuestionId = question.Id,
            Survey = survey,
            SurveyId = survey.Id
        };
        return sq;
    }

    public static Survey GenerateSurvey()
    {
        var questions = GenerateQuestions(5);
        var surveyId = Guid.NewGuid();
        var questionList = questions.ToList();
        var aspectCount = questionList.GroupBy(q => q.Section).Count();
        var survey = new Survey
        {
            Id = surveyId,
            Place = "A",
            Date = new DateOnly(2023, 4, 11),
            Lecturer = GetLecturer(),
            Subject = "DDP",
            AspectCount = aspectCount,
            QuestionCount = questionList.Count
        };
        survey.SurveyQuestions =
            questionList.Select(q => GenerateSurveyQuestions(survey, q)).ToList();
        return survey;
    }

    public static IEnumerable<Question> GenerateQuestions(int n)
    {
        var questionId = Enumerable.Range(1, n).Select(_ => Guid.NewGuid());
        var questions = questionId.Select(
            (q, i) => new Question
            {
                Id = q,
                Advice = $"advice-{i}",
                Title = $"title-{i}",
                Section = GetQuestionSection(),
            });
        return questions;
    }

    public static IEnumerable<Answer> GenerateAnswers(int n)
    {
        var answerId = Enumerable.Range(1, n).Select(_ => Guid.NewGuid());
        var survey = GenerateSurvey();
        var answers = survey.SurveyQuestions.Zip(
            answerId,
            (x, y) => new Answer { Id = y, Score = GetScore(), SurveyQuestion = x });
        return answers;
    }

    public static AveragedAnswer GenerateAveragedAnswer()
    {
        var answers = GenerateAnswers(4);
        var section = GetQuestionSection();
        answers = answers.Select(
            a =>
            {
                a.SurveyQuestion.Question.Section = section;
                return a;
            });
        var averagedAnswer = new AveragedAnswer(GetQuestionSection(), GetScore(), answers);
        return averagedAnswer;
    }
}