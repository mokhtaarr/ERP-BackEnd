using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrShift
    {
        public HrShift()
        {
            HrEmployees = new HashSet<HrEmployee>();
        }

        public int ShiftId { get; set; }
        public string? ShiftCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Day1Name1 { get; set; }
        public string? Day1Name2 { get; set; }
        public string? Day2Name1 { get; set; }
        public string? Day2Name2 { get; set; }
        public string? Day3Name1 { get; set; }
        public string? Day3Name2 { get; set; }
        public string? Day4Name1 { get; set; }
        public string? Day4Name2 { get; set; }
        public string? Day5Name1 { get; set; }
        public string? Day5Name2 { get; set; }
        public string? Day6Name1 { get; set; }
        public string? Day6Name2 { get; set; }
        public string? Day7Name1 { get; set; }
        public string? Day7Name2 { get; set; }
        public bool? Day1Type { get; set; }
        public bool? Day2Type { get; set; }
        public bool? Day3Type { get; set; }
        public bool? Day4Type { get; set; }
        public bool? Day5Type { get; set; }
        public bool? Day6Type { get; set; }
        public bool? Day7Type { get; set; }
        public DateTime? FirstShfDay1tFrom { get; set; }
        public DateTime? FirstShftDay1To { get; set; }
        public DateTime? FirstShftDay2From { get; set; }
        public DateTime? FirstShftDay2To { get; set; }
        public DateTime? FirstShftDay3From { get; set; }
        public DateTime? FirstShftDay3To { get; set; }
        public DateTime? FirstShftDay4From { get; set; }
        public DateTime? FirstShftDay4To { get; set; }
        public DateTime? FirstShftDay5From { get; set; }
        public DateTime? FirstShftDay5To { get; set; }
        public DateTime? FirstShftDay6From { get; set; }
        public DateTime? FirstShftDay6To { get; set; }
        public DateTime? FirstShftDay7From { get; set; }
        public DateTime? FirstShftDay7To { get; set; }
        public DateTime? SecondShftDay1From { get; set; }
        public DateTime? SecondShftDay1To { get; set; }
        public DateTime? SecondShftDay2From { get; set; }
        public DateTime? SecondShftDay2To { get; set; }
        public DateTime? SecondShftDay3From { get; set; }
        public DateTime? SecondShftDay3To { get; set; }
        public DateTime? SecondShftDay4From { get; set; }
        public DateTime? SecondShftDay4To { get; set; }
        public DateTime? SecondShftDay5From { get; set; }
        public DateTime? SecondShftDay5To { get; set; }
        public DateTime? SecondShftDay6From { get; set; }
        public DateTime? SecondShftDay6To { get; set; }
        public DateTime? SecondShftDay7From { get; set; }
        public DateTime? SecondShftDay7To { get; set; }
        public DateTime? ThirdShftDay1From { get; set; }
        public DateTime? ThirdShftDay1To { get; set; }
        public DateTime? ThirdShftDay2From { get; set; }
        public DateTime? ThirdShftDay2To { get; set; }
        public DateTime? ThirdShftDay3From { get; set; }
        public DateTime? ThirdShftDay3To { get; set; }
        public DateTime? ThirdShftDay4From { get; set; }
        public DateTime? ThirdShftDay4To { get; set; }
        public DateTime? ThirdShftDay5From { get; set; }
        public DateTime? ThirdShftDay5To { get; set; }
        public DateTime? ThirdShftDay6From { get; set; }
        public DateTime? ThirdShftDay6To { get; set; }
        public DateTime? ThirdShftDay7From { get; set; }
        public DateTime? ThirdShftDay7To { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
    }
}
