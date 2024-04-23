using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnAnimalMidicin
    {
        public int AnAnimalMidicinId { get; set; }
        public int AnMidicinId { get; set; }
        public int? AnTypeId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? Shots { get; set; }
        /// <summary>
        /// Days
        /// </summary>
        public int? AnimalAge { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? NextNotify { get; set; }

        public virtual AnMedicin AnMidicin { get; set; } = null!;
        public virtual AnAnimalType? AnType { get; set; }
    }
}
