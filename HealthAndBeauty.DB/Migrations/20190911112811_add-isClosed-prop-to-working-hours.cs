using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAndBeauty.DB.Migrations
{
    public partial class addisClosedproptoworkinghours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "WorkingHours",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Centers",
                keyColumn: "CenterID",
                keyValue: 1,
                column: "MainImageUrl",
                value: "https://picsum.photos/id/237/200/300");

            migrationBuilder.UpdateData(
                table: "Centers",
                keyColumn: "CenterID",
                keyValue: 2,
                column: "MainImageUrl",
                value: "https://picsum.photos/id/237/200/300");

            migrationBuilder.UpdateData(
                table: "Centers",
                keyColumn: "CenterID",
                keyValue: 3,
                column: "MainImageUrl",
                value: "https://picsum.photos/id/237/200/300");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "WorkingHours");

            migrationBuilder.UpdateData(
                table: "Centers",
                keyColumn: "CenterID",
                keyValue: 1,
                column: "MainImageUrl",
                value: "https://picsum.photos/id/237/500/300");

            migrationBuilder.UpdateData(
                table: "Centers",
                keyColumn: "CenterID",
                keyValue: 2,
                column: "MainImageUrl",
                value: "https://picsum.photos/id/237/500/300");

            migrationBuilder.UpdateData(
                table: "Centers",
                keyColumn: "CenterID",
                keyValue: 3,
                column: "MainImageUrl",
                value: "https://picsum.photos/id/237/500/300");
        }
    }
}
