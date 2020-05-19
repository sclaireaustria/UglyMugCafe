using Microsoft.EntityFrameworkCore.Migrations;

namespace UglyMugCafe.Migrations
{
    public partial class UpdateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bagel",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DirtyHorchata",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Espresso",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IcedLatte",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TruffleFries",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WMC",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bagel",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DirtyHorchata",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Espresso",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IcedLatte",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TruffleFries",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "WMC",
                table: "Orders");
        }
    }
}
