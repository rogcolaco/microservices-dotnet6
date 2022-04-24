using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CouponAPI.Migrations
{
    public partial class SeedCouponsDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "id", "coupon_code", "discount_amount" },
                values: new object[] { 1L, "VALE10", 10m });

            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "id", "coupon_code", "discount_amount" },
                values: new object[] { 2L, "VALE15", 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
