using System.ComponentModel.DataAnnotations;

namespace ProcessAudit2.Models
{
    public class User
    {
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}