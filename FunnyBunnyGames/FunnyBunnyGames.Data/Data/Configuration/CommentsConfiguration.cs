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
    internal class CommentsConfiguration : IEntityTypeConfiguration<Comment>
    {       
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(new Comment()
            {
                Id = Guid.Parse("75edf8f8-0b58-4f59-82fb-438691643e1d"),
                UserId = Guid.Parse("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                GameId = Guid.Parse("c540276d-4b42-403a-938b-5ecb400399d8"),
                Value = "PUBG's realism and intensity make it a standout battle royale game. Heart-pounding firefights and strategic gameplay keep me coming back."
            });            

            builder.HasData(new Comment()
            {
                Id = Guid.Parse("e35bafc5-0fc6-4b14-84c3-1b329fea90f2"),
                UserId = Guid.Parse("361fbf2d-ade9-4858-be97-a1795b723c62"),
                GameId = Guid.Parse("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                Value = "Fortnite is a fast-paced battle royale game with a unique twist - the ability to build structures on the fly. It's a ton of fun!"

            });
     
            builder.HasData(new Comment()
            {
                Id = Guid.Parse("2985d531-f2f5-4e07-b5c4-557c28e51e59"),
                UserId = Guid.Parse("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                GameId = Guid.Parse("2c19be66-2d23-4f99-b682-d763e680471a"),
                Value = "Minecraft is a digital sandbox where your imagination is the only limit. Building, exploring, and surviving in this blocky world is endlessly enjoyable."

            });      
        }
    }
}
