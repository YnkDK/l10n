using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locale",
                columns: table => new
                {
                    LocaleId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<byte[]>(rowVersion: true, nullable: false),
                    LanguageCode = table.Column<string>(maxLength: 2, nullable: true),
                    CountryCode = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locale", x => x.LocaleId);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Phrase",
                columns: table => new
                {
                    PhraseId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<byte[]>(rowVersion: true, nullable: false),
                    OrganizationId = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(maxLength: 2047, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phrase", x => x.PhraseId);
                    table.ForeignKey(
                        name: "FK_Phrase_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<byte[]>(rowVersion: true, nullable: false),
                    OrganizationId = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Picture = table.Column<string>(maxLength: 2047, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Localization",
                columns: table => new
                {
                    LocalizationId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Value = table.Column<string>(maxLength: 2047, nullable: false),
                    LocaleId = table.Column<Guid>(nullable: false),
                    PhraseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localization", x => x.LocalizationId);
                    table.ForeignKey(
                        name: "FK_Localization_Locale_LocaleId",
                        column: x => x.LocaleId,
                        principalTable: "Locale",
                        principalColumn: "LocaleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Localization_Phrase_PhraseId",
                        column: x => x.PhraseId,
                        principalTable: "Phrase",
                        principalColumn: "PhraseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Localization_LocaleId",
                table: "Localization",
                column: "LocaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Localization_PhraseId",
                table: "Localization",
                column: "PhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_Phrase_OrganizationId",
                table: "Phrase",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_OrganizationId",
                table: "User",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Localization");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Locale");

            migrationBuilder.DropTable(
                name: "Phrase");

            migrationBuilder.DropTable(
                name: "Organization");
        }
    }
}
