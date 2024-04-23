using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsBusinessPartnerType
    {
        public MsBusinessPartnerType()
        {
            MsBusinessPartners = new HashSet<MsBusinessPartner>();
        }

        public int BsPartnerTypeId { get; set; }
        public string PartnerTypeCode { get; set; } = null!;
        public string? PartnerTypeDescA { get; set; }
        public string? PartnerTypeDescE { get; set; }
        public int? PartnerTypeParent { get; set; }
        public int? PartnerTypeLevel { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<MsBusinessPartner> MsBusinessPartners { get; set; }
    }
}
