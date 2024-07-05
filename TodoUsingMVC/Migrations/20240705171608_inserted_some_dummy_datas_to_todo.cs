using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoUsingMVC.Migrations
{
    /// <inheritdoc />
    public partial class inserted_some_dummy_datas_to_todo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoTb",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { "1", "watch movie" },
                    { "2", "play games" },
                    { "3", "eat food" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoTb",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "TodoTb",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "TodoTb",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
