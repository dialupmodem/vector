using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vector.Migrations
{
    /// <inheritdoc />
    public partial class AddJobDescriptionLocationSalarySource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Salary",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Applications");
        }
    }
}
