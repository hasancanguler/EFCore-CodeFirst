using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDAL.Migrations
{
    public partial class firstDBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TDTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Done = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TDSteep",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(nullable: false),
                    TDTaskId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Done = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDSteep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TDSteep_TDTask_TDTaskId",
                        column: x => x.TDTaskId,
                        principalTable: "TDTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TDSteep_TDTaskId",
                table: "TDSteep",
                column: "TDTaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TDSteep");

            migrationBuilder.DropTable(
                name: "TDTask");
        }
    }
}
