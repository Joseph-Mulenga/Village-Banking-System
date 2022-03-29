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
                    EligibleLoanAmount = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.LoanEligibleAmountId);
                });

            migrationBuilder.CreateTable(
                name: "GroupModel",
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
                    table.PrimaryKey("PK_GroupModel", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_GroupModel_Group_LoanEligibleAmountId",
                        column: x => x.LoanEligibleAmountId,
                        principalTable: "Group",
                        principalColumn: "LoanEligibleAmountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_GroupId",
                table: "Group",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupModel_LoanEligibleAmountId",
                table: "GroupModel",
                column: "LoanEligibleAmountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_GroupModel_GroupId",
                table: "Group",
                column: "GroupId",
                principalTable: "GroupModel",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_GroupModel_GroupId",
                table: "Group");

            migrationBuilder.DropTable(
                name: "GroupModel");

            migrationBuilder.DropTable(
                name: "Group");
        }
    }
}
