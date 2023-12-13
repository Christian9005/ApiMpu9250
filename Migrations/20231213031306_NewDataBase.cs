using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiMpu9250.Migrations
{
    /// <inheritdoc />
    public partial class NewDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ax = table.Column<float>(type: "real", nullable: false),
                    Ay = table.Column<float>(type: "real", nullable: false),
                    Az = table.Column<float>(type: "real", nullable: false),
                    Gx = table.Column<float>(type: "real", nullable: false),
                    Gy = table.Column<float>(type: "real", nullable: false),
                    Gz = table.Column<float>(type: "real", nullable: false),
                    Mx = table.Column<float>(type: "real", nullable: false),
                    My = table.Column<float>(type: "real", nullable: false),
                    Mz = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mpus", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mpus");
        }
    }
}
