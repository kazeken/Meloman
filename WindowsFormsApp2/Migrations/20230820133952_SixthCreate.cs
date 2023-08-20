using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp2.Migrations
{
    public partial class SixthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "INN", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "ЖК Керемет, корп.6", "001122", "LTD IVC", "Fintech" },
                    { 2, "пр.Аль-Фараби, 10", "654321", "JSC BCC", "Finance" },
                    { 3, "ул.Назарбаева, 20", "123456", "JSC Halyk Bank", "Finance" },
                    { 4, "ул. Желтоксан, 181", "003322", "JSC Ayt Otel", "Hotel" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "IIN", "LastName", "MiddleName", "OrganizationsId" },
                values: new object[,]
                {
                    { 1, "Azamat", "990101200020", "Zhiyentay", "Salimzhanuly", 1 },
                    { 2, "Sultan", "890101200021", "Abdulla", "Abdulla", 2 },
                    { 3, "Anil", "790101200030", "Kumar", "Anadan", 2 },
                    { 4, "Aleksei", "690101200001", "Lexus", "Olegovich", 3 },
                    { 5, "Nurzhan", "960306200020", "Pernebayev", "Abibullauly", 3 },
                    { 6, "Dias", "900501200020", "Yertay", "Yerasuly", 4 },
                    { 7, "Adbi", "000110200020", "Ali", "Aliyev", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
