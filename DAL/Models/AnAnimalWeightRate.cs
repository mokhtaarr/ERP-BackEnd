using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnAnimalWeightRate
    {
        public AnAnimalWeightRate()
        {
            AnAnimalWeightRateDetails = new HashSet<AnAnimalWeightRateDetail>();
        }

        public int AnWeightRateId { get; set; }
        public string? Code { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public byte? DailyMeals { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }

        public virtual ICollection<AnAnimalWeightRateDetail> AnAnimalWeightRateDetails { get; set; }
    }
}
