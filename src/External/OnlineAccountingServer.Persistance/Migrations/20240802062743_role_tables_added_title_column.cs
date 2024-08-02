using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineAccountingServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class role_tables_added_title_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Roles");
        }
    }
}
