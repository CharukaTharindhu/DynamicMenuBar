using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DynamicMenu.Migrations
{
    public partial class AddUserPermisionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserPermissionPermissionId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserPermission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItem = table.Column<string>(nullable: true),
                    Permission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => x.PermissionId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserPermission_UserPermissionPermissionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserPermission");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserPermissionPermissionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserPermissionPermissionId",
                table: "Users");
        }
    }
}
