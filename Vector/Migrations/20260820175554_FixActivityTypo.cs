using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vector.Migrations
{
    /// <inheritdoc />
    public partial class FixActivityTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationAcvitity_Applications_ApplicationId",
                table: "ApplicationAcvitity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationAcvitity",
                table: "ApplicationAcvitity");

            migrationBuilder.RenameTable(
                name: "ApplicationAcvitity",
                newName: "ApplicationActivity");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationAcvitity_ApplicationId",
                table: "ApplicationActivity",
                newName: "IX_ApplicationActivity_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationActivity",
                table: "ApplicationActivity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationActivity_Applications_ApplicationId",
                table: "ApplicationActivity",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationActivity_Applications_ApplicationId",
                table: "ApplicationActivity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationActivity",
                table: "ApplicationActivity");

            migrationBuilder.RenameTable(
                name: "ApplicationActivity",
                newName: "ApplicationAcvitity");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationActivity_ApplicationId",
                table: "ApplicationAcvitity",
                newName: "IX_ApplicationAcvitity_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationAcvitity",
                table: "ApplicationAcvitity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationAcvitity_Applications_ApplicationId",
                table: "ApplicationAcvitity",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
