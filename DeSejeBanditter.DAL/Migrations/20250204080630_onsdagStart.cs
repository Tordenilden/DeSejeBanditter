using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeSejeBanditter.DAL.Migrations
{
    /// <inheritdoc />
    public partial class onsdagStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Samurai",
                columns: table => new
                {
                    SamuraiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samurai", x => x.SamuraiId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samurai");
        }
    }
}
