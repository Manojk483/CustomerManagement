using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedStaticData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedOn", "Email", "FirstName", "LastName", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4883), "John123@email.com", "John", "Doe", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4968) },
                    { 2, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4972), "Jane123@email.com", "Jane", "Smith", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4974) },
                    { 3, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4977), "Smith123@email.com", "Smith", "Dow", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4979) },
                    { 4, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4981), "Michael123@email.com", "Michael", "John", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4983) },
                    { 5, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4985), "Brian123@email.com", "Brian", "Brian", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4986) },
                    { 6, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4988), "Donald123@email.com", "Donald", "Donald", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4990) },
                    { 7, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4992), "Jesse123@email.com", "Jesse", "Jesse", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4994) },
                    { 8, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4996), "Juan123@email.com", "Juan", "Juan", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4997) },
                    { 9, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(4999), "Brandon123@email.com", "Brandon", "Brandon", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5001) },
                    { 10, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5003), "Bradford123@email.com", "Bradford", "Bradford", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5005) },
                    { 11, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5007), "Riley123@email.com", "Riley", "Riley", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5009) },
                    { 12, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5011), "Catarino123@email.com", "Catarino", "Catarino", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5012) },
                    { 13, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5015), "William123@email.com", "William", "William", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5016) },
                    { 14, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5018), "Michael123@email.com", "Michael", "Michael", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5020) },
                    { 15, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5022), "James123@email.com", "James", "Smith", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5024) },
                    { 16, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5026), "Irving123@email.com", "Irving", "Irving", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5027) },
                    { 17, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5029), "Donald123@email.com", "Donald", "Donald", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5031) },
                    { 18, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5033), "Ryan123@email.com", "Ryan", "Ryan", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5034) },
                    { 19, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5036), "Renzy123@email.com", "Renzy", "Renzy", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5038) },
                    { 20, new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5040), "Arash123@email.com", "Arash", "Arash", new DateTime(2024, 1, 3, 17, 57, 8, 12, DateTimeKind.Local).AddTicks(5041) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
