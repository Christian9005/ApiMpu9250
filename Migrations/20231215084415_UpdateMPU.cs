using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMpu9250.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMPU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Pitch",
                table: "Mpus",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Roll",
                table: "Mpus",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Yaw",
                table: "Mpus",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pitch",
                table: "Mpus");

            migrationBuilder.DropColumn(
                name: "Roll",
                table: "Mpus");

            migrationBuilder.DropColumn(
                name: "Yaw",
                table: "Mpus");
        }
    }
}
