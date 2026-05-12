using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESaat.Migrations
{
    /// <inheritdoc />
    public partial class NewTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad32bc5f-4209-4936-9b7e-211158fbbc2a", "AQAAAAIAAYagAAAAEJX4Q6km0hGIAkUCDVG7FVwlyz0z8yKK9LaL2MjCS6i1Yj3ZCNAEbhFzW8kIxB9hvw==", "b30b9e68-4e8f-48b5-9232-c640ced4975b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59f98678-aa5e-4e0e-8d33-4250a43677cb", "AQAAAAIAAYagAAAAEJCEVfbU8mGyh2kUXStpRqqClgoKzg09wp5BUgfuGqMVFG29ZD3oNiwBE5M5HpV8PQ==", "15a0aee1-59b4-4f36-8ebe-69f3b2fece38" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Price", "Title" },
                values: new object[] { "Büyük boy model, otomatik mekanizma, ADLC çelik.", "saat1.jpeg", 489000m, "SANTOS DE CARTIER SAAT" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Price", "Title" },
                values: new object[] { "Büyük boy model, otomatik mekanizma, ADLC çelik.", "saat2.jpeg", 489000m, "SANTOS DE CARTIER SAAT" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Price", "Title" },
                values: new object[] { "Küçük model, kuvars mekanizma, sarı altın.", "saat3.jpeg", 492000m, "PANTHÈRE DE CARTIER SAAT" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Olağanüstü forma ve tasarıma sahip bir saat.", "saat4.jpeg", "TANK  " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Olağanüstü forma ve tasarıma sahip bir saat.", "saat5.jpeg", "VENDÔME LOUIS CARTIER" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Olağanüstü forma ve tasarıma sahip bir saat.", "saat6.jpeg", "TANK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f61b89-81a7-41f7-b2f9-b3a8e256a08a", "AQAAAAIAAYagAAAAEHszL2t6Gnrkjyl2XWR6r/OTSdyNFy1ErRx98l0axr4zbjak4eb/Zxo5mZqcDmX3Jw==", "14e8963b-39e5-4477-a583-0c64a8019f51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2678b15-6701-4f6a-844b-9674b81c4841", "AQAAAAIAAYagAAAAEEDDdzx16Jz+DY7EpO7uiP3bAKR+qPKIPpwJ8VRMnFzDp7o9/dwKOFeuR0N05tCZdg==", "54e38503-128c-4b5c-badb-d5b033b47665" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Price", "Title" },
                values: new object[] { "Apple HomePod Hoparlör", "homepod.jpg", 45000m, "Apple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Price", "Title" },
                values: new object[] { "Apple Şarj Kablosu Magsafe", "magsafe.jpg", 55000m, "Apple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Price", "Title" },
                values: new object[] { "Apple AirPods Pro 2", "airpods-pro-2-hero-select-202409.png", 75000m, "Apple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Apple AirPods Pro 2", "airpods-max.jpeg", "Apple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Apple Key Pro 2", "key.jpeg", "Apple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Apple Mouse Pro ", "mouse.jpeg", "Apple" });
        }
    }
}
