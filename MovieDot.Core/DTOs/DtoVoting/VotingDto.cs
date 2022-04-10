using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoVoting
{
    public class VotingDto:BaseDto
    {
        public int Vote { get; set; }
        public int UserId { get; set; }
    }
}
