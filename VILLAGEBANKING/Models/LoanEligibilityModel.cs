using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VILLAGEBANKING.Models
{
    public class LoanEligibilityModel
    {
        [Key]
        public int LoanEligibleAmountId { get; set; }
        public int AmountContribution { get; set; }
        public int EligibleLoanAmount { get; set; }

        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public GroupModel Group { get; set; }

    }
}
