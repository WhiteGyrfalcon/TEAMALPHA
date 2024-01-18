using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunnyBunnyGames.Data.Migrations
{
    public partial class CreateAndSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    AgeRestriction = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourites_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("7c35c18b-3177-4ad1-8be7-141693a7272f"), "68be544a-11c3-493d-b40f-d6fa9b362c52", "Administrator", "ADMINISTRATOR" },
                    { new Guid("b61a261f-5220-4176-9d49-ff18ecbd5b18"), "3a197fb9-6842-4b1a-ada3-89c75a45eaba", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"), 0, 18, "09737cf2-66dc-4731-9258-02c6adca4d4d", "johnsmith@gmail.com", false, "John", "Smith", false, null, null, null, null, "089 222 2222", false, null, false, "JoshnSmith" },
                    { new Guid("361fbf2d-ade9-4858-be97-a1795b723c62"), 0, 20, "fa81684e-f315-4f83-adf1-b2f53a993c72", "stelafox@gmail.com", false, "Stela", "Fox", false, null, null, null, null, "089 111 1111", false, null, false, "StelaFox" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2bff1b30-4409-49b3-94b5-880e53507b58"), "Blizzard Entertainment" },
                    { new Guid("63a14842-f260-4de7-9fab-70ff4d0191c0"), "Mojang" },
                    { new Guid("a6e6acde-caa2-41c1-b640-1b60d3f51118"), "Epic Games" },
                    { new Guid("a9aee043-77f6-4af3-a04e-9936a8e99c13"), "Electronic Arts (EA)" },
                    { new Guid("eaf0ef53-961a-40bb-82a3-a03d9292830a"), "Krafton" },
                    { new Guid("f6c1eb6e-db46-412f-a0cd-7f46b1ced8f6"), "Ubisoft" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d7c3588-7513-4e9d-8bac-63fe696b1e0e"), "Sandbox / Survival / Adventure" },
                    { new Guid("68e1037c-d133-4d74-84f6-295620c09911"), "First-Person Shooter" },
                    { new Guid("6ce42134-096b-46ea-a618-45b8a2bd29b3"), "Racing / Action-adventure" },
                    { new Guid("8492ee79-bc81-4c92-ab76-cf3b25a20388"), "Battle Royale / Third-Person Shooter / Building" },
                    { new Guid("9642dcb4-910d-4dc9-b04d-c3ab81d3f71a"), "RPG / Stealth / Action-adventure" },
                    { new Guid("991fc42b-945b-4fd8-a7ea-58bb04364f9b"), "Battle Royale / Third-Person Shooter / First-Person Shooter" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRestriction", "CompanyId", "Description", "GenreId", "ImageUrl", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("1e5e6c2f-19ff-4b46-a905-5a45a9d30446"), 14, new Guid("a9aee043-77f6-4af3-a04e-9936a8e99c13"), "Hustle by day and risk it all at night in Need for Speed™ Heat Deluxe Edition, a white-knuckle street racer, where the lines of the law fade as the sun starts to set.", new Guid("6ce42134-096b-46ea-a618-45b8a2bd29b3"), "https://gaming-cdn.com/images/products/5362/orig/need-for-speed-heat-pc-game-origin-cover.jpg?v=1649062628", "Need For Speed: Heat", 69.989999999999995, new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c19be66-2d23-4f99-b682-d763e680471a"), 0, new Guid("63a14842-f260-4de7-9fab-70ff4d0191c0"), "Minecraft, developed by Mojang Studios, is a sandbox game that allows players to explore and create their own blocky, procedurally generated worlds.Players can gather resources, build structures, mine for materials, and engage in various activities like farming, crafting, and fighting off monsters.Minecraft's open-world, creative nature has made it a beloved game for players of all ages, and it offers both survival and creative modes to cater to different playstyles.", new Guid("3d7c3588-7513-4e9d-8bac-63fe696b1e0e"), "https://oyster.ignimgs.com/mediawiki/apis.ign.com/minecraft/c/c7/Trails_And_Tales_Header.jpg", "Minecraft", 29.989999999999998, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"), 13, new Guid("a6e6acde-caa2-41c1-b640-1b60d3f51118"), "Fortnite is a highly popular battle royale game developed by Epic Games. Players are dropped onto an island and must compete against each other to be the last one standing. They can gather resources, build structures, and find weapons to aid them in the battle. What sets Fortnite apart is its colorful, cartoony art style and the ability to build structures, which adds a unique strategic element to the gameplay.Additionally, Fortnite often features limited-time events, skins, and challenges to keep the game fresh and engaging.", new Guid("8492ee79-bc81-4c92-ab76-cf3b25a20388"), "https://cdn2.unrealengine.com/social-image-chapter4-s3-3840x2160-d35912cc25ad.jpg", "Fortnite", 0.0, new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c540276d-4b42-403a-938b-5ecb400399d8"), 13, new Guid("eaf0ef53-961a-40bb-82a3-a03d9292830a"), "PUBG is a battle royale game developed by PUBG Corporation. In this game, up to 100 players are parachuted onto an island where they must scavenge for weapons and supplies and fight to be the last person or team standing.PUBG is known for its realistic graphics and intense gameplay, where strategy and survival skills are crucial for success.It was one of the pioneering titles in the battle royale genre.", new Guid("991fc42b-945b-4fd8-a7ea-58bb04364f9b"), "https://wstatic-prod.pubg.com/web/live/static/og/img-og-pubg.jpg", "PlayerUnknown's Battlegrounds (PUBG)", 0.0, new DateTime(2017, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2e76809-dd75-4f8a-b523-05698e5ce3c1"), 12, new Guid("2bff1b30-4409-49b3-94b5-880e53507b58"), "Overwatch 2 is a critically acclaimed, team-based shooter game set in an optimistic future with an evolving roster of heroes. Team up with friends and jump in today.", new Guid("68e1037c-d133-4d74-84f6-295620c09911"), "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_Overwatch2_Season6.png", "Overwatch 2", 0.0, new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f6aebf87-a0d3-467d-a590-3a98d2fe0113"), 18, new Guid("f6c1eb6e-db46-412f-a0cd-7f46b1ced8f6"), "Assassin's Creed Origins is an action role-playing video game played from a third-person perspective. Players complete quests—linear scenarios with set objectives—to progress through the story, and can freely roam the open world environment on foot, horseback, camel-back, horse-drawn vehicles or boat.", new Guid("9642dcb4-910d-4dc9-b04d-c3ab81d3f71a"), "https://image.api.playstation.com/vulcan/img/rnd/202010/0220/mEgt1tDiuDgwqMPCLIzM1gBD.jpg", "Assassin's Creed: Origins", 59.990000000000002, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "GameId", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("2985d531-f2f5-4e07-b5c4-557c28e51e59"), new Guid("2c19be66-2d23-4f99-b682-d763e680471a"), new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"), "Minecraft is a digital sandbox where your imagination is the only limit. Building, exploring, and surviving in this blocky world is endlessly enjoyable." },
                    { new Guid("75edf8f8-0b58-4f59-82fb-438691643e1d"), new Guid("c540276d-4b42-403a-938b-5ecb400399d8"), new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"), "PUBG's realism and intensity make it a standout battle royale game. Heart-pounding firefights and strategic gameplay keep me coming back." },
                    { new Guid("e35bafc5-0fc6-4b14-84c3-1b329fea90f2"), new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"), new Guid("361fbf2d-ade9-4858-be97-a1795b723c62"), "Fortnite is a fast-paced battle royale game with a unique twist - the ability to build structures on the fly. It's a ton of fun!" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "GameId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7edafdd2-7435-4a6f-8fe1-c2d63a994e17"), new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"), new Guid("361fbf2d-ade9-4858-be97-a1795b723c62") },
                    { new Guid("8f0dac20-cc50-42c0-8244-66c700f80764"), new Guid("2c19be66-2d23-4f99-b682-d763e680471a"), new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a") }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "GameId", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("496d467e-52de-43df-80d0-a12b8db0c98f"), new Guid("9e220fe5-9479-48f0-8cf4-245f134275e9"), new Guid("1c77b562-e54d-4944-97f7-88717b6ac76a"), 5.0 },
                    { new Guid("94e28056-b094-4310-86e1-9d6bd445af16"), new Guid("2c19be66-2d23-4f99-b682-d763e680471a"), new Guid("361fbf2d-ade9-4858-be97-a1795b723c62"), 10.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId",
                table: "Comments",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_GameId",
                table: "Favourites",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CompanyId",
                table: "Games",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_GameId",
                table: "Ratings",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
