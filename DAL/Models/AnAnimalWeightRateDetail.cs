using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnAnimalWeightRateDetail
    {
        public int AnWeightRateDetailId { get; set; }
        public int? AnWeightRateId { get; set; }
        public int? AnTypeId { get; set; }
        public int? AnimalItemCardId { get; set; }
        public int? FoodItemCardId { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }
        public decimal? FromWeight { get; set; }
        public decimal? ToWeight { get; set; }
        public decimal? WeightRateFrom { get; set; }
        public decimal? WeightRateTo { get; set; }
        public decimal? MinWeightPrcnt { get; set; }

        public virtual AnAnimalWeightRate? AnWeightRate { get; set; }
    }
}
