using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class GUsersDto
    {
        public int? UserId { get; set; }
        public int? EmpId { get; set; }
        public int? UserGroupId { get; set; }
        public int? UserRoleId { get; set; }
        public bool? IsActive { get; set; }
        public string? UserCode { get; set; }
        public int? StoreId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public byte? UserType { get; set; }
    }
}
