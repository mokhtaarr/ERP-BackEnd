using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjectItemEmpJoin
    {
        public ProjProjectItemEmpJoin()
        {
            ProjProjItemEmpTaskJoins = new HashSet<ProjProjItemEmpTaskJoin>();
        }

        public int ProjItemEmpId { get; set; }
        public int? ProjItemsJoinId { get; set; }
        public int? EmpId { get; set; }

        public virtual HrEmployee? Emp { get; set; }
        public virtual ProjProjectItemsJoin? ProjItemsJoin { get; set; }
        public virtual ICollection<ProjProjItemEmpTaskJoin> ProjProjItemEmpTaskJoins { get; set; }
    }
}
