using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductWeb.Persistence.Migrations
{
    public partial class InitializeAndDataSeeding : Migration
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
                    { "06a0ec8e-8f2d-476d-aeb5-e67474118d61", "5a42842e", "Product_7", "http://www.example.com/56fc6ac6", 38.59m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8229) },
                    { "09214502-f387-49a9-befc-6b6dc51fea96", "e540fb54", "Product_5", "http://www.example.com/96ba5381", 3.62m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8185) },
                    { "0c04d3f6-0d2e-4636-b90c-cf4daff88982", "3f23f691", "Product_18", "http://www.example.com/2e189850", 63.08m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8514) },
                    { "1d5d92c6-50e1-45f3-93e5-fb27ed2cd18f", "ee0b29c5", "Product_6", "http://www.example.com/08f9463d", 12.22m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8208) },
                    { "542ca218-e9f1-4841-9208-4484d8069bc3", "6a37d6f1", "Product_4", "http://www.example.com/156c57e5", 59.38m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8163) },
                    { "687cdd4a-5d83-48f4-aa16-508672cb9d56", "13154ea8", "Product_11", "http://www.example.com/d57f1776", 17.24m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8336) },
                    { "7d0b2685-a147-4d0a-b14b-1686c2f8fd28", "7c3325a6", "Product_3", "http://www.example.com/60f88fd1", 45.61m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8107) },
                    { "87b533f6-0118-4180-8009-87bd83ae9d93", "c58f42b6", "Product_12", "http://www.example.com/1d7e7dd7", 11.71m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8355) },
                    { "8b3cc4e6-dfb5-47c8-83d6-4f49b65b605c", "b2da035d", "Product_16", "http://www.example.com/1ed53967", 39.87m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8472) },
                    { "9756f5b6-bdfd-41fb-b71d-bedac3bb761a", "ff33806c", "Product_8", "http://www.example.com/57c97deb", 20.02m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8248) },
                    { "b1b20620-03d4-49c4-afdc-56784be97662", "85a9c65e", "Product_1", "http://www.example.com/998e3607", 31.77m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8060) },
                    { "b6119ec1-590f-40d9-8010-0ace2d115769", "308be083", "Product_13", "http://www.example.com/8cae7eee", 49.37m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8374) },
                    { "c8396d60-10c5-4e0b-8bd7-4bb9a0115603", "2c4b7840", "Product_19", "http://www.example.com/6928776a", 13.88m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8533) },
                    { "d34d454c-973f-4eed-8e4c-ed4b0d8aed9d", "9ffd87ba", "Product_20", "http://www.example.com/f3e2c678", 3.91m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8553) },
                    { "e09f5732-7c1d-4eb4-a708-eaf8e3f2c09f", "07fdec6c", "Product_15", "http://www.example.com/42b0c879", 38.90m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8412) },
                    { "e384f667-57e2-43c8-b23f-fef2c90dc139", "a62b24ea", "Product_9", "http://www.example.com/951289be", 0.11m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8269) },
                    { "e66efbb1-4178-4b46-93c7-008e04d48197", "ef16c957", "Product_10", "http://www.example.com/1dc713ac", 24.77m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8315) },
                    { "e758f9d0-350c-4c74-beac-5e96df2f2e93", "ac1d7fd6", "Product_2", "http://www.example.com/02093973", 33.33m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8087) },
                    { "f940d0d4-4bca-4dea-af39-e8645b49a78e", "86e29b7e", "Product_14", "http://www.example.com/cf73317b", 21.03m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8394) },
                    { "fa8e4da2-e777-4897-9a3b-acde9f4b92bf", "49c58b06", "Product_17", "http://www.example.com/57b73960", 12.69m, new DateTime(2022, 2, 13, 21, 41, 17, 403, DateTimeKind.Utc).AddTicks(8494) }
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
