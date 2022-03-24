using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApp.Models
{
    public class CurrencyExchangeModel
    {
        [Key]
        public int CurrencyId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CurrencyName { get; set; }
        public decimal Price { get; set; }
    }
}
