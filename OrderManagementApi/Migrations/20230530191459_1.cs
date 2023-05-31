using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    unitPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 250, nullable: false),
                    quantity = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    discount = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    orderInvoiceNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    orderDateTime = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    totalPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 250, nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    customerAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    shippingAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    shippingDate = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfo", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderInfo");
        }
    }
}
