using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class GroupModel
    {
        [Key]
        public int GroupId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GroupName { get; set; }

        public double MinimumContributionAmount { get; set; }

        public DateOnly ContributionWindowDateFrom { get; set; }
        public DateOnly ContributionWindowDateTo { get; set; }

        public int FrequencyOfContributions { get; set; }

        public double LoanRate { get; set; }

        public double PenaltyFee { get; set; }
        
        public double ProvisionalInterest { get; set; }
       
        public DateOnly GroupDateFrom { get; set; }

        public DateOnly GroupDateTo { get; set; }

        public int LoanEligibleAmountId { get; set; }
        [ForeignKey("LoanEligibleAmountId")]
        public LoanEligibilityModel LoanEligibility { get; set; }



    }
}
