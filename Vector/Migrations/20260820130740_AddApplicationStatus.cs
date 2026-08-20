using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vector.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Applications");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatus",
                columns: new[] { "Id", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Interested", 1 },
                    { 2, "Applied", 2 },
                    { 3, "Interviewing", 3 },
                    { 4, "Rejected", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StatusId",
                table: "Applications",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationStatus_StatusId",
                table: "Applications",
                column: "StatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationStatus_StatusId",
                table: "Applications");

            migrationBuilder.DropTable(
                name: "ApplicationStatus");

            migrationBuilder.DropIndex(
                name: "IX_Applications_StatusId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
