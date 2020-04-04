using Microsoft.EntityFrameworkCore.Migrations;

namespace ozgunneonCom.Data.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhotoType",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    photoName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    photoTypeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Photos_PhotoType_photoTypeId",
                        column: x => x.photoTypeId,
                        principalTable: "PhotoType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_photoTypeId",
                table: "Photos",
                column: "photoTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PhotoType");
        }
    }
}
