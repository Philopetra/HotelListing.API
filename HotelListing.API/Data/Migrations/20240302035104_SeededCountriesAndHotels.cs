using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededCountriesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "Name" },
                values: new object[,]
                {
                    { "1", "NG", "Nigeria" },
                    { "10", "DE", "Germany" },
                    { "11", "IT", "Italy" },
                    { "12", "BR", "Brazil" },
                    { "13", "RU", "Russia" },
                    { "14", "JP", "Japan" },
                    { "15", "ZA", "South Africa" },
                    { "2", "JM", "Jamaica" },
                    { "3", "US", "United States" },
                    { "4", "CA", "Canada" },
                    { "5", "GB", "United Kingdom" },
                    { "6", "AU", "Australia" },
                    { "7", "IN", "India" },
                    { "8", "CN", "China" },
                    { "9", "FR", "France" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { "1", "1 South County Road, Palm Beach, Florida, USA", "3", "The Breakers Palm Beach", "4.8" },
                    { "10", "Salihdede Mahallesi Kaplankaya Turkey", "11", "Six Senses Kaplankaya", "4.8" },
                    { "2", "3-3-1 Nishi-Shinjuku, Shinjuku-ku, Tokyo, Japan", "14", "Park Hyatt Tokyo", "4.9" },
                    { "3", "Motu Tehotu, Bora Bora, French Polynesia", "6", "Four Seasons Resort Bora Bora", "5.0" },
                    { "4", "Auchterarder, Perthshire, Scotland", "5", "Gleneagles Hotel", "4.7" },
                    { "5", "Gütschstrasse 8, Lucerne, Switzerland", "5", "Hotel Château Gütsch", "4.9" },
                    { "6", "32 Liangmaqiao Road, Chaoyang District, Beijing, China", "8", "頤和園洲際酒店 (InterContinental Beijing Sanlitun)", "4.8" },
                    { "7", "Palm Jumeirah, Dubai, United Arab Emirates", "6", "One&Only The Palm", "4.7" },
                    { "8", "Nybrogatan 11, Stockholm, Sweden", "11", "Ett Hem Stockholm", "5.0" },
                    { "9", "1 Cathedral Square, Perth, Australia", "6", "COMO The Treasury", "4.9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "8");
        }
    }
}
