using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApp.Models
{
    public class LoansModel
    {
        [Key]
        public int LoanId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Display(Name ="Account Name")]
        public string AccountName { get; set; }

        [Column(TypeName = "nvarchar(100)")]

        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LoanInterestRate { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LoanPrincipal { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LoanBalance { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LoanPayementPeriod { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LoanInstallmentStartDate { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LoanInstallmentEndDate { get; set; }

        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public AccountsModel Account { get; set; }


    }
}
