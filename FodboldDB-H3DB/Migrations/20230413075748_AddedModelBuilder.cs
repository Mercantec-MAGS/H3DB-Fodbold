using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FodboldDB_H3DB.Migrations
{
    /// <inheritdoc />
    public partial class AddedModelBuilder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Coachs_CoachId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CoachId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Leagues",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AgeGroup",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Coachs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Coachs",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "AgeGroup", "Name" },
                values: new object[] { 20, null, "League 1" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Name", "State" },
                values: new object[,]
                {
                    { 20, null, "Team 1", null },
                    { 21, null, "Team 2", null },
                    { 22, null, "Team 3", null }
                });

            migrationBuilder.InsertData(
                table: "Coachs",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 20, "Coach1", 20 },
                    { 21, "Coach2", 21 },
                    { 22, "Coach3", 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Name",
                table: "Teams",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_Name",
                table: "Leagues",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coachs_Name_TeamId",
                table: "Coachs",
                columns: new[] { "Name", "TeamId" },
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Coachs_TeamId",
                table: "Coachs",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Coachs_Teams_TeamId",
                table: "Coachs",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coachs_Teams_TeamId",
                table: "Coachs");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Name",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Leagues_Name",
                table: "Leagues");

            migrationBuilder.DropIndex(
                name: "IX_Coachs_Name_TeamId",
                table: "Coachs");

            migrationBuilder.DropIndex(
                name: "IX_Coachs_TeamId",
                table: "Coachs");

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Coachs");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "AgeGroup",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Coachs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CoachId",
                table: "Teams",
                column: "CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Coachs_CoachId",
                table: "Teams",
                column: "CoachId",
                principalTable: "Coachs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
