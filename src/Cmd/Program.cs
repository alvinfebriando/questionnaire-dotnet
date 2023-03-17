using Questionnaire.Application.Service.DocumentPlanning;
using Questionnaire.Application.Service.MicroPlanning;
using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Application.Service.Realization;
using Questionnaire.Application.Service.Rule;
using Questionnaire.Domain.Entities;
using Questionnaire.Infrastructure;
using Questionnaire.Infrastructure.Persistence.InMemory;

const string place = "usu";
var date = new DateOnly(2022, 12, 28);
const string subject = "kepuasan pengajaran mata kuliah pemrograman web kom a";
const string respondent = "mahasiswa";
const string lecturer = "pak alvin";
const int questionCount = 13;
const int aspectCount = 6;

// Kesempatan bertanya * 2
// Penggunaan e-learning * 3
// Transparansi nilai * 3
// Kedisiplinan waktu * 2
// Rencana kontrak kuliah * 2
// Penguasaan materi * 1
var scores = new List<double>
{
    4.1,
    4.0,
    4.2,
    4.1,
    4.2,
    2.4,
    2.9,
    3,
    1.8,
    2.5,
    3.8,
    3.6,
    4.5
};

// var answers = scores.Select((score, index) => new Answer(Guid.NewGuid() ,score, Data.Questions[index])).ToList();
var answers = scores.Select((score, index) => new Answer()).ToList();
var averageScore = Preprocessing.CalculateAverageScore(answers);


var contentRule = new ContentRule();
var structureRule = new StructureRule();
var dPlan = new DocumentPlanning(contentRule, structureRule);

var content =
    dPlan.DetermineContent(
        place,
        date,
        subject,
        respondent,
        lecturer,
        averageScore,
        questionCount,
        aspectCount,
        answers);
var structure = dPlan.DetermineStructure(content.Point);

var lex = new Lexicalization();
var templateProvider = new TemplateProvider();
var mPlan = new MicroPlanning(lex, templateProvider);
mPlan.Init(content, structure);
var topics = mPlan.Create();

var realization = new Realization();
realization.Init(topics);
realization.AddFormatter(new CapitalSentenceFormatter());

var paragraph = realization.LinguisticRealization();

Console.WriteLine(string.Join("", paragraph));