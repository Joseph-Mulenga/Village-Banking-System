using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models
{
    public class LoanEligibilityDBContext : DbContext
    {

        public LoanEligibilityDBContext(DbContextOptions<LoanEligibilityDBContext> options) : base(options)
        {

        }
        public DbSet<LoanEligibilityModel> Group { get; set; }

    }
}
