using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoComment
{
    public class CommentUpdateDto:BaseDto
    {
        public int CommentingId { get; set; }
        public string CText { get; set; }
        public int Liked { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
