using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VILLAGEBANKING.Migrations.GroupDB
{
    public partial class Groups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanEligibilityModel",
                columns: table => new
                {
                    LoanEligibleAmountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountContribution = table.Column<int>(type: "int", nullable: false),
                    EligibleLoanAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanEligibilityModel", x => x.LoanEligibleAmountId);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MinimumContributionAmount = table.Column<double>(type: "float", nullable: false),
                    FrequencyOfContributions = table.Column<int>(type: "int", nullable: false),
                    LoanRate = table.Column<double>(type: "float", nullable: false),
                    PenaltyFee = table.Column<double>(type: "float", nullable: false),
                    ProvisionalInterest = table.Column<double>(type: "float", nullable: false),
                    LoanEligibleAmountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_LoanEligibilityModel_LoanEligibleAmountId",
                        column: x => x.LoanEligibleAmountId,
                        principalTable: "LoanEligibilityModel",
                        principalColumn: "LoanEligibleAmountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_LoanEligibleAmountId",
                table: "Group",
                column: "LoanEligibleAmountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "LoanEligibilityModel");
        }
    }
}
