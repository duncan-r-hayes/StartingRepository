using Microsoft.AspNetCore.Identity;
using ProcessAudit2.Models;
using System.Collections.Generic;

namespace ProcessAudit2.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}