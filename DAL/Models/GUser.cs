using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GUser
    {
        public GUser()
        {
            CalAccountUsers = new HashSet<CalAccountUser>();
            GUserModules = new HashSet<GUserModule>();
            MsBoxUsers = new HashSet<MsBoxUser>();
            MsCusromerUsers = new HashSet<MsCusromerUser>();
            MsVendorUsers = new HashSet<MsVendorUser>();
        }

        public int UserId { get; set; }
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
        /// <summary>
        /// 0 User , 1 superUser , 2 admin
        /// </summary>
        public byte? UserType { get; set; }
        public string? Custom1 { get; set; }
        public string? Custom2 { get; set; }
        public string? Custom3 { get; set; }
        public string? Custom4 { get; set; }
        public string? Custom5 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
        public int? SalesDepId { get; set; }

        public virtual GUserRole? UserRole { get; set; }
        public virtual ICollection<CalAccountUser> CalAccountUsers { get; set; }
        public virtual ICollection<GUserModule> GUserModules { get; set; }
        public virtual ICollection<MsBoxUser> MsBoxUsers { get; set; }
        public virtual ICollection<MsCusromerUser> MsCusromerUsers { get; set; }
        public virtual ICollection<MsVendorUser> MsVendorUsers { get; set; }
    }
}
