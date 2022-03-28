using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VILLAGEBANKING.Migrations.LoanEligibilityDB
{
    public partial class LoanEligibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    LoanEligibleAmountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountContribution = table.Column<int>(type: "int", nullable: false),
                    EligibleLoanAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.LoanEligibleAmountId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");
        }
    }
}
