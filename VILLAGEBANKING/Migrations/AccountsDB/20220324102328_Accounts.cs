using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VILLAGEBANKING.Migrations.AccountsDB
{
    public partial class Accounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BankBranchName = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
