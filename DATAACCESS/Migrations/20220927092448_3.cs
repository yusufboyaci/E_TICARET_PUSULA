using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATAACCESS.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_baskets_BasketId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_BasketId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BasketId",
                table: "products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_products_BasketId",
                table: "products",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_baskets_BasketId",
                table: "products",
                column: "BasketId",
                principalTable: "baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
