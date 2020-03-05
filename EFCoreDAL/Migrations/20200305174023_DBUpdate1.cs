using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDAL.Migrations
{
    public partial class DBUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TDSteep_TDTask_TDTaskId",
                table: "TDSteep");

            migrationBuilder.DropIndex(
                name: "IX_TDSteep_TDTaskId",
                table: "TDSteep");

            migrationBuilder.DropColumn(
                name: "TDTaskId",
                table: "TDSteep");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "TDSteep");

            migrationBuilder.AddColumn<int>(
                name: "TDSteepId",
                table: "TDTask",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TDTask_TDSteepId",
                table: "TDTask",
                column: "TDSteepId");

            migrationBuilder.AddForeignKey(
                name: "FK_TDTask_TDSteep_TDSteepId",
                table: "TDTask",
                column: "TDSteepId",
                principalTable: "TDSteep",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TDTask_TDSteep_TDSteepId",
                table: "TDTask");

            migrationBuilder.DropIndex(
                name: "IX_TDTask_TDSteepId",
                table: "TDTask");

            migrationBuilder.DropColumn(
                name: "TDSteepId",
                table: "TDTask");

            migrationBuilder.AddColumn<int>(
                name: "TDTaskId",
                table: "TDSteep",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "TDSteep",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TDSteep_TDTaskId",
                table: "TDSteep",
                column: "TDTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TDSteep_TDTask_TDTaskId",
                table: "TDSteep",
                column: "TDTaskId",
                principalTable: "TDTask",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
