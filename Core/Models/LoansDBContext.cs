using Microsoft.EntityFrameworkCore;

namespace CRUDApp.Models
{
    public class LoansDBContext : DbContext
    {
        public LoansDBContext(DbContextOptions<LoansDBContext> options) : base(options)
        {

        }
        public DbSet<LoansModel>  Loans { get; set; }

    }
}
