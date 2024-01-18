using FunnyBunnyGames.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunnyBunnyGames.Data.Data.Configuration
{
    internal class GenresConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(new Company()
            {
                Id = Guid.Parse("8492ee79-bc81-4c92-ab76-cf3b25a20388"),
                Name = "Battle Royale / Third-Person Shooter / Building"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("991fc42b-945b-4fd8-a7ea-58bb04364f9b"),
                Name = "Battle Royale / Third-Person Shooter / First-Person Shooter"
            });

            builder.HasData(new Company()
            {
                Id = Guid.Parse("3d7c3588-7513-4e9d-8bac-63fe696b1e0e"),
                Name = "Sandbox / Survival / Adventure"
            }); 
            
            builder.HasData(new Company()
            {
                Id = Guid.Parse("9642dcb4-910d-4dc9-b04d-c3ab81d3f71a"),
                Name = "RPG / Stealth / Action-adventure"
            });
            
            builder.HasData(new Company()
            {
                Id = Guid.Parse("68e1037c-d133-4d74-84f6-295620c09911"),
                Name = "First-Person Shooter"
            });
            
            builder.HasData(new Company()
            {
                Id = Guid.Parse("6ce42134-096b-46ea-a618-45b8a2bd29b3"),
                Name = "Racing / Action-adventure"
            });
        }
    }
}
