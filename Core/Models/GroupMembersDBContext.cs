using Microsoft.EntityFrameworkCore;

namespace Core.Models
{
    public class GroupMembersDBContext : DbContext
    {
            public GroupMembersDBContext(DbContextOptions<GroupMembersDBContext> options) : base(options)
            {

            }
            public DbSet<GroupMembersModel> Members { get; set; }

        }
}
