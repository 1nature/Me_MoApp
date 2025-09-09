using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationmiga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Users_UserID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Users_UserID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserID",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vote_Users_UserID",
                table: "Vote");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "AspNetUsers",
                newName: "UserDataID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserDataID");

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidateID = table.Column<int>(type: "int", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: true),
                    PhoneID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserData_Phone_PhoneID",
                        column: x => x.PhoneID,
                        principalTable: "Phone",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserData_Validate_ValidateID",
                        column: x => x.ValidateID,
                        principalTable: "Validate",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserData_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserData_PhoneID",
                table: "UserData",
                column: "PhoneID");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_ValidateID",
                table: "UserData",
                column: "ValidateID");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_VendorID",
                table: "UserData",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserData_UserDataID",
                table: "AspNetUsers",
                column: "UserDataID",
                principalTable: "UserData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_UserData_UserID",
                table: "Comment",
                column: "UserID",
                principalTable: "UserData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_UserData_UserID",
                table: "Posts",
                column: "UserID",
                principalTable: "UserData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_UserData_UserID",
                table: "Vote",
                column: "UserID",
                principalTable: "UserData",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserData_UserDataID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_UserData_UserID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_UserData_UserID",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vote_UserData_UserID",
                table: "Vote");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.RenameColumn(
                name: "UserDataID",
                table: "AspNetUsers",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserDataID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserID");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneID = table.Column<int>(type: "int", nullable: true),
                    ValidateID = table.Column<int>(type: "int", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Phone_PhoneID",
                        column: x => x.PhoneID,
                        principalTable: "Phone",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Validate_ValidateID",
                        column: x => x.ValidateID,
                        principalTable: "Validate",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhoneID",
                table: "Users",
                column: "PhoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ValidateID",
                table: "Users",
                column: "ValidateID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_VendorID",
                table: "Users",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Users_UserID",
                table: "AspNetUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Users_UserID",
                table: "Comment",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserID",
                table: "Posts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_Users_UserID",
                table: "Vote",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
