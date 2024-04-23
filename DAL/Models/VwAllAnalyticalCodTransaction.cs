using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAllAnalyticalCodTransaction
    {
        public int Aid { get; set; }
        public int? ParentAid { get; set; }
        public int? CodeLevel { get; set; }
        public byte? CodeLevelType { get; set; }
        public string Code { get; set; } = null!;
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public bool? Stopped { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? AddField8 { get; set; }
        public string? AddField9 { get; set; }
        public string? AddField10 { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public long? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public string? AccountNameE { get; set; }
        public int? CostCenterCode { get; set; }
        public string? CostCenterNameA { get; set; }
        public string? CostCenterNameE { get; set; }
        public string? DocTrNo { get; set; }
        public string DocType { get; set; } = null!;
        public string DocTypeName1 { get; set; } = null!;
        public string DocTypeName2 { get; set; } = null!;
        public DateTime? TrDate { get; set; }
        public int? ManualTrNo { get; set; }
        public string? DocRemarks { get; set; }
        public decimal? OpenBalancDepCostCentr { get; set; }
        public decimal? OpenBalancCredCostCentr { get; set; }
        public decimal? DebitLocal { get; set; }
        public decimal? CreditLocal { get; set; }
        public decimal? OpenBalancDepCrncyCostCentr { get; set; }
        public decimal? OpenBalancCredCrncyCostCentr { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public decimal? Rate { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public bool? DefualtCurrency { get; set; }
        public string? CurrencySymbol { get; set; }
        public decimal? DocValue { get; set; }
        public int? DetailedTableEntityId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
    }
}
