using FunnyBunnyGames.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyBunnyGames.Data.Data.Configuration
{
    internal class FavouritesConfiguration : IEntityTypeConfiguration<Favourite>
    {
        public void Configure(EntityTypeBuilder<Favourite> builder)
        {
            builder.HasData(new Favourite()
            {
                Id = Guid.Parse("7edafdd2-7435-4a6f-8fe1-c2d63a994e17"),
                GameId = Guid.Parse("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                UserId = Guid.Parse("361fbf2d-ade9-4858-be97-a1795b723c62")
            });
       
            builder.HasData(new Favourite()
            {
                Id = Guid.Parse("8f0dac20-cc50-42c0-8244-66c700f80764"),
                GameId = Guid.Parse("2c19be66-2d23-4f99-b682-d763e680471a"),
                UserId = Guid.Parse("1c77b562-e54d-4944-97f7-88717b6ac76a")
            });      
        }
    }
}
