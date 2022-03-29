using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VILLAGEBANKING.Models
{
    public class AccountsModel
    {
        [Key]
        public int AccountId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
