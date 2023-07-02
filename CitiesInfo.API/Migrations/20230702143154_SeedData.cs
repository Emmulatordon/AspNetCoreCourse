using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitiesInfo.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Homeland", "Bamenda" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "South West", "Buea" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "The Economic Capital", "Douala" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 1, 1, "The Main street", "Nkwen" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 2, 1, "The Yaounde of Bamenda", "UpStation" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 3, 1, "The University of Bambili", "Bambili" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 4, 2, "The central town of Buea", "Moya" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 5, 2, "The Yaounde of Buea", "Molyko" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 6, 2, "The market", "UpStation" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 7, 3, "The sea port", "Bonas" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 8, 3, "The police headquarters", "Bonamosadi" });

            migrationBuilder.InsertData(
                table: "PointsOfinterest",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[] { 9, 3, "The Anglophone area of douala", "Bonaberi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PointsOfinterest",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
