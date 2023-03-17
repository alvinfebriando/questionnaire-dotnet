using Microsoft.EntityFrameworkCore;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class ApplicationDbContext : DbContext
{
    public virtual DbSet<Question> Questions { get; set; }
    public virtual DbSet<Answer> Answers { get; set; }
    public virtual DbSet<Survey> Surveys { get; set; }
    public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>()
            .HasOne<Question>(a => a.Question)
            .WithMany();

        modelBuilder.Entity<SurveyQuestion>()
            .HasKey(sq => new { sq.SurveyId, sq.QuestionId });

        modelBuilder.Entity<SurveyQuestion>()
            .HasOne<Survey>(sq => sq.Survey)
            .WithMany(s => s.SurveyQuestions)
            .HasForeignKey(sq => sq.SurveyId);

        modelBuilder.Entity<SurveyQuestion>()
            .HasOne<Question>(sq => sq.Question)
            .WithMany(q => q.SurveyQuestions)
            .HasForeignKey(sq => sq.QuestionId);

        modelBuilder.Entity<Answer>().HasKey(a => a.Id);
        modelBuilder.Entity<Question>().HasKey(q => q.Id);
        modelBuilder.Entity<Survey>().HasKey(s=>s.Id);

        modelBuilder.Entity<Question>().HasData(LoadQuestion());
    }

    private static IEnumerable<Question> LoadQuestion()
    {
        return new List<Question>
        {
            new(
                Guid.NewGuid(),
                "dosen memberikan kesempatan bertanya di dalam kelas?",
                QuestionSection.KesempatanBertanya,
                "dosen memberikan kesempatan bertanya di dalam kelas"),
            new(
                Guid.NewGuid(),
                "dosen memberikan kesempatan bertanya di luar kelas?",
                QuestionSection.KesempatanBertanya,
                "dosen memberikan kesempatan bertanya di luar kelas"),
            new(
                Guid.NewGuid(),
                "dosen menggunakan forum e-learning?",
                QuestionSection.PenggunaanElearning,
                "dosen memanfaatkan forum yang sudah tersedia"),
            new(
                Guid.NewGuid(),
                "dosen menggunakan kuis e-learning?",
                QuestionSection.PenggunaanElearning,
                "dosen memanfaatkan kuis yang sudah tersedia"),
            new(
                Guid.NewGuid(),
                "dosen menggunakan konferensi video e-learning?",
                QuestionSection.PenggunaanElearning,
                "dosen memanfaatkan konferensi yang sudah tersedia"),
            new(
                Guid.NewGuid(),
                "dosen secara terbuka menyampaikan hasil tugas",
                QuestionSection.TransparansiNilai,
                "dosen memberikan nilai tugas secara terbuka"),
            new(
                Guid.NewGuid(),
                "dosen secara terbuka menyampaikan hasil kuis",
                QuestionSection.TransparansiNilai,
                "dosen memberikan nilai kuis secara terbuka"),
            new(
                Guid.NewGuid(),
                "dosen secara terbuka menyampaikan hasil uts dan uas",
                QuestionSection.TransparansiNilai,
                "dosen memberikan nilai uts dan uas secara terbuka"),
            new(
                Guid.NewGuid(),
                "dosen hadir tepat waktu",
                QuestionSection.KedisiplinanWaktu,
                "dosen hadir tepat waktu (maksimal 15 menit)"),
            new(
                Guid.NewGuid(),
                "perkuliahan dilaksanakan sesuai dengan alokasi waktu",
                QuestionSection.KedisiplinanWaktu,
                "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan"),
            new(
                Guid.NewGuid(),
                "materi yang disampaikan sudah sesuai dengan rpp dan rps?",
                QuestionSection.RencanaKontrakKuliah,
                "menyampaikan materi sesuai dengan kontrak kuliah"
            ),
            new(
                Guid.NewGuid(),
                "tugas yang diberikan sesuai dengan beban studi?",
                QuestionSection.RencanaKontrakKuliah,
                "memberikan tugas sesuai dengan kontrak kuliah"
            ),
            new(
                Guid.NewGuid(),
                "dosen menguasai materi perkuliahan dengan baik?",
                QuestionSection.PenguasaanMateri,
                "mencari referensi terkait materi yang diajarkan"
            )
        };
    }
}