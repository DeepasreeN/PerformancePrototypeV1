using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformancePrototypeV1.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRevenueColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Revenue",
                table: "TransactionDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Revenue",
                table: "TransactionDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
