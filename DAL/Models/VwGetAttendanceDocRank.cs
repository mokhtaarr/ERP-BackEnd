using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetAttendanceDocRank
    {
        public long? RowRank { get; set; }
        public int AttendDocId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
