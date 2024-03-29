﻿namespace Questionnaire.Domain.Entities;

public class Answer : BaseEntity
{
    public Answer(Guid id, double score, SurveyQuestion surveyQuestion)
    {
        Score = score;
        SurveyQuestion = surveyQuestion;
        Id = id;
    }

    public Answer()
    {
        
    }

    public SurveyQuestion SurveyQuestion { get; set; }
    public double Score { get; set; }
    public User? AnsweredByUser { get; set; }
}