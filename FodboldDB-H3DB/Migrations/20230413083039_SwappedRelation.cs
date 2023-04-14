using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FodboldDB_H3DB.Migrations
{
    /// <inheritdoc />
    public partial class SwappedRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Leagues_LeagueId",
                table: "Matchs");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Matchs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LeagueId",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 20,
                column: "LeagueId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Leagues_LeagueId",
                table: "Matchs",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Leagues_LeagueId",
                table: "Matchs");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Leagues");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Matchs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Leagues_LeagueId",
                table: "Matchs",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
