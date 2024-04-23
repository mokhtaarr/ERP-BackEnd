using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrProgram
    {
        public SrProgram()
        {
            SrTripProgramJoins = new HashSet<SrTripProgramJoin>();
        }

        public int ProgramId { get; set; }
        public string? ProgramCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Days { get; set; }
        public string? Mtscruze { get; set; }
        /// <summary>
        /// single, double, Trible
        /// </summary>
        public byte? Number { get; set; }
        public string? Remark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrTripProgramJoin> SrTripProgramJoins { get; set; }
    }
}
