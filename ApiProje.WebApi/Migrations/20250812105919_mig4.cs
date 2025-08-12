using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProje.WebApi.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "YummyEvents",
                columns: table => new
                {
                    YummyEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YummyEvents", x => x.YummyEventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YummyEvents");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId1",
                table: "Categories",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryId1",
                table: "Categories",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }
    }
}
