using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnAnimalType
    {
        public AnAnimalType()
        {
            AnAnimalMidicins = new HashSet<AnAnimalMidicin>();
        }

        public int AnTypeId { get; set; }
        public string Code { get; set; } = null!;
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? ParentAnTypeId { get; set; }
        public byte? AnTypeType { get; set; }
        public int? AnTypeLevel { get; set; }
        public byte[]? AnTypeImage { get; set; }
        public int? CurrentTrNo { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<AnAnimalMidicin> AnAnimalMidicins { get; set; }
    }
}
