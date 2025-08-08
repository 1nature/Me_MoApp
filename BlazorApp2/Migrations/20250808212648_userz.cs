using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class userz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_User_UserID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Phone_PhoneID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Validate_ValidateID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Vendor_VendorID",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_VendorID",
                table: "Users",
                newName: "IX_Users_VendorID");

            migrationBuilder.RenameIndex(
                name: "IX_User_ValidateID",
                table: "Users",
                newName: "IX_Users_ValidateID");

            migrationBuilder.RenameIndex(
                name: "IX_User_PhoneID",
                table: "Users",
                newName: "IX_Users_PhoneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Users_UserID",
                table: "AspNetUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Phone_PhoneID",
                table: "Users",
                column: "PhoneID",
                principalTable: "Phone",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Validate_ValidateID",
                table: "Users",
                column: "ValidateID",
                principalTable: "Validate",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Vendor_VendorID",
                table: "Users",
                column: "VendorID",
                principalTable: "Vendor",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Users_UserID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Phone_PhoneID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Validate_ValidateID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Vendor_VendorID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_VendorID",
                table: "User",
                newName: "IX_User_VendorID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ValidateID",
                table: "User",
                newName: "IX_User_ValidateID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PhoneID",
                table: "User",
                newName: "IX_User_PhoneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_User_UserID",
                table: "AspNetUsers",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Phone_PhoneID",
                table: "User",
                column: "PhoneID",
                principalTable: "Phone",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Validate_ValidateID",
                table: "User",
                column: "ValidateID",
                principalTable: "Validate",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Vendor_VendorID",
                table: "User",
                column: "VendorID",
                principalTable: "Vendor",
                principalColumn: "ID");
        }
    }
}
