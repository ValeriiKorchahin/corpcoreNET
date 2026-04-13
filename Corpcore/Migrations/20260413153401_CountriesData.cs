using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Corpcore.Migrations
{
    /// <inheritdoc />
    public partial class CountriesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000001"), "AF", "Afghanistan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000002"), "AL", "Albania" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000003"), "DZ", "Algeria" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000004"), "AD", "Andorra" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000005"), "AO", "Angola" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000006"), "AR", "Argentina" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000007"), "AM", "Armenia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000008"), "AU", "Australia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000009"), "AT", "Austria" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000010"), "AZ", "Azerbaijan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000011"), "BS", "Bahamas" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000012"), "BH", "Bahrain" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000013"), "BD", "Bangladesh" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000014"), "BY", "Belarus" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000015"), "BE", "Belgium" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000016"), "BO", "Bolivia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000017"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000018"), "BR", "Brazil" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000019"), "BG", "Bulgaria" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000020"), "KH", "Cambodia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000021"), "CM", "Cameroon" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000022"), "CA", "Canada" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000023"), "CL", "Chile" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000024"), "CN", "China" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000025"), "CO", "Colombia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000026"), "HR", "Croatia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000027"), "CU", "Cuba" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000028"), "CY", "Cyprus" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000029"), "CZ", "Czech Republic" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000030"), "DK", "Denmark" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000031"), "EC", "Ecuador" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000032"), "EG", "Egypt" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000033"), "EE", "Estonia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000034"), "ET", "Ethiopia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000035"), "FI", "Finland" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000036"), "FR", "France" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000037"), "GE", "Georgia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000038"), "DE", "Germany" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000039"), "GH", "Ghana" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000040"), "GR", "Greece" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000041"), "HU", "Hungary" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000042"), "IS", "Iceland" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000043"), "IN", "India" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000044"), "ID", "Indonesia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000045"), "IR", "Iran" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000046"), "IQ", "Iraq" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000047"), "IE", "Ireland" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000048"), "IL", "Israel" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000049"), "IT", "Italy" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000050"), "JP", "Japan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000051"), "JO", "Jordan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000052"), "KZ", "Kazakhstan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000053"), "KE", "Kenya" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000054"), "KW", "Kuwait" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000055"), "LV", "Latvia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000056"), "LB", "Lebanon" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000057"), "LT", "Lithuania" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000058"), "LU", "Luxembourg" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000059"), "MY", "Malaysia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000060"), "MX", "Mexico" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000061"), "MD", "Moldova" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000062"), "MA", "Morocco" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000063"), "NL", "Netherlands" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000064"), "NZ", "New Zealand" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000065"), "NG", "Nigeria" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000066"), "NO", "Norway" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000067"), "PK", "Pakistan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000068"), "PE", "Peru" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000069"), "PH", "Philippines" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000070"), "PL", "Poland" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000071"), "PT", "Portugal" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000072"), "QA", "Qatar" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000073"), "RO", "Romania" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000074"), "RU", "Russia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000075"), "SA", "Saudi Arabia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000076"), "RS", "Serbia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000077"), "SG", "Singapore" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000078"), "SK", "Slovakia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000079"), "SI", "Slovenia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000080"), "ZA", "South Africa" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000081"), "KR", "South Korea" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000082"), "ES", "Spain" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000083"), "LK", "Sri Lanka" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000084"), "SE", "Sweden" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000085"), "CH", "Switzerland" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000086"), "TW", "Taiwan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000087"), "TH", "Thailand" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000088"), "TN", "Tunisia" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000089"), "TR", "Turkey" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000090"), "UA", "Ukraine" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000091"), "AE", "United Arab Emirates" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000092"), "GB", "United Kingdom" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000093"), "US", "United States" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000094"), "UY", "Uruguay" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000095"), "UZ", "Uzbekistan" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000096"), "VE", "Venezuela" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000097"), "VN", "Vietnam" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000098"), "YE", "Yemen" },
                    { new Guid("a1b2c3d4-0000-0000-0000-000000000099"), "ZW", "Zimbabwe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-0000-0000-0000-000000000099"));
        }
    }
}
