using Microsoft.EntityFrameworkCore.Migrations;

namespace ozgunneonCom.Data.Migrations
{
    public partial class updatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_PhotoType_photoTypeId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoType",
                table: "PhotoType");

            migrationBuilder.RenameTable(
                name: "PhotoType",
                newName: "PhotoTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoTypes",
                table: "PhotoTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_PhotoTypes_photoTypeId",
                table: "Photos",
                column: "photoTypeId",
                principalTable: "PhotoTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_PhotoTypes_photoTypeId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoTypes",
                table: "PhotoTypes");

            migrationBuilder.RenameTable(
                name: "PhotoTypes",
                newName: "PhotoType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoType",
                table: "PhotoType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_PhotoType_photoTypeId",
                table: "Photos",
                column: "photoTypeId",
                principalTable: "PhotoType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
