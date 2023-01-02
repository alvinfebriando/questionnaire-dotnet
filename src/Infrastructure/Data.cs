using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure;

public static class Data
{
    public static readonly IList<Question> Questions = new List<Question>
    {
        new Question("dosen memberikan kesempatan bertanya di dalam kelas?",
            QuestionSection.KesempatanBertanya,
            "dosen memberikan kesempatan bertanya di dalam kelas"),
        new Question("dosen memberikan kesempatan bertanya di luar kelas?",
            QuestionSection.KesempatanBertanya,
            "dosen memberikan kesempatan bertanya di luar kelas"),
        new Question("dosen menggunakan forum e-learning?",
            QuestionSection.PenggunaanElearning,
            "dosen memanfaatkan forum yang sudah tersedia"),
        new Question("dosen menggunakan kuis e-learning?",
            QuestionSection.PenggunaanElearning,
            "dosen memanfaatkan kuis yang sudah tersedia"),
        new Question("dosen menggunakan konferensi video e-learning?",
            QuestionSection.PenggunaanElearning,
            "dosen memanfaatkan konferensi yang sudah tersedia"),
        new Question("dosen secara terbuka menyampaikan hasil tugas",
            QuestionSection.TransparansiNilai, "dosen memberikan nilai tugas secara terbuka"),
        new Question("dosen secara terbuka menyampaikan hasil kuis",
            QuestionSection.TransparansiNilai, "dosen memberikan nilai kuis secara terbuka"),
        new Question("dosen secara terbuka menyampaikan hasil uts dan uas",
            QuestionSection.TransparansiNilai, "dosen memberikan nilai uts dan uas secara terbuka"),
        new Question("dosen hadir tepat waktu", QuestionSection.KedisiplinanWaktu,
            "dosen hadir tepat waktu (maksimal 15 menit)"),
        new Question("perkuliahan dilaksanakan sesuai dengan alokasi waktu",
            QuestionSection.KedisiplinanWaktu,
            "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan"),
        new Question("materi yang disampaikan sudah sesuai dengan rpp dan rps?",
            QuestionSection.RencanaKontrakKuliah,
            "menyampaikan materi sesuai dengan kontrak kuliah"
        ),
        new Question("tugas yang diberikan sesuai dengan beban studi?",
            QuestionSection.RencanaKontrakKuliah,
            "memberikan tugas sesuai dengan kontrak kuliah"
        ),
        new Question("dosen menguasai materi perkuliahan dengan baik?",
            QuestionSection.PenguasaanMateri,
            "mencari referensi terkait materi yang diajarkan"
        )
    };
}