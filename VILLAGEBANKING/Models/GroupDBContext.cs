using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models
{
    public class GroupDBContext : DbContext
    {
        public GroupDBContext(DbContextOptions<GroupDBContext> options) : base(options)
        {

        }
        public DbSet<GroupModel> Group { get; set; }

    }
  
}
