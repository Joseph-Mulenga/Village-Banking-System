using Microsoft.EntityFrameworkCore;

namespace VILLAGEBANKING.Models
{
    public class GroupMembersDBContext : DbContext
    {
            public GroupMembersDBContext(DbContextOptions<GroupMembersDBContext> options) : base(options)
            {

            }
            public DbSet<GroupMembersModel> Members { get; set; }

        }
}
