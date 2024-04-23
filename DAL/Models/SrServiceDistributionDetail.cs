using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrServiceDistributionDetail
    {
        public int SerDistDetailId { get; set; }
        public int? SerDistId { get; set; }
        public int? SerReqId { get; set; }
        public int? JobOrderId { get; set; }
        public int? EmpId { get; set; }
        public int? EmpId1 { get; set; }
        public int? EmpId2 { get; set; }
        public int? EmpId3 { get; set; }
        public int? EmpId4 { get; set; }
        public int? EmpId5 { get; set; }
        public int? EmpId6 { get; set; }
        public int? EmpId7 { get; set; }
        public int? EmpId8 { get; set; }
        public int? EmpId9 { get; set; }
        public int? EmpId10 { get; set; }
        public int? EmpId11 { get; set; }
        public int? EmpId12 { get; set; }
        public int? EmpId13 { get; set; }
        public int? EmpId14 { get; set; }
        public int? EmpId15 { get; set; }
        public DateTime? EstimateStartTime { get; set; }
        public DateTime? RealStartTime { get; set; }
        public DateTime? EstimateEndTime { get; set; }
        public DateTime? RealEndTime { get; set; }
        public int? CityId { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? AddField8 { get; set; }
        public string? AddField9 { get; set; }
        public string? AddField10 { get; set; }

        public virtual SrServiceDistribution? SerDist { get; set; }
    }
}
