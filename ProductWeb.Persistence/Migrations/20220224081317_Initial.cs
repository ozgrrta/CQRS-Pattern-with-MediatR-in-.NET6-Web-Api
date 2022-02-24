using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductWeb.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Picture = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Name", "Picture", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { "09597e51-1f32-4eb9-bf72-6cbb0118851c", "5ae47bde", "Product_2", "http://www.example.com/de1e89d1", 13.36m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(8830) },
                    { "2c1a1bbf-cd4a-472e-a63f-3b8be9fb75ac", "6221159a", "Product_20", "http://www.example.com/5b5d0e82", 7.97m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(522) },
                    { "3334528c-04a8-4b80-928e-9b22312545c4", "51648e89", "Product_15", "http://www.example.com/58d375b7", 67.99m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(293) },
                    { "33c734d6-a427-47d2-a41b-6a88f2c9cf9c", "d0ed1cda", "Product_11", "http://www.example.com/435b7bd7", 34.51m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(41) },
                    { "3422f4b5-1598-473c-98ab-d1d44e40a77b", "06922b75", "Product_9", "http://www.example.com/be80d7db", 66.84m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9891) },
                    { "3da17343-1219-4191-a3c9-21893cf54c75", "06730bdb", "Product_10", "http://www.example.com/b67b5818", 35.60m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9992) },
                    { "4f0dfc62-3583-40d3-9e60-d27984e9ec34", "a7eb6aa3", "Product_12", "http://www.example.com/75abd660", 83.04m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(89) },
                    { "61928688-9565-4dbd-9950-b4c3921115bc", "3ed8763b", "Product_19", "http://www.example.com/014f3eeb", 23.09m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(484) },
                    { "6235ee0b-6d03-4990-8fe7-6f6b6ef6acc6", "2684e9c4", "Product_4", "http://www.example.com/55fbcad9", 13.23m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9522) },
                    { "67f7fec6-9429-442e-90b2-b0480a907041", "3c8e0a27", "Product_1", "http://www.example.com/551f4dd3", 24.05m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(8674) },
                    { "6f4e9622-1180-4412-a87d-3de537859472", "7f5f6990", "Product_3", "http://www.example.com/564cb94e", 63.85m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9474) },
                    { "756ab847-203a-48ad-8322-7a17d6541748", "9da8697b", "Product_14", "http://www.example.com/34f6a685", 60.27m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(181) },
                    { "9091879f-a0bb-4d49-9e9f-da60a055dd2d", "38eef0ba", "Product_6", "http://www.example.com/d4934363", 12.30m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9675) },
                    { "9e0cbdf7-78ef-49ec-ba3b-35f117423b5a", "b69d7cfb", "Product_8", "http://www.example.com/5a7f789a", 29.86m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9774) },
                    { "9e95420b-0417-4f60-831f-1e40bc8857da", "f24628ff", "Product_16", "http://www.example.com/fc0c018c", 74.69m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(353) },
                    { "a4bc87c7-cbcf-4412-aae2-b4dd8532fc21", "1156e94f", "Product_7", "http://www.example.com/ae5709c7", 26.82m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9724) },
                    { "c9303654-745d-4049-bb8c-f6d3b48ad58a", "1095b7e3", "Product_17", "http://www.example.com/b00d87a8", 8.13m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(398) },
                    { "f0132c1a-dc8a-41c7-8ec8-91d163259a42", "490775e8", "Product_18", "http://www.example.com/869df89f", 76.41m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(445) },
                    { "f2a12bce-70f6-42c0-99e6-1aeb71d31061", "977a2e95", "Product_5", "http://www.example.com/123192ef", 61.79m, new DateTime(2022, 2, 24, 8, 13, 17, 192, DateTimeKind.Utc).AddTicks(9567) },
                    { "f8e99452-e4e1-47d2-9dc2-5aa9caf65cb3", "d943e977", "Product_13", "http://www.example.com/9c2fd2ec", 72.85m, new DateTime(2022, 2, 24, 8, 13, 17, 193, DateTimeKind.Utc).AddTicks(134) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
