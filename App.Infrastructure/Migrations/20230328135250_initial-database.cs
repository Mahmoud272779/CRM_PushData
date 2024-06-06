using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    screenId = table.Column<int>(type: "int", nullable: false),
                    permissionListId = table.Column<int>(type: "int", nullable: false),
                    canOpen = table.Column<bool>(type: "bit", nullable: false),
                    canAdd = table.Column<bool>(type: "bit", nullable: false),
                    canEdit = table.Column<bool>(type: "bit", nullable: false),
                    canDelete = table.Column<bool>(type: "bit", nullable: false),
                    canPrint = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_PermissionList_permissionListId",
                        column: x => x.permissionListId,
                        principalTable: "PermissionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    permissionListId = table.Column<int>(type: "int", nullable: false),
                    employeesId = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Employees_employeesId",
                        column: x => x.employeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_PermissionList_permissionListId",
                        column: x => x.permissionListId,
                        principalTable: "PermissionList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Note", "arabicName", "latinName" },
                values: new object[] { -1, null, "مدير النظام", "Administrator" });

            migrationBuilder.InsertData(
                table: "PermissionList",
                columns: new[] { "Id", "arabicName", "latinName", "note" },
                values: new object[] { -1, "مدير النظام", "System Administrator", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "arabicName", "employeesId", "isActive", "latinName", "password", "permissionListId", "username" },
                values: new object[] { -1, "مدير النظام", -1, true, "administrator", "admin", -1, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Rules_permissionListId",
                table: "Rules",
                column: "permissionListId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_employeesId",
                table: "Users",
                column: "employeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_permissionListId",
                table: "Users",
                column: "permissionListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "PermissionList");
        }
    }
}
