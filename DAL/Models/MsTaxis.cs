using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsTaxis
    {
        public MsTaxis()
        {
            MsPurchasInvoices = new HashSet<MsPurchasInvoice>();
        }

        public int TaxesId { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxNameA { get; set; }
        public string? TaxNameE { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? TaxStyle { get; set; }
        public decimal? TaxRate { get; set; }
        public string? Remarks { get; set; }
        public int? AccountId { get; set; }
        public bool? IsAccomulative { get; set; }
        public bool? PlusOrMinus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? EtaxCode { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<MsPurchasInvoice> MsPurchasInvoices { get; set; }
    }
}
