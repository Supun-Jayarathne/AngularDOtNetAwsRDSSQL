using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dgtestback.Migrations
{
    /// <inheritdoc />
    public partial class modifytrafficstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ClientProjects",
                newName: "TrafficStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrafficStatus",
                table: "ClientProjects",
                newName: "Status");
        }
    }
}
