using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    internal class GroupDBContext : DbContext
    {
        public GroupDBContext(DbContextOptions<GroupDBContext> options) : base(options)
        {

        }
        public DbSet<GroupModel> Group { get; set; }

    }
  
}
