using Microsoft.EntityFrameworkCore.Migrations;

namespace Epsic.Authx.Migrations
{
    public partial class AjoutisMedecin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "isMedecin",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMedecin",
                table: "AspNetUsers");
        }
    }
}
