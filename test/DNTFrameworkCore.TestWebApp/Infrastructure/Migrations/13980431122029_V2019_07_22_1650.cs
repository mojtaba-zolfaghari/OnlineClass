using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DNTFrameworkCore.TestWebApp.Infrastructure.Migrations
{
    public partial class V2019_07_22_1650 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcademyName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<long>(nullable: true),
                    NormalizedTitle = table.Column<string>(maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreationDateTime = table.Column<DateTimeOffset>(nullable: false),
                    CreatorBrowserName = table.Column<string>(maxLength: 1024, nullable: true),
                    CreatorIp = table.Column<string>(maxLength: 256, nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    ModificationDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifierBrowserName = table.Column<string>(maxLength: 1024, nullable: true),
                    ModifierIp = table.Column<string>(maxLength: 256, nullable: true),
                    ModifierUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academy_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreationDateTime = table.Column<DateTimeOffset>(nullable: false),
                    CreatorBrowserName = table.Column<string>(maxLength: 1024, nullable: true),
                    CreatorIp = table.Column<string>(maxLength: 256, nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    ModificationDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifierBrowserName = table.Column<string>(maxLength: 1024, nullable: true),
                    ModifierIp = table.Column<string>(maxLength: 256, nullable: true),
                    ModifierUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitDiscount = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "Academy_NormalizedTitle",
                table: "Academy",
                column: "NormalizedTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Academy_UserId1",
                table: "Academy",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceId",
                table: "InvoiceItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_ProductId",
                table: "InvoiceItem",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academy");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "Invoice");
        }
    }
}
