using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LaPropSerial
    {
        public int PropId { get; set; }
        public int? CustMain { get; set; }
        public int? CustProp { get; set; }
        public int? LandId { get; set; }

        public virtual MsCustomer? CustMainNavigation { get; set; }
    }
}
