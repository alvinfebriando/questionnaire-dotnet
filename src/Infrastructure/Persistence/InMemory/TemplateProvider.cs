﻿using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Infrastructure.Persistence.InMemory;

public class TemplateProvider : ITemplateProvider
{
    public Dictionary<string, string> Template { get; set; } =
        new()
        {
            {
                "opening",
                "pada tanggal {Date}, telah dilakukan survey kepuasan pengajaran pada mata kuliah {Subject} yang dijawab oleh {Respondent} responden di kelas {Place}."
            },
            {
                "performance",
                "dalam penilaian ini, {Complement-0} {Search-mendapat} hasil yang {Status}."
            },
            {
                "average",
                "{Complement-0}{Complement-1} {Search-mendapat} {Search-nilai} total sebesar {AverageScore} dari {QuestionCount} pertanyaan yang dikelompokkan menjadi {AspectCount} aspek."
            },
            {
                "good1",
                "{Complement-0}untuk {Search-aspek} {Answer.Section}, {Lecturer} {Complement-1}sudah menjalankannya dengan baik, dengan {Search-nilai} yang {Search-didapatkan} adalah {Answer.AverageScore}."
            },
            {
                "good2",
                "{Complement-0}untuk {Search-aspek} {Answer.Section} dan {second.Section}, {Lecturer} {Complement-1}sudah menjalankannya dengan baik, dengan {Search-nilai} yang {Search-didapatkan} masing-masing adalah {Answer.AverageScore} dan {second.AverageScore}."
            },
            {
                "good3",
                "{Complement-0}untuk {Search-aspek} {Answer.Section}, {second.Section}, dan {third.Section}, {Lecturer} {Complement-1}sudah menjalankannya dengan baik, dengan {Search-nilai} yang {Search-didapatkan} masing-masing adalah {Answer.AverageScore}, {second.AverageScore}, {third.AverageScore}."
            },
            {
                "bad1",
                "{Complement-0}{Lecturer} {Complement-1}kurang sukses dalam {Search-aspek} {Answer.Section}, dengan {Search-nilai} {Search-didapatkan} sebesar {Answer.AverageScore}."
            },
            {
                "bad2",
                "{Complement-0}{Lecturer} {Complement-1}kurang sukses dalam {Search-aspek} {Answer.Section} dan {second.Section}, dengan {Search-nilai} yang {Search-didapatkan} masing-masingnya adalah {Answer.AverageScore} dan {second.AverageScore}."
            },
            {
                "bad3",
                "{Complement-0}{Lecturer} {Complement-1}kurang sukses dalam menjalankan {Search-aspek} {Answer.Section}, {second.Section}, dan {third.Section}, dengan {Search-nilai} yang {Search-didapatkan} masing-masingnya adalah {Answer.AverageScore}, {second.AverageScore}, {third.AverageScore}."
            },
            {
                "no good",
                "{Complement-0}{Lecturer} {Complement-1}belum mencapai hasil yang memuaskan, karena dari pertanyaan yang diajukan, {Search-nilai} {Search-tertinggi} hanya sebesar {Answer.AverageScore} untuk pertanyaan dari aspek {Answer.Section}."
            },
            {
                "no bad",
                "{Complement-0}tidak ada {Search-aspek} yang dinilai di bawah standar, dengan {Search-nilai} {Search-terendah} yang {Search-didapatkan} sebesar {Answer.AverageScore} untuk pertanyaan dari aspek {Answer.Section}."
            },
            {
                "detail",
                "{Complement-0}berikut adalah nilai rata-rata jawaban dari {Search-aspek} yang {Complement-1} yaitu {Answer.Section}:\n"
            },
            {
                "advice1",
                "{Lecturer} dapat melakukan cara ini untuk meningkatkan {Search-nilai} evaluasi, yaitu {advice}."
            },
            {
                "advice2",
                "{Lecturer} dapat melakukan cara-cara ini untuk meningkatkan {Search-nilai} hasil evaluasi yaitu, {advice1} dan {advice2}."
            },
            {
                "advice3",
                "{Lecturer} dapat melakukan cara-cara ini untuk meningkatkan {Search-nilai} hasil evaluasi yaitu, {advice1}, {advice2}, dan {advice3}."
            },
            {
                "no advice",
                "berdasarkan hasil kuesioner di atas, performa {Lecturer} sudah cukup baik, namun beliau dapat melakukan cara berikut untuk mempertahankan nilai pada evaluasi mendatang yaitu {advice} ."
            },
            {
                "closing",
                "demikian hasil survei ini kami sampaikan, semoga pengajaran di mata kuliah {Subject} dapat semakin baik dan memuaskan untuk semua pihak."
            }
        };
}