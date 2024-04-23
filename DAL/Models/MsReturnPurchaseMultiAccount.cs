using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsReturnPurchaseMultiAccount
    {
        public int RetPurMultiAccountId { get; set; }
        public int? RetPurchId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        public int? RectSourceTypeId { get; set; }
        public decimal? RectSourceBalance { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? CostCenterId4 { get; set; }
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public decimal? DebitLocal { get; set; }
        public decimal? CreditLocal { get; set; }
        public string? Remarks { get; set; }

        public virtual MsReturnPurchase? RetPurch { get; set; }
    }
}
