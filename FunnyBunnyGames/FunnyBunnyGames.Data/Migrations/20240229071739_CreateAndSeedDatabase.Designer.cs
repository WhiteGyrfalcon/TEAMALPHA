﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.FunnyBunnyGames.Data;

#nullable disable

namespace FunnyBunnyGames.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240229071739_CreateAndSeedDatabase")]
    partial class CreateAndSeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75edf8f8-0b58-4f59-82fb-438691643e1d"),
                            GameId = new Guid("c540276d-4b42-403a-938b-5ecb400399d8"),
                            UserId = new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                            Value = "PUBG's realism and intensity make it a standout battle royale game. Heart-pounding firefights and strategic gameplay keep me coming back."
                        },
                        new
                        {
                            Id = new Guid("e35bafc5-0fc6-4b14-84c3-1b329fea90f2"),
                            GameId = new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                            UserId = new Guid("361fbf2d-ade9-4858-be97-a1795b723c62"),
                            Value = "Fortnite is a fast-paced battle royale game with a unique twist - the ability to build structures on the fly. It's a ton of fun!"
                        },
                        new
                        {
                            Id = new Guid("2985d531-f2f5-4e07-b5c4-557c28e51e59"),
                            GameId = new Guid("2c19be66-2d23-4f99-b682-d763e680471a"),
                            UserId = new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                            Value = "Minecraft is a digital sandbox where your imagination is the only limit. Building, exploring, and surviving in this blocky world is endlessly enjoyable."
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a9aee043-77f6-4af3-a04e-9936a8e99c13"),
                            Name = "Electronic Arts (EA)"
                        },
                        new
                        {
                            Id = new Guid("f6c1eb6e-db46-412f-a0cd-7f46b1ced8f6"),
                            Name = "Ubisoft"
                        },
                        new
                        {
                            Id = new Guid("2bff1b30-4409-49b3-94b5-880e53507b58"),
                            Name = "Blizzard Entertainment"
                        },
                        new
                        {
                            Id = new Guid("a6e6acde-caa2-41c1-b640-1b60d3f51118"),
                            Name = "Epic Games"
                        },
                        new
                        {
                            Id = new Guid("eaf0ef53-961a-40bb-82a3-a03d9292830a"),
                            Name = "Krafton"
                        },
                        new
                        {
                            Id = new Guid("63a14842-f260-4de7-9fab-70ff4d0191c0"),
                            Name = "Mojang"
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Favourite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Favourites");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7edafdd2-7435-4a6f-8fe1-c2d63a994e17"),
                            GameId = new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                            UserId = new Guid("361fbf2d-ade9-4858-be97-a1795b723c62")
                        },
                        new
                        {
                            Id = new Guid("8f0dac20-cc50-42c0-8244-66c700f80764"),
                            GameId = new Guid("2c19be66-2d23-4f99-b682-d763e680471a"),
                            UserId = new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a")
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                            AgeRestriction = 13,
                            CompanyId = new Guid("a6e6acde-caa2-41c1-b640-1b60d3f51118"),
                            Description = "Fortnite is a highly popular battle royale game developed by Epic Games. Players are dropped onto an island and must compete against each other to be the last one standing. They can gather resources, build structures, and find weapons to aid them in the battle. What sets Fortnite apart is its colorful, cartoony art style and the ability to build structures, which adds a unique strategic element to the gameplay.Additionally, Fortnite often features limited-time events, skins, and challenges to keep the game fresh and engaging.",
                            GenreId = new Guid("8492ee79-bc81-4c92-ab76-cf3b25a20388"),
                            ImageUrl = "https://cdn2.unrealengine.com/social-image-chapter4-s3-3840x2160-d35912cc25ad.jpg",
                            Name = "Fortnite",
                            Price = 0.0,
                            ReleaseDate = new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c540276d-4b42-403a-938b-5ecb400399d8"),
                            AgeRestriction = 13,
                            CompanyId = new Guid("eaf0ef53-961a-40bb-82a3-a03d9292830a"),
                            Description = "PUBG is a battle royale game developed by PUBG Corporation. In this game, up to 100 players are parachuted onto an island where they must scavenge for weapons and supplies and fight to be the last person or team standing.PUBG is known for its realistic graphics and intense gameplay, where strategy and survival skills are crucial for success.It was one of the pioneering titles in the battle royale genre.",
                            GenreId = new Guid("991fc42b-945b-4fd8-a7ea-58bb04364f9b"),
                            ImageUrl = "https://wstatic-prod.pubg.com/web/live/static/og/img-og-pubg.jpg",
                            Name = "PlayerUnknown's Battlegrounds (PUBG)",
                            Price = 0.0,
                            ReleaseDate = new DateTime(2017, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("2c19be66-2d23-4f99-b682-d763e680471a"),
                            AgeRestriction = 0,
                            CompanyId = new Guid("63a14842-f260-4de7-9fab-70ff4d0191c0"),
                            Description = "Minecraft, developed by Mojang Studios, is a sandbox game that allows players to explore and create their own blocky, procedurally generated worlds.Players can gather resources, build structures, mine for materials, and engage in various activities like farming, crafting, and fighting off monsters.Minecraft's open-world, creative nature has made it a beloved game for players of all ages, and it offers both survival and creative modes to cater to different playstyles.",
                            GenreId = new Guid("3d7c3588-7513-4e9d-8bac-63fe696b1e0e"),
                            ImageUrl = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/minecraft/c/c7/Trails_And_Tales_Header.jpg",
                            Name = "Minecraft",
                            Price = 29.989999999999998,
                            ReleaseDate = new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f6aebf87-a0d3-467d-a590-3a98d2fe0113"),
                            AgeRestriction = 18,
                            CompanyId = new Guid("f6c1eb6e-db46-412f-a0cd-7f46b1ced8f6"),
                            Description = "Assassin's Creed Origins is an action role-playing video game played from a third-person perspective. Players complete quests—linear scenarios with set objectives—to progress through the story, and can freely roam the open world environment on foot, horseback, camel-back, horse-drawn vehicles or boat.",
                            GenreId = new Guid("9642dcb4-910d-4dc9-b04d-c3ab81d3f71a"),
                            ImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202010/0220/mEgt1tDiuDgwqMPCLIzM1gBD.jpg",
                            Name = "Assassin's Creed: Origins",
                            Price = 59.990000000000002,
                            ReleaseDate = new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d2e76809-dd75-4f8a-b523-05698e5ce3c1"),
                            AgeRestriction = 12,
                            CompanyId = new Guid("2bff1b30-4409-49b3-94b5-880e53507b58"),
                            Description = "Overwatch 2 is a critically acclaimed, team-based shooter game set in an optimistic future with an evolving roster of heroes. Team up with friends and jump in today.",
                            GenreId = new Guid("68e1037c-d133-4d74-84f6-295620c09911"),
                            ImageUrl = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_Overwatch2_Season6.png",
                            Name = "Overwatch 2",
                            Price = 0.0,
                            ReleaseDate = new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1e5e6c2f-19ff-4b46-a905-5a45a9d30446"),
                            AgeRestriction = 14,
                            CompanyId = new Guid("a9aee043-77f6-4af3-a04e-9936a8e99c13"),
                            Description = "Hustle by day and risk it all at night in Need for Speed™ Heat Deluxe Edition, a white-knuckle street racer, where the lines of the law fade as the sun starts to set.",
                            GenreId = new Guid("6ce42134-096b-46ea-a618-45b8a2bd29b3"),
                            ImageUrl = "https://gaming-cdn.com/images/products/5362/orig/need-for-speed-heat-pc-game-origin-cover.jpg?v=1649062628",
                            Name = "Need For Speed: Heat",
                            Price = 69.989999999999995,
                            ReleaseDate = new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8492ee79-bc81-4c92-ab76-cf3b25a20388"),
                            Name = "Battle Royale / Third-Person Shooter / Building"
                        },
                        new
                        {
                            Id = new Guid("991fc42b-945b-4fd8-a7ea-58bb04364f9b"),
                            Name = "Battle Royale / Third-Person Shooter / First-Person Shooter"
                        },
                        new
                        {
                            Id = new Guid("3d7c3588-7513-4e9d-8bac-63fe696b1e0e"),
                            Name = "Sandbox / Survival / Adventure"
                        },
                        new
                        {
                            Id = new Guid("9642dcb4-910d-4dc9-b04d-c3ab81d3f71a"),
                            Name = "RPG / Stealth / Action-adventure"
                        },
                        new
                        {
                            Id = new Guid("68e1037c-d133-4d74-84f6-295620c09911"),
                            Name = "First-Person Shooter"
                        },
                        new
                        {
                            Id = new Guid("6ce42134-096b-46ea-a618-45b8a2bd29b3"),
                            Name = "Racing / Action-adventure"
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("496d467e-52de-43df-80d0-a12b8db0c98f"),
                            GameId = new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"),
                            UserId = new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                            Value = 5.0
                        },
                        new
                        {
                            Id = new Guid("94e28056-b094-4310-86e1-9d6bd445af16"),
                            GameId = new Guid("2c19be66-2d23-4f99-b682-d763e680471a"),
                            UserId = new Guid("361fbf2d-ade9-4858-be97-a1795b723c62"),
                            Value = 10.0
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c35c18b-3177-4ad1-8be7-141693a7272f"),
                            ConcurrencyStamp = "68be544a-11c3-493d-b40f-d6fa9b362c52",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("b61a261f-5220-4176-9d49-ff18ecbd5b18"),
                            ConcurrencyStamp = "3a197fb9-6842-4b1a-ada3-89c75a45eaba",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("361fbf2d-ade9-4858-be97-a1795b723c62"),
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "4ccb39ff-5d90-4a0a-8570-8c6e210dfe3e",
                            Email = "stelafox@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Stela",
                            LastName = "Fox",
                            LockoutEnabled = false,
                            PhoneNumber = "089 111 1111",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "StelaFox"
                        },
                        new
                        {
                            Id = new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"),
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "b1496731-dbd0-419c-84c5-41aa110173d7",
                            Email = "johnsmith@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            PhoneNumber = "089 222 2222",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "JoshnSmith"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Comment", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.Game", "Game")
                        .WithMany("Comments")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunnyBunnyGames.Data.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Favourite", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.Game", "Game")
                        .WithMany("Favourites")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunnyBunnyGames.Data.Models.User", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Game", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.Company", "Company")
                        .WithMany("Games")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunnyBunnyGames.Data.Models.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Rating", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.Game", "Game")
                        .WithMany("Ratings")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunnyBunnyGames.Data.Models.User", "User")
                        .WithMany("Rating")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FunnyBunnyGames.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FunnyBunnyGames.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Company", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Game", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favourites");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("FunnyBunnyGames.Data.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favourites");

                    b.Navigation("Rating");
                });
#pragma warning restore 612, 618
        }
    }
}
