using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class GroupModel
    {
        [Key]
        public int GroupId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GroupName { get; set; }

        public double MinimumContributionAmount { get; set; }

        [NotMapped]
        public DateOnly ContributionWindowDateFrom { get; set; }
        [NotMapped]
        public DateOnly ContributionWindowDateTo { get; set; }

        public int FrequencyOfContributions { get; set; }

        public double LoanRate { get; set; }

        public double PenaltyFee { get; set; }
        
        public double ProvisionalInterest { get; set; }

        [NotMapped]
        public DateOnly GroupDateFrom { get; set; }

        [NotMapped]
        public DateOnly GroupDateTo { get; set; }

        public int LoanEligibleAmountId { get; set; }
        [ForeignKey("LoanEligibleAmountId")]
        public LoanEligibilityModel LoanEligibility { get; set; }



    }
}
