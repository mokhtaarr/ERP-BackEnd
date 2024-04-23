using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSyssettinge
    {
        public int Id { get; set; }
        public int? Countitertaion { get; set; }
        public int? Rolid { get; set; }
        public int? Modetype { get; set; }
        public int? Modetypeout { get; set; }
        public int? Statusmodout { get; set; }
        public int? Statusmodin { get; set; }
        public int? Idgenralsetting { get; set; }
        public int? Countitertaionout { get; set; }
    }
}
