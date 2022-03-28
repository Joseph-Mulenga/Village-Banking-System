using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    internal class LoanEligibilityDBContext : DbContext
    {

        public LoanEligibilityDBContext(DbContextOptions<LoanEligibilityDBContext> options) : base(options)
        {

        }
        public DbSet<LoanEligibilityModel> Group { get; set; }

    }
}
