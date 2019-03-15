using Microsoft.EntityFrameworkCore.Migrations;

namespace denizdikbiyik_CET322_HW1.Migrations
{
    public partial class Inital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TelNo",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "StudentNo",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TelNo",
                table: "Students",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "StudentNo",
                table: "Students",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
