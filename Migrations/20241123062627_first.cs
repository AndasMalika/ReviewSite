using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewSite.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendshipQuestionnaire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telegram = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discord = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescribeYourself = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FirstImpression = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendshipQuestionnaire", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendshipQuestionnaire");
        }
    }
}
