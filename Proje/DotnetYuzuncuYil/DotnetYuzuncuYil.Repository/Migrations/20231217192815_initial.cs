using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYil.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedDate", "TeamName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 17, 22, 28, 15, 185, DateTimeKind.Local).AddTicks(9993), "Development", null },
                    { 2, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(9), "Sales", null },
                    { 3, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(10), "Marketing", null },
                    { 4, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(11), "HR", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Password", "TeamId", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(310), "busegizemsezer@gmail.com", "123456", 1, null, "busegizem" },
                    { 2, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(314), "elnurakkurt@gmail.com", "122332", 2, null, "elnurak" },
                    { 3, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(315), "seherselintosun@gmail.com", "42342342", 3, null, "seherselin" },
                    { 4, new DateTime(2023, 12, 17, 22, 28, 15, 186, DateTimeKind.Local).AddTicks(316), "gizemturan@gmail.com", "35345345", 4, null, "gizemturan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                table: "UserProfiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeamId",
                table: "Users",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
