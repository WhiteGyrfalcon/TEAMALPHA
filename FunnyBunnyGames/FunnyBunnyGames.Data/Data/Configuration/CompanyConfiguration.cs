using FunnyBunnyGames.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunnyBunnyGames.Data.Data.Configuration
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new Company()
            {
                Id = Guid.Parse("a9aee043-77f6-4af3-a04e-9936a8e99c13"),
                Name = "Electronic Arts (EA)"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("f6c1eb6e-db46-412f-a0cd-7f46b1ced8f6"),
                Name = "Ubisoft"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("2bff1b30-4409-49b3-94b5-880e53507b58"),
                Name = "Blizzard Entertainment"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("a6e6acde-caa2-41c1-b640-1b60d3f51118"),
                Name = "Epic Games"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("eaf0ef53-961a-40bb-82a3-a03d9292830a"),
                Name = "Krafton"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("63a14842-f260-4de7-9fab-70ff4d0191c0"),
                Name = "Mojang"
            });
        }
    }
}
