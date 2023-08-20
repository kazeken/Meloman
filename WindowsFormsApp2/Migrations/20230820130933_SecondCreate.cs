using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp2.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Organizations_OrganizationsId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationsId",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Organizations_OrganizationsId",
                table: "Employees",
                column: "OrganizationsId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Organizations_OrganizationsId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationsId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Organizations_OrganizationsId",
                table: "Employees",
                column: "OrganizationsId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
