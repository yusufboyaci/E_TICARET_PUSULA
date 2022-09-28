using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATAACCESS.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_users_UserId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_UserId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "products");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "baskets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_baskets_UserId",
                table: "baskets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_baskets_users_UserId",
                table: "baskets",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_baskets_users_UserId",
                table: "baskets");

            migrationBuilder.DropIndex(
                name: "IX_baskets_UserId",
                table: "baskets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "baskets");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_products_UserId",
                table: "products",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_users_UserId",
                table: "products",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
