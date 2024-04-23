using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjectItemsJoin
    {
        public ProjProjectItemsJoin()
        {
            ProjProjectItemEmpJoins = new HashSet<ProjProjectItemEmpJoin>();
        }

        public int ProjItemsJoinId { get; set; }
        public int? ProjectItemsId { get; set; }
        public int? ProjectId { get; set; }
        public decimal? ExpectItemPercent { get; set; }
        public decimal? ExpectItemValue { get; set; }
        public decimal? ActualItemPercentExpense { get; set; }
        public decimal? ActualItemExpenseValue { get; set; }
        public decimal? FinishPercent { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual ProjProject? Project { get; set; }
        public virtual ProjProjectItem? ProjectItems { get; set; }
        public virtual ICollection<ProjProjectItemEmpJoin> ProjProjectItemEmpJoins { get; set; }
    }
}
