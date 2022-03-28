using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    public class CurrencyDBContext : DbContext
    {
        public CurrencyDBContext(DbContextOptions<CurrencyDBContext> options) : base(options)
        {

        }

        public DbSet<CurrencyExchangeModel> Currency { get; set; }
    }
}
