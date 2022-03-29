using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models;
    public class LoansDBContext : DbContext
    {
        public LoansDBContext(DbContextOptions<LoansDBContext> options) : base(options)
        {

        }
        public DbSet<LoansModel>  Loans { get; set; }

    }

