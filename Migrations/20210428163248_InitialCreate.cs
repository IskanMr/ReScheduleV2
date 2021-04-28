using Microsoft.EntityFrameworkCore.Migrations;

namespace ReSchedule.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "listTugas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durasi = table.Column<int>(type: "int", nullable: false),
                    Deadline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listTugas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_listTugas_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_listTugas_UserID",
                table: "listTugas",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "listTugas");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
