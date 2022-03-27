using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Comment : BaseEntity
    {
        public int? CommentingId { get; set; }
        public string CText { get; set; }
        public int? Liked { get; set; } = 0;
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public Comment Commenting { get; set; }
    }
}
