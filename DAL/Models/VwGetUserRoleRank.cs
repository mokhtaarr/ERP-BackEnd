using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetUserRoleRank
    {
        public long? RowRank { get; set; }
        public int UserRoleId { get; set; }
        public string? RoleCode { get; set; }
    }
}
