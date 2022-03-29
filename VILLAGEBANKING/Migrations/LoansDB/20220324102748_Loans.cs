using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VILLAGEBANKING.Migrations.LoansDB
{
    public partial class Loans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountsModel",
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
                    table.PrimaryKey("PK_AccountsModel", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanInterestRate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanPrincipal = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanBalance = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanPayementPeriod = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanInstallmentStartDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanInstallmentEndDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loans_AccountsModel_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountsModel",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_AccountId",
                table: "Loans",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "AccountsModel");
        }
    }
}
