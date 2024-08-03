using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Center.Migrations
{
    /// <inheritdoc />
    public partial class createtablemrrecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "MatrialsRecord",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                      
                    Arabic = table.Column<bool>(type: "bit", nullable: false),
                    English = table.Column<bool>(type: "bit", nullable: false),
                    Math = table.Column<bool>(type: "bit", nullable: false),
                    Physics = table.Column<bool>(type: "bit", nullable: false),
                    Biology = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatrialsRecord", x => x.StudentId);
                });

          

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatrialsRecord");

            migrationBuilder.DropTable(
                name: "MatrialStudent");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Matrials");
        }
    }
}
