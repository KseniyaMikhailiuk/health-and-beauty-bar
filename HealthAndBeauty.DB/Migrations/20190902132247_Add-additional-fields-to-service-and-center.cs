using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAndBeauty.DB.Migrations
{
    public partial class Addadditionalfieldstoserviceandcenter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CenterServices",
                table: "CenterServices");

            migrationBuilder.AddColumn<int>(
                name: "CenterServiceID",
                table: "CenterServices",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "CenterServices",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CenterServices",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "Centers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CenterServices",
                table: "CenterServices",
                column: "CenterServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_CenterServices_ServiceID",
                table: "CenterServices",
                column: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CenterServices",
                table: "CenterServices");

            migrationBuilder.DropIndex(
                name: "IX_CenterServices_ServiceID",
                table: "CenterServices");

            migrationBuilder.DropColumn(
                name: "CenterServiceID",
                table: "CenterServices");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "CenterServices");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CenterServices");

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "Centers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CenterServices",
                table: "CenterServices",
                columns: new[] { "ServiceID", "CenterID" });
        }
    }
}
