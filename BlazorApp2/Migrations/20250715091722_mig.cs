using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_User_UserDataID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Validate_User_UserID",
                table: "Validate");

            migrationBuilder.DropIndex(
                name: "IX_Validate_UserID",
                table: "Validate");

            migrationBuilder.DropColumn(
                name: "AllUserVotes",
                table: "Validate");

            migrationBuilder.DropColumn(
                name: "EachUserVote",
                table: "Validate");

            migrationBuilder.DropColumn(
                name: "HasValidated",
                table: "Validate");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Validate");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Validate");

            migrationBuilder.RenameColumn(
                name: "UserDataID",
                table: "AspNetUsers",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserDataID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserID");

            migrationBuilder.AddColumn<int>(
                name: "SumTheTotalVotesInAllPosts",
                table: "Validate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalVotesGeneratedFromUserPosts",
                table: "Validate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_User_UserID",
                table: "AspNetUsers",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_User_UserID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SumTheTotalVotesInAllPosts",
                table: "Validate");

            migrationBuilder.DropColumn(
                name: "TotalVotesGeneratedFromUserPosts",
                table: "Validate");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "AspNetUsers",
                newName: "UserDataID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserDataID");

            migrationBuilder.AddColumn<double>(
                name: "AllUserVotes",
                table: "Validate",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EachUserVote",
                table: "Validate",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "HasValidated",
                table: "Validate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Validate",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Validate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Validate_UserID",
                table: "Validate",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_User_UserDataID",
                table: "AspNetUsers",
                column: "UserDataID",
                principalTable: "User",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Validate_User_UserID",
                table: "Validate",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID");
        }
    }
}
