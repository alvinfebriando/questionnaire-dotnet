﻿using System.Collections;
using Bogus;
using Bogus.DataSets;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Infrastructure;

public class Seed
{
    public IEnumerable<User> Users { get; set; }
    public IEnumerable<Question> Questions { get; set; }
    public IEnumerable<Lecturer> Lecturers { get; set; }

    public Seed()
    {
        Users = GenerateUsers(97);
        Questions = GenerateQuestions();
        Lecturers = GenerateLecturers(30);
    }

    private static T SeedRow<T>(Faker<T> faker, int rowId) where T : class
    {
        var recordRow = faker.UseSeed(rowId*132).Generate();
        return recordRow;
    }

    public IEnumerable<User> GenerateUsers(int amount)
    {
        var testUser = new Faker<User>("id_ID")
            .RuleFor(u => u.Id, f => f.Random.Guid())
            .RuleFor(u => u.Name, f => f.Name.FirstName())
            .RuleFor(u => u.Email, (f, u) => $"{u.Name.ToLower()}@usu.ac.id")
            .RuleFor(u => u.Password, (f, u) => $"{u.Name.ToLower()}123");
        var user = Enumerable.Range(1, amount)
            .Select(i => SeedRow(testUser, i))
            .ToList();
        user.AddRange(
            new List<User>
            {
                new()
                {
                    Id = new Guid("41CDC211-9AD2-44DF-9AD0-122014CD918B"),
                    Name = "Admin",
                    Email = "admin@usu.ac.id",
                    Password = "admin123"
                },
                new()
                {
                    Id = new Guid("107E9536-5FD4-4B44-891E-9E77EB5CA9AB"),
                    Name = "Alvin",
                    Email = "alvin@usu.ac.id",
                    Password = "alvin123"
                },
                new()
                {
                    Id = new Guid("6E8173DB-65AA-4B55-B030-EEE00927CD39"),
                    Name = "Febriando",
                    Email = "febriando@usu.ac.id",
                    Password = "febriando123"
                }
            });
        return user;
    }

