using FunnyBunnyGames.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FunnyBunnyGames.Data.Data.Configuration
{
    internal class GamesConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(new Game()
            {
                Id = Guid.Parse("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                GenreId = Guid.Parse("8492ee79-bc81-4c92-ab76-cf3b25a20388"),
                CompanyId = Guid.Parse("a6e6acde-caa2-41c1-b640-1b60d3f51118"),
                Name = "Fortnite",
                Description = "Fortnite is a highly popular battle royale game developed by Epic Games. Players are dropped onto an island and must compete against each other to be the last one standing. They can gather resources, build structures, and find weapons to aid them in the battle. What sets Fortnite apart is its colorful, cartoony art style and the ability to build structures, which adds a unique strategic element to the gameplay.Additionally, Fortnite often features limited-time events, skins, and challenges to keep the game fresh and engaging.",
                ReleaseDate = DateTime.ParseExact("25.07.2017", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Price = 0,
                AgeRestriction = 13,
                ImageUrl = "https://cdn2.unrealengine.com/social-image-chapter4-s3-3840x2160-d35912cc25ad.jpg"
            });

            builder.HasData(new Game()
            {
                Id = Guid.Parse("c540276d-4b42-403a-938b-5ecb400399d8"),
                GenreId = Guid.Parse("991fc42b-945b-4fd8-a7ea-58bb04364f9b"),
                CompanyId = Guid.Parse("eaf0ef53-961a-40bb-82a3-a03d9292830a"),
                Name = "PlayerUnknown's Battlegrounds (PUBG)",
                Description = "PUBG is a battle royale game developed by PUBG Corporation. In this game, up to 100 players are parachuted onto an island where they must scavenge for weapons and supplies and fight to be the last person or team standing.PUBG is known for its realistic graphics and intense gameplay, where strategy and survival skills are crucial for success.It was one of the pioneering titles in the battle royale genre.",
                ReleaseDate = DateTime.ParseExact("23.03.2017", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Price = 0,
                AgeRestriction = 13,
                ImageUrl = "https://wstatic-prod.pubg.com/web/live/static/og/img-og-pubg.jpg"
            });

            builder.HasData(new Game()
            {
                Id = Guid.Parse("2c19be66-2d23-4f99-b682-d763e680471a"),
                GenreId = Guid.Parse("3d7c3588-7513-4e9d-8bac-63fe696b1e0e"),
                CompanyId = Guid.Parse("63a14842-f260-4de7-9fab-70ff4d0191c0"),
                Name = "Minecraft",
                Description = "Minecraft, developed by Mojang Studios, is a sandbox game that allows players to explore and create their own blocky, procedurally generated worlds.Players can gather resources, build structures, mine for materials, and engage in various activities like farming, crafting, and fighting off monsters.Minecraft's open-world, creative nature has made it a beloved game for players of all ages, and it offers both survival and creative modes to cater to different playstyles.",
                ReleaseDate = DateTime.ParseExact("18.11.2011", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Price = 29.99,
                AgeRestriction = 0,
                ImageUrl = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/minecraft/c/c7/Trails_And_Tales_Header.jpg"
            });
            
            builder.HasData(new Game()
            {
                Id = Guid.Parse("f6aebf87-a0d3-467d-a590-3a98d2fe0113"),
                GenreId = Guid.Parse("9642dcb4-910d-4dc9-b04d-c3ab81d3f71a"),
                CompanyId = Guid.Parse("f6c1eb6e-db46-412f-a0cd-7f46b1ced8f6"),
                Name = "Assassin's Creed: Origins",
                Description = "Assassin's Creed Origins is an action role-playing video game played from a third-person perspective. Players complete quests—linear scenarios with set objectives—to progress through the story, and can freely roam the open world environment on foot, horseback, camel-back, horse-drawn vehicles or boat.",
                ReleaseDate = DateTime.ParseExact("27.10.2017", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Price = 59.99,
                AgeRestriction = 18,
                ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202010/0220/mEgt1tDiuDgwqMPCLIzM1gBD.jpg"
            });
            
            builder.HasData(new Game()
            {
                Id = Guid.Parse("d2e76809-dd75-4f8a-b523-05698e5ce3c1"),
                GenreId = Guid.Parse("68e1037c-d133-4d74-84f6-295620c09911"),
                CompanyId = Guid.Parse("2bff1b30-4409-49b3-94b5-880e53507b58"),
                Name = "Overwatch 2",
                Description = "Overwatch 2 is a critically acclaimed, team-based shooter game set in an optimistic future with an evolving roster of heroes. Team up with friends and jump in today.",
                ReleaseDate = DateTime.ParseExact("04.10.2022", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Price = 0,
                AgeRestriction = 12,
                ImageUrl = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_Overwatch2_Season6.png"
			});
            
            builder.HasData(new Game()
            {
                Id = Guid.Parse("1e5e6c2f-19ff-4b46-a905-5a45a9d30446"),
                GenreId = Guid.Parse("6ce42134-096b-46ea-a618-45b8a2bd29b3"),
                CompanyId = Guid.Parse("a9aee043-77f6-4af3-a04e-9936a8e99c13"),
                Name = "Need For Speed: Heat",
                Description = "Hustle by day and risk it all at night in Need for Speed™ Heat Deluxe Edition, a white-knuckle street racer, where the lines of the law fade as the sun starts to set.",
                ReleaseDate = DateTime.ParseExact("16.10.2019", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                Price = 69.99,
                AgeRestriction = 14,
                ImageUrl = "https://gaming-cdn.com/images/products/5362/orig/need-for-speed-heat-pc-game-origin-cover.jpg?v=1649062628"
			});
        }
    }
}
