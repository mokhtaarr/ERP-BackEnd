using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalAccountClaasiJoin
    {
        public int AcChrtJoinClaasi { get; set; }
        public int? AccountId { get; set; }
        public int? AccountClassId { get; set; }
        public byte? Operator { get; set; }
        public int? DaysCount { get; set; }
        public byte? TypeOfAcc { get; set; }

        public virtual CalAccountChart? Account { get; set; }
    }
}
