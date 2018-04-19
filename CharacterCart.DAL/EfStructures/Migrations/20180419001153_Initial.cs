using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharacterCart.DAL.EfStructures.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CharacterCart");

            migrationBuilder.CreateTable(
                name: "CharacterRaces",
                schema: "CharacterCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterRacesName = table.Column<string>(maxLength: 50, nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                schema: "CharacterCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassImage = table.Column<string>(nullable: true),
                    ClassesName = table.Column<string>(maxLength: 50, nullable: true),
                    IsArcaneCaster = table.Column<bool>(nullable: false),
                    IsDivineCaster = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                schema: "CharacterCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UserName = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                schema: "CharacterCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsRanged = table.Column<bool>(nullable: false),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    WeaponImage = table.Column<string>(nullable: true),
                    WeaponName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                schema: "CharacterCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterName = table.Column<string>(maxLength: 50, nullable: false),
                    CharacterRaceIdId = table.Column<int>(nullable: true),
                    ClassIdId = table.Column<int>(nullable: true),
                    PlayerIdId = table.Column<int>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    WeaponIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Character_CharacterRaces_CharacterRaceIdId",
                        column: x => x.CharacterRaceIdId,
                        principalSchema: "CharacterCart",
                        principalTable: "CharacterRaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_Classes_ClassIdId",
                        column: x => x.ClassIdId,
                        principalSchema: "CharacterCart",
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_Player_PlayerIdId",
                        column: x => x.PlayerIdId,
                        principalSchema: "CharacterCart",
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_Weapons_WeaponIdId",
                        column: x => x.WeaponIdId,
                        principalSchema: "CharacterCart",
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Character_CharacterRaceIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "CharacterRaceIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ClassIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "ClassIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_PlayerIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "PlayerIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_WeaponIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "WeaponIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Character",
                schema: "CharacterCart");

            migrationBuilder.DropTable(
                name: "CharacterRaces",
                schema: "CharacterCart");

            migrationBuilder.DropTable(
                name: "Classes",
                schema: "CharacterCart");

            migrationBuilder.DropTable(
                name: "Player",
                schema: "CharacterCart");

            migrationBuilder.DropTable(
                name: "Weapons",
                schema: "CharacterCart");
        }
    }
}
