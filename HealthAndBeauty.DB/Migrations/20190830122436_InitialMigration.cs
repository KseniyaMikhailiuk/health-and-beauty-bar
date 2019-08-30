using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAndBeauty.DB.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategotyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategotyID);
                });

            migrationBuilder.CreateTable(
                name: "CenterTypes",
                columns: table => new
                {
                    CenterTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterTypes", x => x.CenterTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_Services_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategotyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Centers",
                columns: table => new
                {
                    CenterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CenterTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centers", x => x.CenterID);
                    table.ForeignKey(
                        name: "FK_Centers_CenterTypes_CenterTypeID",
                        column: x => x.CenterTypeID,
                        principalTable: "CenterTypes",
                        principalColumn: "CenterTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CenterServices",
                columns: table => new
                {
                    CenterID = table.Column<int>(nullable: false),
                    ServiceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterServices", x => new { x.ServiceID, x.CenterID });
                    table.ForeignKey(
                        name: "FK_CenterServices_Centers_CenterID",
                        column: x => x.CenterID,
                        principalTable: "Centers",
                        principalColumn: "CenterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CenterServices_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Centers_CenterTypeID",
                table: "Centers",
                column: "CenterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CenterServices_CenterID",
                table: "CenterServices",
                column: "CenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryID",
                table: "Services",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CenterServices");

            migrationBuilder.DropTable(
                name: "Centers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "CenterTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
