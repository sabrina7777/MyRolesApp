using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyRolesApp.Data.Migrations
{
    public partial class jobdescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Job");
        }
    }
}
