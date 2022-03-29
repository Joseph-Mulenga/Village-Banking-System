using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models
{
    public class TransactionDBContext:DbContext
    {
        public TransactionDBContext(DbContextOptions<TransactionDBContext> options):base(options)
        {

        }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
