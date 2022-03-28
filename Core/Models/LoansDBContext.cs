using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    public class LoansDBContext : DbContext
    {
        public LoansDBContext(DbContextOptions<LoansDBContext> options) : base(options)
        {

        }
        public DbSet<LoansModel>  Loans { get; set; }

    }
}
