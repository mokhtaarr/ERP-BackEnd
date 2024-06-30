using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CalAccountUsersDto
    {
        public int? AccUserId { get; set; }
        public int? AccountId { get; set; }
        public int? UserId { get; set; }
        public int? ApprovedBy { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
    }
}
