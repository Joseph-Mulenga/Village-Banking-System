using System.ComponentModel.DataAnnotations;

namespace VILLAGEBANKING.Models
{
    public class LoanEligibilityModel
    {
        [Key]
        public int LoanEligibleAmountId { get; set; }
        public int AmountContribution { get; set; }
        public int EligibleLoanAmount { get; set; }

    }
}
