using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class LoanEligibilityModel
    {
        [Key]
        public int LoanEligibleAmountId { get; set; }
        public int AmountContribution { get; set; }
        public int EligibleLoanAmount { get; set; }

    }
}
