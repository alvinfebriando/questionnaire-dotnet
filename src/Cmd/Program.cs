using Questionnaire.Application.DocumentPlanning;
using Questionnaire.Application.MicroPlanning;
using Questionnaire.Application.Realization;
using Questionnaire.Application.Rule;
using Questionnaire.Domain.Entities;
using Questionnaire.Infrastructure;
using Questionnaire.Infrastructure.Persistence.InMemory;

const string place = "usu";
var date = new DateOnly(2022, 12, 28);
const string subject = "topik";
const string respondent = "mahasiswa";
const string lecturer = "pak alvin";


var answer1 = new Answer(2, Data.Questions[0]);
var answer2 = new Answer(3, Data.Questions[1]);
var answer3 = new Answer(4, Data.Questions[2]);
var answer4 = new Answer(3.5, Data.Questions[3]);
var answer5 = new Answer(4.2, Data.Questions[4]);
var answers = new List<Answer> { answer1, answer2, answer3,answer4,answer5 };

var dPlan = new DocumentPlanning();

var contentRule = new ContentRule();
var structureRule = new StructureRule();

var content =
    dPlan.DetermineContent(place, date, subject, respondent, lecturer, answers, contentRule);
var structure = dPlan.DetermineStructure(content.Point, structureRule);

var lex = new Lexicalization();
var mPlan = new MicroPlanning(content, structure, lex);
var topics = mPlan.Create();

var realization = new Realization(topics);
var paragraph = realization.ConvertToSentence();

Console.WriteLine(string.Join(" ", paragraph));