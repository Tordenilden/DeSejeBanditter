using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeSejeBanditter.DAL.Migrations
{
    /// <inheritdoc />
    public partial class onsdag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Samurai",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Samurai");
        }
    }
}
