using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "IndigenousLand", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 3, "Chit-dee-ni (Chetco) and Tolowa Dee-ni’", "Near Brookings, Oregon, United States", "Alfred A. Loeb", "state" },
                    { 4, "Cayuse, Umatilla and Walla Walla, Confederated Tribes of Warm Springs", "Near John Day, Oregon, United States", "Bates State Park", "state" },
                    { 5, "Abenaki / Abénaquis, Penobscot, and Wabanaki Confederacy", "Maine", "Acadia", "national" },
                    { 6, "Núu-agha-tʉvʉ-pʉ̱ (Ute)", "Utah", "Arches", "national" },
                    { 7, "Cheyenne, Mnicoujou, Očhéthi Šakówiŋ", "South Dakota", "Badlands", "national" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);
        }
    }
}
