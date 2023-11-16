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
    internal class RatingsConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(new Rating()
            {
                Id = Guid.Parse("496d467e-52de - 43df - 80d0 - a12b8db0c98f"),
                GameId = Guid.Parse("9e220fe5 - 9479 - 48f0 - 8cf4 - 245f134275e9"),
                UserId = Guid.Parse("1c77b562 - e54d - 4944 - 97f7 - 88717b6ac76a"),
                Value =  5
            });
            
            builder.HasData(new Rating()
            {
                Id = Guid.Parse("94e28056 - b094 - 4310 - 86e1 - 9d6bd445af16"),
                GameId = Guid.Parse("2c19be66 - 2d23 - 4f99 - b682 - d763e680471a"),
                UserId = Guid.Parse("361fbf2d - ade9 - 4858 - be97 - a1795b723c62"),
                Value = 10
            });
        }
    }
}
