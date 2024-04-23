using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnMedicin
    {
        public AnMedicin()
        {
            AnAnimalMidicins = new HashSet<AnAnimalMidicin>();
        }

        public int AnMidicinId { get; set; }
        public int Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? Shots { get; set; }
        /// <summary>
        /// Days
        /// </summary>
        public int? AnimalAge { get; set; }
        public decimal? Weight { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }

        public virtual ICollection<AnAnimalMidicin> AnAnimalMidicins { get; set; }
    }
}
