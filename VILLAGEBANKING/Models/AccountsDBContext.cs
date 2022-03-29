using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models
{
    public class AccountsDBContext : DbContext
    {
        public AccountsDBContext(DbContextOptions<AccountsDBContext> options) : base(options)
        {

        }
        public DbSet<AccountsModel> Accounts { get; set; }
    }
}
