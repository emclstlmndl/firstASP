using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace firstASP.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClearSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "ContactName", "CustomerName", "Email", "Phone", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "12 Rizal St", "Manila", "Ana Cruz", "Acme Corp", "ana@acme.com", "0917-111-1001", "NCR", "1000" },
                    { 2, "34 Mabini Ave", "Cebu", "Ben Lim", "BlueTech", "ben@bluetech.com", "0917-111-1002", "Cebu", "6000" },
                    { 3, "56 Bonifacio", "Davao", "Cara Reyes", "GreenMart", "cara@green.com", "0917-111-1003", "Davao", "8000" },
                    { 4, "78 Luna St", "Manila", "Dan Tan", "SunFoods", "dan@sunfoods.com", "0917-111-1004", "NCR", "1001" },
                    { 5, "9 Osmena Blvd", "Cebu", "Ella Santos", "PrimeParts", "ella@prime.com", "0917-111-1005", "Cebu", "6001" },
                    { 6, "21 Quezon Ave", "Davao", "Faye Ong", "CityCare", "faye@citycare.com", "0917-111-1006", "Davao", "8001" },
                    { 7, "3 Roxas St", "Manila", "Gio Ramos", "NovaSupply", "gio@nova.com", "0917-111-1007", "NCR", "1002" },
                    { 8, "45 Aguinaldo", "Cebu", "Hana Cruz", "StarLink", "hana@starlink.com", "0917-111-1008", "Cebu", "6002" }
                });
        }
    }
}
