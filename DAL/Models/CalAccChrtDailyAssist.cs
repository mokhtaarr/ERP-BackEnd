using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalAccChrtDailyAssist
    {
        public int AccChrtDailyAssistId { get; set; }
        public int? AccountId { get; set; }
        public int? DailyAssisId { get; set; }

        public virtual CalAccountChart? Account { get; set; }
    }
}
