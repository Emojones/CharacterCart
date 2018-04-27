using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharacterCart.DAL.EfStructures.Migrations
{
    public partial class ModelAddFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_CharacterRaces_CharacterRaceIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Classes_ClassIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Player_PlayerIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Weapons_WeaponIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_CharacterRaceIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_ClassIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_PlayerIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_WeaponIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "CharacterRaceIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "ClassIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "PlayerIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "WeaponIdId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.AddColumn<int>(
                name: "CharacterRaceId",
                schema: "CharacterCart",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                schema: "CharacterCart",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                schema: "CharacterCart",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                schema: "CharacterCart",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Character_CharacterRaceId",
                schema: "CharacterCart",
                table: "Character",
                column: "CharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ClassId",
                schema: "CharacterCart",
                table: "Character",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_PlayerId",
                schema: "CharacterCart",
                table: "Character",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_WeaponId",
                schema: "CharacterCart",
                table: "Character",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_CharacterRaces_CharacterRaceId",
                schema: "CharacterCart",
                table: "Character",
                column: "CharacterRaceId",
                principalSchema: "CharacterCart",
                principalTable: "CharacterRaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Classes_ClassId",
                schema: "CharacterCart",
                table: "Character",
                column: "ClassId",
                principalSchema: "CharacterCart",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Player_PlayerId",
                schema: "CharacterCart",
                table: "Character",
                column: "PlayerId",
                principalSchema: "CharacterCart",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Weapons_WeaponId",
                schema: "CharacterCart",
                table: "Character",
                column: "WeaponId",
                principalSchema: "CharacterCart",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_CharacterRaces_CharacterRaceId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Classes_ClassId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Player_PlayerId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Weapons_WeaponId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_CharacterRaceId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_ClassId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_PlayerId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_WeaponId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "CharacterRaceId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "ClassId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                schema: "CharacterCart",
                table: "Character");

            migrationBuilder.AddColumn<int>(
                name: "CharacterRaceIdId",
                schema: "CharacterCart",
                table: "Character",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassIdId",
                schema: "CharacterCart",
                table: "Character",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerIdId",
                schema: "CharacterCart",
                table: "Character",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponIdId",
                schema: "CharacterCart",
                table: "Character",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Character_CharacterRaces_CharacterRaceIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "CharacterRaceIdId",
                principalSchema: "CharacterCart",
                principalTable: "CharacterRaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Classes_ClassIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "ClassIdId",
                principalSchema: "CharacterCart",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Player_PlayerIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "PlayerIdId",
                principalSchema: "CharacterCart",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Weapons_WeaponIdId",
                schema: "CharacterCart",
                table: "Character",
                column: "WeaponIdId",
                principalSchema: "CharacterCart",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
