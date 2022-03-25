using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    internal class GroupMembersModel
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public GroupModel Group { get; set; }

        public int GroupMemberId { get; set; }
        [ForeignKey("GroupMemberId")]
        public IdentityUser Member { get; set; }

        public string GroupMembershipStatus { get; set; }


    }
}
