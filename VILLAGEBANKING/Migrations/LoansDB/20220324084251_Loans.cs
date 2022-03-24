using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VILLAGEBANKING.Migrations.LoansDB
{
    public partial class Loans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanInterestRate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanPrincipal = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanBalance = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanPayementPeriod = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanInstallmentStartDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanInstallmentEndDate = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");
        }
    }
}
