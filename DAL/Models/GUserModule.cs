using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GUserModule
    {
        public int UserModuleId { get; set; }
        public int UserId { get; set; }
        public string ModuleCode { get; set; } = null!;
        public string? ModuleDescA { get; set; }
        public bool CanOpen { get; set; }
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanPrint { get; set; }
        public bool CanPreView { get; set; }
        public bool CanPost { get; set; }
        public byte? PrintCopies { get; set; }
        public bool? PrintWithSave { get; set; }
        public string? DefaultReport { get; set; }
        public bool Custom1 { get; set; }

        public virtual GUser User { get; set; } = null!;
    }
}
