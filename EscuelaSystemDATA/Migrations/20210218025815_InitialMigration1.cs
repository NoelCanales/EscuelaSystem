using Microsoft.EntityFrameworkCore.Migrations;

namespace EscuelaSystemDATA.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Carnet",
                table: "Alumnos");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Alumnos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Alumnos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Alumnos");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Alumnos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Alumnos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Carnet",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
