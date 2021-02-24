using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class ChangeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserPermission_UserPermissionPermissionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserPermissionPermissionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserPermissionPermissionId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "UserPermission",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UsersUserId",
                table: "Users",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_UsersUserId",
                table: "UserPermission",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermission_Users_UsersUserId",
                table: "UserPermission",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UsersUserId",
                table: "Users",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPermission_Users_UsersUserId",
                table: "UserPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UsersUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UsersUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserPermission_UsersUserId",
                table: "UserPermission");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "UserPermission");

            migrationBuilder.AddColumn<int>(
                name: "UserPermissionPermissionId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserPermissionPermissionId",
                table: "Users",
                column: "UserPermissionPermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserPermission_UserPermissionPermissionId",
                table: "Users",
                column: "UserPermissionPermissionId",
                principalTable: "UserPermission",
                principalColumn: "PermissionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
