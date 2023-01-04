using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThiQuynhTrang0611.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyNTQT0611s",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyNTQT0611s", x => x.CompanyID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyNTQT0611s");
        }
    }
}
