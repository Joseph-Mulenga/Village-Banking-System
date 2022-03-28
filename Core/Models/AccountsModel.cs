using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class AccountsModel
    {
        [Key]
        public int AccountId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string AccountName { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AccountType { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BankBranchName { get; set; }

    }
}
