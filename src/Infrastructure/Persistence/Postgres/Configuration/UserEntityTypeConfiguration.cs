using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.Postgres.Configuration;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
       
        var seed = new Seed();
        builder.HasData(seed.Users);
    }

    private static IEnumerable<User> LoadUser()
    {
        var ids = new List<Guid>
        {
            new("ad5d42a5-46fe-4d3e-abf5-7ed374ff0384"),
            new("ed527b4d-f67a-44f6-8b4c-2a87e98a5860"),
            new("ac8a4848-849b-4629-9d31-46a21f6fedb3"),
            new("8f974cea-0cf2-43af-8c42-95a0d35456db"),
            new("1b97868e-088b-4084-9e69-c92cc30fcab0"),
            new("de5babb0-aa23-4215-a8dd-8b4420d3d980"),
            new("b6167351-f41a-4f1e-9861-7055c24eb7c9"),
            new("8102efa1-d6db-4f54-9235-1ab05ba58c31"),
            new("18fbfa4f-ab0a-42c6-9742-450fff8ca001"),
            new("13abe78b-2bfc-46c9-8e87-f40b12b76b33"),
            new("884f1879-013a-4f84-99d1-13b2d2662ffb"),
            new("39760b08-ee07-49ff-8c65-309e5d2ba268"),
            new("a6efb131-9ecf-4600-9a2d-3cee90884269"),
            new("bb1aa2c3-c281-4eca-a750-c4f7a6139e16"),
            new("1e33a9c1-50f2-4632-9dce-526769a60a0c"),
            new("276de2a9-1e41-4099-ac20-f9e5c17bd149"),
            new("363c092f-fa7f-4931-ac7e-3207bea4efda"),
            new("d440902a-c45e-4653-b4fb-7cf4b692162f"),
            new("af60613f-f744-4480-809b-0ce999f5d0b8"),
            new("aa283c29-77a5-4608-a667-9bdb21291b66"),
            new("9207b821-5675-45a9-b622-e49e4bf87c99"),
            new("ed54e40f-9ea9-4d82-b2b1-985b5857784c"),
            new("cb1e523f-e6b7-4d4e-a7c9-742d45a56a8b"),
            new("a53900f5-f682-4ec5-b6a5-b2ba4af81baf"),
            new("af39db4c-58e9-4c6e-a39f-0eb6db7f5750"),
            new("ce7e9cc3-e99f-4f04-a91a-12a5d4d3846d"),
            new("154f4dc9-5515-4ee0-89a9-0e90d2d91c21"),
            new("c0840269-5416-4dd1-a06a-0ce006fb2c80"),
            new("936afc37-fa1d-4240-9e70-01d9c0f69065"),
            new("cf406d43-2ae4-4561-9ac5-9f909bf1fd93"),
            new("0f34418e-d528-4f14-9111-4f68f98419c4"),
            new("ed34e2f5-5c06-45be-a6f7-cf4d4f0ef3f5"),
            new("3a07e04c-3dcc-4ade-ad9c-8d9e72985d29"),
            new("df7be2b4-cd38-4c16-9dda-ce0e80f1de1e"),
            new("f441b144-e8e4-46da-b4a0-0bfa6cf589f7"),
            new("db0f8f67-c3d4-42f6-a1a8-ec1c6023072c"),
            new("cc84debe-429b-4d81-91c7-d5323a58ca75"),
            new("84c40fbe-cbcf-4dbf-b320-973b3810dd84"),
            new("0bdb97f5-01f2-465e-b9dd-05f2cc452039"),
            new("4cec5a0f-6661-45e5-986a-9cf73459a30b"),
            new("c72cadc0-534f-48b5-8408-ad61a7a4d699"),
            new("0049d4db-0964-4b90-abf0-f4cff5671e1c"),
            new("6e1df772-6ced-4fab-9d46-d7d56ef53423"),
            new("21220f88-4e99-40b9-b760-bac947c1d533"),
            new("da958747-27b3-4c74-9b51-d9bf02bd1daf"),
            new("33252e07-6839-4a3a-b7b4-1e714acdfd6b"),
            new("2201eca3-3e47-4602-a69d-3ff190220a11"),
            new("dbf70050-2aea-4ed3-9612-f28b2ba08794"),
            new("bfd3cbeb-1eda-4f8e-a527-04ed02c11d51"),
            new("feba9972-6c35-430c-8517-42180ab7ee11"),
            new("8ba3f879-eafa-4f6a-ba25-ad878a60b86e"),
            new("e04aad0c-c9e2-4662-a8a1-9c3fce95c614"),
            new("38e352d0-b329-4c9f-95d5-8656e7ff8f0a"),
            new("606781c6-25dd-4975-9a63-54bf4bcc2818"),
            new("29892c96-9b2c-4b8f-b32a-d26ddae7fd07"),
            new("41d89f72-32c6-4299-b14c-b253d542f6de"),
            new("36e8a4d9-7f8a-43df-ac8d-912a0752efc3"),
            new("41f6966a-027c-4c22-b4bc-40c1e7406cea"),
            new("911d9744-3ed6-4eb0-af8a-ec560cdcbbf4"),
            new("a37acf8c-e618-4ea3-a044-feda75c65944"),
            new("971a17a3-23ba-47be-b37a-2034b9b49fff"),
            new("dfdb31f4-7587-46f9-8e1f-57431762d4f5"),
            new("05f8e747-d896-4269-8ef9-f3fdc480021f"),
            new("05639904-7085-49c7-a3ca-493e5b42839d"),
            new("94a215ae-61e8-41c1-b2d1-5839bf1b6a93"),
            new("4dd1b633-0355-4b72-937a-1f9a1ae021c4"),
            new("3e33cd3f-4177-4b8f-92ef-d787a0f530cb"),
            new("327335b4-0d54-47fa-b68d-8e87b2712178"),
            new("b9c469e9-df21-466c-aa88-5fd245fc05ba"),
            new("51d03b5e-279f-4d88-b71d-906e4258e666"),
            new("ea902940-5195-41a0-a1ad-0941995cbec7"),
            new("8a9c7d3a-5147-41ed-ac9e-e6598c18d8f5"),
            new("2571a39a-a61d-473b-831d-d52a561478d5"),
            new("ef446cec-a7e7-4525-9c9a-2ef0c26d83b8"),
            new("13d76db1-db42-48ef-bfb4-76129b6361f4"),
            new("a3a33758-4a08-4c0e-b59a-4e824253220c"),
            new("e7985714-755c-4d38-8d92-ff0ad8dfc4e4"),
            new("39705426-052d-46df-b41a-09284d9ccc0f"),
            new("fd846717-9517-401a-875e-6fa2222e4f4e"),
            new("037776a2-7bdc-4fb5-909c-078fc80f3bb8"),
            new("2a35d644-24bc-47c5-b987-a476d19955e1"),
            new("55540b3d-46cc-4607-89dc-31a4a84627e0"),
            new("27769ec3-086a-4afc-b28b-de6f17b6fe81"),
            new("ba61e808-6b39-4c17-a474-986d31a93966"),
            new("0754b36c-207e-4abb-963d-57377bbc66bc"),
            new("dba210a3-e1d7-4abd-bbc4-39c886b2952d"),
            new("20771736-5d04-47f4-85cd-7a87d0199f9a"),
            new("ca088dae-37f1-4d03-8c0b-014fd3ef3f94"),
            new("8792f652-8e05-41c3-82d4-849f3ecb9612"),
            new("ae57d45c-7190-4ec6-a411-6b7b9bd4787f"),
            new("187bed34-5b01-469b-9e30-a825d3bc8fb7"),
            new("f078a71b-e21a-44c2-b625-76ff71456c54"),
            new("956be3b8-1fa6-4a37-bbfe-71d0a7ba2c47"),
            new("d3074717-b9ac-45fe-8344-4ea901699cbc"),
            new("a3c9cc07-8c30-4402-b509-b76eee079026"),
            new("7043a62d-9858-4060-b314-e051b08f57b3"),
            new("a17c23ac-a0cd-49b2-9b6c-5e2502c09d2e"),
        };

        Randomizer.Seed = new Random(10000);
        var testUser = new Faker<User>("id_ID")
            .RuleFor(u => u.Name, f => f.Name.FirstName())
            .RuleFor(u => u.Email, (f, u) => $"{u.Name.ToLower()}@usu.ac.id")
            .RuleFor(u => u.Password, (f, u) => $"{u.Name.ToLower()}123");
        var user = testUser.Generate(97);
        user = user.Take(ids.Count)
            .Select(
                (u, i) =>
                {
                    u.Id = ids[i];
                    return u;
                })
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
}