using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD10Mins.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 4096, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 1, "This is some example content for post 1. The content is very interesting and I just wanted it to be two sentences long.", "Post 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 2, "This is some example content for post 2. The content is very interesting and I just wanted it to be two sentences long.", "Post 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 3, "This is some example content for post 3. The content is very interesting and I just wanted it to be two sentences long.", "Post 3" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 4, "This is some example content for post 4. The content is very interesting and I just wanted it to be two sentences long.", "Post 4" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 5, "This is some example content for post 5. The content is very interesting and I just wanted it to be two sentences long.", "Post 5" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 6, "This is some example content for post 6. The content is very interesting and I just wanted it to be two sentences long.", "Post 6" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 7, "This is some example content for post 7. The content is very interesting and I just wanted it to be two sentences long.", "Post 7" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 8, "This is some example content for post 8. The content is very interesting and I just wanted it to be two sentences long.", "Post 8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 9, "This is some example content for post 9. The content is very interesting and I just wanted it to be two sentences long.", "Post 9" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 10, "This is some example content for post 10. The content is very interesting and I just wanted it to be two sentences long.", "Post 10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
