using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrDriver
    {
        public SrDriver()
        {
            SrVehicleJobOrderDetails = new HashSet<SrVehicleJobOrderDetail>();
        }

        public int DriverId { get; set; }
        public int? TrafficLineId { get; set; }
        public string? DriverCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? EmpId { get; set; }
        public string? Id { get; set; }
        public string? PassPort { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? DriverLicense { get; set; }
        public string? LicenseDescription { get; set; }
        public DateTime? LicenseIssueDate { get; set; }
        public DateTime? LicenseRenewalDate { get; set; }
        public string? LicenseLegalPlace { get; set; }
        public string? Remark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrVehicleJobOrderDetail> SrVehicleJobOrderDetails { get; set; }
    }
}
