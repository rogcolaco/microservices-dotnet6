using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Vestuário", "Description", "https://www.camisetas4fun.com.br/media/product/7e2/camiseta-one-piece-1c2.jpg", "Name 2", 169.90000000000001 },
                    { 4L, "Vestuário", "Description 4", "https://cf.shopee.com.br/file/f2fd18b782a1ab556c35f03f443f58a1", "Name 4", 619.89999999999998 },
                    { 5L, "Papelaria", "Description 5", "https://www.camisetas4fun.com.br/media/product/7e2/camiseta-one-piece-1c2.jpg", "Name 5", 269.89999999999998 },
                    { 6L, "Vestuário", "Description 6", "https://a-static.mlcdn.com.br/618x463/camisa-camiseta-one-piece-monkey-d-luffy-manga-home-custom/diasoutlet/30774fcc058f11ecb5264201ac185013/6e9c651f7666e1b720c9fe0987fc12c0.jpg", "Name 6", 629.89999999999998 },
                    { 7L, "Papelaria", "Description 7", "https://cf.shopee.com.br/file/f2fd18b782a1ab556c35f03f443f58a1", "Name 7", 692.89999999999998 },
                    { 8L, "Papelaria", "Description 8", "https://www.camisetas4fun.com.br/media/product/7e2/camiseta-one-piece-1c2.jpg", "Name 8", 691.89999999999998 },
                    { 9L, "Vestuário", "Description 9", "https://a-static.mlcdn.com.br/618x463/camisa-camiseta-one-piece-monkey-d-luffy-manga-home-custom/diasoutlet/30774fcc058f11ecb5264201ac185013/6e9c651f7666e1b720c9fe0987fc12c0.jpg", "Name 9", 619.89999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);
        }
    }
}
