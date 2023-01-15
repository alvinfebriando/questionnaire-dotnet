using Questionnaire.Application.DocumentPlanning;
using Questionnaire.Application.MicroPlanning;
using Questionnaire.Application.Realization;
using Questionnaire.Application.Rule;
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
var scores = new List<double> { 4.1, 4.0, 4.2, 4.1, 4.2, 2.4, 2.9, 3, 1.8, 2.5, 3.8, 3.6, 4.5 };

var answers = scores.Select((score, index) => new Answer(score, Data.Questions[index])).ToList();

var dPlan = new DocumentPlanning();

var contentRule = new ContentRule();
var structureRule = new StructureRule();

var content =
    dPlan.DetermineContent(place, date, subject, respondent, lecturer, questionCount, aspectCount,
        answers, contentRule);
var structure = dPlan.DetermineStructure(content.Point, structureRule);

var lex = new Lexicalization();
var mPlan = new MicroPlanning(content, structure, lex);
var topics = mPlan.Create();

var realization = new Realization(topics);
realization.AddFormatter(new CapitalSentenceFormatter());

var paragraph = realization.ConvertToSentence();

Console.WriteLine(string.Join("", paragraph));