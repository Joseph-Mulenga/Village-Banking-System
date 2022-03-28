using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    public class GroupMembersModel
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public GroupModel Group { get; set; }

        public string GroupMemberId { get; set; }
        [ForeignKey("GroupMemberId")]
        public IdentityUser Member { get; set; }

        public string GroupMembershipStatus { get; set; }


    }
}
