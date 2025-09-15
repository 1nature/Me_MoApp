using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class VendorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserData_Vendor_VendorID",
                table: "UserData");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Address_AddressID",
                table: "Vendor");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Phone_PhoneID",
                table: "Vendor");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Posts_PostID",
                table: "Vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor");

            migrationBuilder.RenameTable(
                name: "Vendor",
                newName: "VendorData");

            migrationBuilder.RenameIndex(
                name: "IX_Vendor_PostID",
                table: "VendorData",
                newName: "IX_VendorData_PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Vendor_PhoneID",
                table: "VendorData",
                newName: "IX_VendorData_PhoneID");

            migrationBuilder.RenameIndex(
                name: "IX_Vendor_AddressID",
                table: "VendorData",
                newName: "IX_VendorData_AddressID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorData",
                table: "VendorData",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserData_VendorData_VendorID",
                table: "UserData",
                column: "VendorID",
                principalTable: "VendorData",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VendorData_Address_AddressID",
                table: "VendorData",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VendorData_Phone_PhoneID",
                table: "VendorData",
                column: "PhoneID",
                principalTable: "Phone",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VendorData_Posts_PostID",
                table: "VendorData",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserData_VendorData_VendorID",
                table: "UserData");

            migrationBuilder.DropForeignKey(
                name: "FK_VendorData_Address_AddressID",
                table: "VendorData");

            migrationBuilder.DropForeignKey(
                name: "FK_VendorData_Phone_PhoneID",
                table: "VendorData");

            migrationBuilder.DropForeignKey(
                name: "FK_VendorData_Posts_PostID",
                table: "VendorData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorData",
                table: "VendorData");

            migrationBuilder.RenameTable(
                name: "VendorData",
                newName: "Vendor");

            migrationBuilder.RenameIndex(
                name: "IX_VendorData_PostID",
                table: "Vendor",
                newName: "IX_Vendor_PostID");

            migrationBuilder.RenameIndex(
                name: "IX_VendorData_PhoneID",
                table: "Vendor",
                newName: "IX_Vendor_PhoneID");

            migrationBuilder.RenameIndex(
                name: "IX_VendorData_AddressID",
                table: "Vendor",
                newName: "IX_Vendor_AddressID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserData_Vendor_VendorID",
                table: "UserData",
                column: "VendorID",
                principalTable: "Vendor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Address_AddressID",
                table: "Vendor",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Phone_PhoneID",
                table: "Vendor",
                column: "PhoneID",
                principalTable: "Phone",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Posts_PostID",
                table: "Vendor",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "ID");
        }
    }
}
