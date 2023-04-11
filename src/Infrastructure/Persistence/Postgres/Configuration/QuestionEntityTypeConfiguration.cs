using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class QuestionEntityTypeConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(q => q.Id);
        builder.Property(q => q.Id).ValueGeneratedOnAdd();
        builder
            .Property(q => q.Section)
            .HasConversion(
                v => v.ToString().Humanize(LetterCasing.LowerCase),
                v => (QuestionSection)Enum.Parse(typeof(QuestionSection), v.Dehumanize()));
        builder.HasData(LoadQuestion());
    }

    private static IEnumerable<Question> LoadQuestion()
    {
        var ids = new List<Guid>
        {
            new("218408d9-5277-4a87-85b0-49e4d58f562e"),
            new("2345f1b9-68ea-47c0-a07c-308c96bb57f9"),
            new("26a20919-c2a6-4d55-ba27-d1c9e7494803"),
            new("5eaade91-6711-40f4-bc93-865c1f236e9f"),
            new("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"),
            new("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"),
            new("b69bc16e-ae97-471c-80db-6ef12b26638c"),
            new("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"),
            new("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"),
            new("dade9ae9-02b1-410c-9048-da7ed520c459"),
            new("dfddc352-89d5-40dc-a428-1cccd3bb1925"),
            new("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"),
            new("fa5a6ef2-b376-4122-9f1e-591a29e1a2de")
        };
        return new List<Question>
        {
            new(
                ids[0],
                "dosen memberikan kesempatan bertanya di dalam kelas?",
                QuestionSection.KesempatanBertanya,
                "dosen memberikan kesempatan bertanya di dalam kelas"),
            new(
                ids[1],
                "dosen memberikan kesempatan bertanya di luar kelas?",
                QuestionSection.KesempatanBertanya,
                "dosen memberikan kesempatan bertanya di luar kelas"),
            new(
                ids[2],
                "dosen menggunakan forum e-learning?",
                QuestionSection.PenggunaanElearning,
                "dosen memanfaatkan forum yang sudah tersedia"),
            new(
                ids[3],
                "dosen menggunakan kuis e-learning?",
                QuestionSection.PenggunaanElearning,
                "dosen memanfaatkan kuis yang sudah tersedia"),
            new(
                ids[4],
                "dosen menggunakan konferensi video e-learning?",
                QuestionSection.PenggunaanElearning,
                "dosen memanfaatkan konferensi yang sudah tersedia"),
            new(
                ids[5],
                "dosen secara terbuka menyampaikan hasil tugas",
                QuestionSection.TransparansiNilai,
                "dosen memberikan nilai tugas secara terbuka"),
            new(
                ids[6],
                "dosen secara terbuka menyampaikan hasil kuis",
                QuestionSection.TransparansiNilai,
                "dosen memberikan nilai kuis secara terbuka"),
            new(
                ids[7],
                "dosen secara terbuka menyampaikan hasil uts dan uas",
                QuestionSection.TransparansiNilai,
                "dosen memberikan nilai uts dan uas secara terbuka"),
            new(
                ids[8],
                "dosen hadir tepat waktu",
                QuestionSection.KedisiplinanWaktu,
                "dosen hadir tepat waktu (maksimal 15 menit)"),
            new(
                ids[9],
                "perkuliahan dilaksanakan sesuai dengan alokasi waktu",
                QuestionSection.KedisiplinanWaktu,
                "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan"),
            new(
                ids[10],
                "materi yang disampaikan sudah sesuai dengan rpp dan rps?",
                QuestionSection.RencanaKontrakKuliah,
                "menyampaikan materi sesuai dengan kontrak kuliah"
            ),
            new(
                ids[11],
                "tugas yang diberikan sesuai dengan beban studi?",
                QuestionSection.RencanaKontrakKuliah,
                "memberikan tugas sesuai dengan kontrak kuliah"
            ),
            new(
                ids[12],
                "dosen menguasai materi perkuliahan dengan baik?",
                QuestionSection.PenguasaanMateri,
                "mencari referensi terkait materi yang diajarkan"
            )
        };
    }
}