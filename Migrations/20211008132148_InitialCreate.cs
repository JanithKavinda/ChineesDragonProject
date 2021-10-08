using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreChineesDragon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReferanceNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    OrderDateTime = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    OrderedThrough = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    OrderType = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    OrderItems = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    OrderStatuses = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
