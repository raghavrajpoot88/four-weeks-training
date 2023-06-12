using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApplication.Migrations
{
    /// <inheritdoc />
    public partial class DemoApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authentication",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authentication", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommentInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "userInfo",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInfo", x => x.UserName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authentication");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "userInfo");
        }
    }
}
