using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vector.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationStatusForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationStatus_StatusId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Applications",
                newName: "ApplicationStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_StatusId",
                table: "Applications",
                newName: "IX_Applications_ApplicationStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationStatus_ApplicationStatusId",
                table: "Applications",
                column: "ApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationStatus_ApplicationStatusId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "ApplicationStatusId",
                table: "Applications",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_ApplicationStatusId",
                table: "Applications",
                newName: "IX_Applications_StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationStatus_StatusId",
                table: "Applications",
                column: "StatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
