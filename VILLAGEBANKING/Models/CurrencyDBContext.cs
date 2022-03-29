using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models
{
    public class CurrencyDBContext : DbContext
    {
        public CurrencyDBContext(DbContextOptions<CurrencyDBContext> options) : base(options)
        {

        }

        public DbSet<CurrencyExchangeModel> Currency { get; set; }
    }
}