    public IEnumerable<Question> GenerateQuestions()
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
                "Apakah dosen memberikan kesempatan bertanya di dalam kelas?",
                QuestionSection.KesempatanBertanya,
                "memberikan kesempatan bertanya di dalam kelas"),
            new(
                ids[1],
                "Apakah dosen memberikan kesempatan bertanya di luar kelas?",
                QuestionSection.KesempatanBertanya,
                "memberikan kesempatan bertanya di luar kelas"),
            new(
                ids[2],
                "Apakah dosen menggunakan fitur forum e-learning?",
                QuestionSection.PenggunaanElearning,
                "memanfaatkan fitur forum yang sudah tersedia"),
            new(
                ids[3],
                "Apakah dosen menggunakan fitur kuis e-learning?",
                QuestionSection.PenggunaanElearning,
                "memanfaatkan fitur kuis yang sudah tersedia"),
            new(
                ids[4],
                "Apakah dosen menggunakan fitur konferensi video e-learning?",
                QuestionSection.PenggunaanElearning,
                "memanfaatkan fitur konferensi video yang sudah tersedia"),
            new(
                ids[5],
                "Apakah dosen secara terbuka menyampaikan hasil tugas",
                QuestionSection.TransparansiNilai,
                "memberikan nilai tugas secara terbuka"),
            new(
                ids[6],
                "Apakah dosen secara terbuka menyampaikan hasil kuis",
                QuestionSection.TransparansiNilai,
                "memberikan nilai kuis secara terbuka"),
            new(
                ids[7],
                "Apakah dosen secara terbuka menyampaikan hasil uts dan uas",
                QuestionSection.TransparansiNilai,
                "memberikan nilai uts dan uas secara terbuka"),
            new(
                ids[8],
                "Apakah dosen hadir tepat waktu",
                QuestionSection.KedisiplinanWaktu,
                "hadir tepat waktu (maksimal 15 menit keterlambatan)"),
            new(
                ids[9],
                "Apakah perkuliahan dilaksanakan sesuai dengan alokasi waktu",
                QuestionSection.KedisiplinanWaktu,
                "memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan"),
            new(
                ids[10],
                "Apakah materi yang disampaikan sudah sesuai dengan rpp dan rps?",
                QuestionSection.RencanaKontrakKuliah,
                "menyampaikan materi sesuai dengan kontrak kuliah"
            ),
            new(
                ids[11],
                "Apakah tugas yang diberikan sesuai dengan beban studi?",
                QuestionSection.RencanaKontrakKuliah,
                "memberikan tugas sesuai dengan kontrak kuliah"
            ),
            new(
                ids[12],
                "Apakah dosen menguasai materi perkuliahan dengan baik?",
                QuestionSection.PenguasaanMateri,
                "mencari referensi terkait materi yang diajarkan"
            )
        };
    }

    public IEnumerable<Lecturer> GenerateLecturers(int amount)
    {
        var ids = new List<Guid>
        {
            new("e97e4f1e-d72e-43ad-92a0-2cbd28296bcf"),
            new("64805099-6e8a-4269-82a4-59642ec8a610"),
            new("fa1b6693-4f1c-4cd5-98c2-024d6fa6be19"),
            new("ae0e8488-4119-487b-b56d-69f680e49655"),
            new("0f27a418-23f4-40d9-8bcb-58a98be78aee"),
            new("93fad230-28a8-438d-a8af-d0137d078382"),
            new("5c7dfd25-206b-4f80-9876-15ad64a6afb6"),
            new("866596ec-8f55-4c67-9f9d-e71dcf7cae6b"),
            new("57012468-2fee-45c7-997c-fe184d630541"),
            new("3a42af84-9f31-4d8a-a0f0-b9ee2f563639"),
            new("7a244266-19a5-4527-8041-a4cb40d99d95"),
            new("2c13893e-29a2-4d5b-ba50-f8e12a78607e"),
            new("47ddf172-2abb-4e77-83ca-0b52ab5a4bed"),
            new("bf1b32fd-3d22-4f17-8e5b-5faf55d6d427"),
            new("86b7c189-370d-4018-8e62-0752c0e47f32"),
            new("a38a4944-8fbd-4e08-9f4c-4f1478acea01"),
            new("f05e1bf1-768c-4719-8a78-b68ba477d010"),
            new("f739066d-bf4f-470f-8c3e-08af9a88bafb"),
            new("30ba4537-ba0b-4187-97f4-1b711cb4b58d"),
            new("a100dea5-b5ec-431e-b2b4-127bc58e19c1"),
            new("4544202d-7d25-4b83-96eb-bcacd858c0cd"),
            new("00416243-854e-464d-a79d-d6044618664e"),
            new("57ab1244-8484-4b48-9ccf-ccb0ffb21166"),
            new("9e11454f-0e68-4473-b2f6-9ceeb57d9de0"),
            new("dead4043-8e12-4dad-b8c1-b03c7af2ef10"),
            new("7fbba595-86f8-413b-9afd-03f2fe1970e4"),
            new("3c16908e-ace6-430d-b360-d63c2032dbcc"),
            new("bd160a9b-3e8d-4530-85ee-53cbc721be00"),
            new("2415fe09-a849-4cf7-b5dd-63e0d2613307"),
            new("a18dcd39-1de8-4b93-a237-8936c3f1f0a0")
        };

        var testLecturer = new Faker<Lecturer>("id_ID")
            .RuleFor(l => l.Title, f => f.PickRandom<LecturerTitle>())
            .RuleFor(
                l => l.Name,
                (f, l) => f.Name.FirstName(
                    l.Title == LecturerTitle.Pak
                        ? Name.Gender.Male
                        : Name.Gender.Female));
        var lecturers = Enumerable.Range(1, amount)
            .Select(i => SeedRow(testLecturer, i))
            .ToList();
        lecturers = lecturers.Take(ids.Count)
            .Select(
                (l, i) =>
                {
                    l.Id = ids[i];
                    return l;
                })
            .ToList();
        return lecturers;
    }
}