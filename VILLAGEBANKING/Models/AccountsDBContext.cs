using Microsoft.EntityFrameworkCore;

namespace CRUDApp.Models
{
    public class AccountsDBContext : DbContext
    {
        public AccountsDBContext(DbContextOptions<AccountsDBContext> options) : base(options)
        {

        }
        public DbSet<AccountsModel> Accounts { get; set; }
    }
}
