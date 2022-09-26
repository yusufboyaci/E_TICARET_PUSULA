using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATAACCESS.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "baskets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    MasterId = table.Column<Guid>(type: "uuid", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "timestamp with time zone", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "text", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "text", nullable: true),
                    CreatedADUserName = table.Column<string>(name: "Created AD User Name", type: "text", nullable: true),
                    CreatedBy = table.Column<string>(name: "Created By", type: "text", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "timestamp with time zone", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "text", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "text", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(name: "Modified By", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    UserName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MailAddress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    UserImagePath = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MasterId = table.Column<Guid>(type: "uuid", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "timestamp with time zone", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "text", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "text", nullable: true),
                    CreatedADUserName = table.Column<string>(name: "Created AD User Name", type: "text", nullable: true),
                    CreatedBy = table.Column<string>(name: "Created By", type: "text", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "timestamp with time zone", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "text", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "text", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(name: "Modified By", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    Stock = table.Column<short>(type: "smallint", nullable: true),
                    QuantityPerUnit = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    BasketId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    MasterId = table.Column<Guid>(type: "uuid", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "timestamp with time zone", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "text", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "text", nullable: true),
                    CreatedADUserName = table.Column<string>(name: "Created AD User Name", type: "text", nullable: true),
                    CreatedBy = table.Column<string>(name: "Created By", type: "text", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "timestamp with time zone", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "text", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "text", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(name: "Modified By", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_BasketId",
                table: "products",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_products_UserId",
                table: "products",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "baskets");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
