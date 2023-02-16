using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure;

public static class Data
{
    public static readonly IList<Question> Questions = new List<Question>
    {
        new(
            1,
            "dosen memberikan kesempatan bertanya di dalam kelas?",
            QuestionSection.KesempatanBertanya,
            "dosen memberikan kesempatan bertanya di dalam kelas"),
        new(
            2,
            "dosen memberikan kesempatan bertanya di luar kelas?",
            QuestionSection.KesempatanBertanya,
            "dosen memberikan kesempatan bertanya di luar kelas"),
        new(
            3,
            "dosen menggunakan forum e-learning?",
            QuestionSection.PenggunaanElearning,
            "dosen memanfaatkan forum yang sudah tersedia"),
        new(
            4,
            "dosen menggunakan kuis e-learning?",
            QuestionSection.PenggunaanElearning,
            "dosen memanfaatkan kuis yang sudah tersedia"),
        new(
            5,
            "dosen menggunakan konferensi video e-learning?",
            QuestionSection.PenggunaanElearning,
            "dosen memanfaatkan konferensi yang sudah tersedia"),
        new(
            6,
            "dosen secara terbuka menyampaikan hasil tugas",
            QuestionSection.TransparansiNilai,
            "dosen memberikan nilai tugas secara terbuka"),
        new(
            7,
            "dosen secara terbuka menyampaikan hasil kuis",
            QuestionSection.TransparansiNilai,
            "dosen memberikan nilai kuis secara terbuka"),
        new(
            8,
            "dosen secara terbuka menyampaikan hasil uts dan uas",
            QuestionSection.TransparansiNilai,
            "dosen memberikan nilai uts dan uas secara terbuka"),
        new(
            9,
            "dosen hadir tepat waktu",
            QuestionSection.KedisiplinanWaktu,
            "dosen hadir tepat waktu (maksimal 15 menit)"),
        new(
            10,
            "perkuliahan dilaksanakan sesuai dengan alokasi waktu",
            QuestionSection.KedisiplinanWaktu,
            "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan"),
        new(
            11,
            "materi yang disampaikan sudah sesuai dengan rpp dan rps?",
            QuestionSection.RencanaKontrakKuliah,
            "menyampaikan materi sesuai dengan kontrak kuliah"
        ),
        new(
            12,
            "tugas yang diberikan sesuai dengan beban studi?",
            QuestionSection.RencanaKontrakKuliah,
            "memberikan tugas sesuai dengan kontrak kuliah"
        ),
        new(
            13,
            "dosen menguasai materi perkuliahan dengan baik?",
            QuestionSection.PenguasaanMateri,
            "mencari referensi terkait materi yang diajarkan"
        )
    };
}