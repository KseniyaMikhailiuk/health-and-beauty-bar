using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAndBeauty.DB.Migrations
{
    public partial class initialmigration : Migration
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
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    Salt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
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
                    MainImageUrl = table.Column<string>(nullable: true),
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
                    CenterServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CenterID = table.Column<int>(nullable: false),
                    ServiceID = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterServices", x => x.CenterServiceID);
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

            migrationBuilder.CreateTable(
                name: "WorkingHours",
                columns: table => new
                {
                    WeekDayID = table.Column<int>(nullable: false),
                    CenterID = table.Column<int>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingHours", x => new { x.CenterID, x.WeekDayID });
                    table.ForeignKey(
                        name: "FK_WorkingHours_Centers_CenterID",
                        column: x => x.CenterID,
                        principalTable: "Centers",
                        principalColumn: "CenterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategotyID", "Name" },
                values: new object[,]
                {
                    { 1, "CategoryA" },
                    { 2, "CategoryB" },
                    { 3, "CategoryC" },
                    { 4, "CategoryD" },
                    { 5, "CategoryE" }
                });

            migrationBuilder.InsertData(
                table: "CenterTypes",
                columns: new[] { "CenterTypeID", "Name" },
                values: new object[,]
                {
                    { 1, "Beauty" },
                    { 2, "Medical" }
                });

            migrationBuilder.InsertData(
                table: "Centers",
                columns: new[] { "CenterID", "CenterTypeID", "MainImageUrl", "Name" },
                values: new object[,]
                {
                    { 3, 2, "https://picsum.photos/id/237/500/300", "CenterC" },
                    { 1, 1, "https://picsum.photos/id/237/500/300", "CenterA" },
                    { 2, 1, "https://picsum.photos/id/237/500/300", "CenterB" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "CategoryID", "Name" },
                values: new object[,]
                {
                    { 15, 5, "ServiceO" },
                    { 10, 5, "ServiceJ" },
                    { 8, 5, "ServiceH" },
                    { 14, 4, "ServiceN" },
                    { 9, 4, "ServiceI" },
                    { 7, 4, "ServiceG" },
                    { 13, 3, "ServiceM" },
                    { 3, 3, "ServiceC" },
                    { 12, 2, "ServiceL" },
                    { 5, 2, "ServiceE" },
                    { 2, 2, "ServiceB" },
                    { 11, 1, "ServiceK" },
                    { 4, 1, "ServiceD" },
                    { 6, 3, "ServiceF" },
                    { 1, 1, "ServiceA" }
                });

            migrationBuilder.InsertData(
                table: "CenterServices",
                columns: new[] { "CenterServiceID", "CenterID", "Discount", "Price", "ServiceID" },
                values: new object[,]
                {
                    { 1, 1, 0.0, 110.0, 1 },
                    { 2, 1, 0.0, 120.0, 2 },
                    { 3, 1, 0.0, 1120.0, 9 },
                    { 4, 1, 0.0, 104.0, 12 },
                    { 5, 1, 0.0, 1001.0, 10 },
                    { 6, 2, 0.0, 11230.0, 6 },
                    { 7, 2, 0.0, 100.0, 4 },
                    { 8, 2, 0.0, 100.0, 6 },
                    { 9, 2, 0.0, 100.0, 7 },
                    { 10, 2, 0.0, 100.0, 12 },
                    { 11, 2, 0.0, 100.0, 1 },
                    { 12, 2, 0.0, 100.0, 2 },
                    { 13, 3, 0.0, 100.0, 8 },
                    { 14, 3, 0.0, 100.0, 6 },
                    { 15, 3, 0.0, 100.0, 5 }
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
                name: "IX_CenterServices_ServiceID",
                table: "CenterServices",
                column: "ServiceID");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkingHours");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Centers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CenterTypes");
        }
    }
}
