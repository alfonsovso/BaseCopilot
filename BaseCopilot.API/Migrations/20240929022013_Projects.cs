using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseCopilot.API.Migrations
{
    /// <inheritdoc />
    public partial class Projects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TaskEntries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TaskEntries");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "TaskEntries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskEntries_ProjectId",
                table: "TaskEntries",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEntries_Projects_ProjectId",
                table: "TaskEntries",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskEntries_Projects_ProjectId",
                table: "TaskEntries");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_TaskEntries_ProjectId",
                table: "TaskEntries");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "TaskEntries");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TaskEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TaskEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
