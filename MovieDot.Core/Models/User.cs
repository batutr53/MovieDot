using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; } = true;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
