using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsReturnSale
    {
        public MsReturnSale()
        {
            MsPaymentNotes = new HashSet<MsPaymentNote>();
            MsReturnSalesCurrencies = new HashSet<MsReturnSalesCurrency>();
            MsReturnSalesExpenses = new HashSet<MsReturnSalesExpense>();
            MsReturnSalesItemCards = new HashSet<MsReturnSalesItemCard>();
            MsReturnSalesMultiAccounts = new HashSet<MsReturnSalesMultiAccount>();
        }

        public int RetSaleId { get; set; }
        public int? InvId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? CustBranchId { get; set; }
        public int? EmpId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? PayMethodId { get; set; }
        public decimal? PayMethodPercent { get; set; }
        public decimal? PayMethodValue { get; set; }
        public int? TaxesId1 { get; set; }
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        public decimal? TaxValue3 { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Rate { get; set; }
        public string? RetDescA { get; set; }
        public string? RetDescE { get; set; }
        public string? Remarks { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        /// <summary>
        /// 0 Cash ; 1 Due ; Customer Account
        /// </summary>
        public byte? InvoiceType { get; set; }
        /// <summary>
        /// 0  Invoice ; 1  Customer
        /// </summary>
        public byte? ReturnType { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? TotalItemTax1 { get; set; }
        public decimal? TotalItemTax2 { get; set; }
        public decimal? TotalItemTax3 { get; set; }
        public decimal? TotalTaxValu { get; set; }
        public decimal? RetTotal { get; set; }
        public decimal? TotalItemsCost { get; set; }
        public decimal? TotalItemsProfit { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? PaidPriceVisa { get; set; }
        public decimal? DiscPercent { get; set; }
        public decimal? DiscAmount { get; set; }
        public decimal? DiscPercent2 { get; set; }
        public decimal? DiscAmount2 { get; set; }
        public decimal? DiscPercent3 { get; set; }
        public decimal? DiscAmount3 { get; set; }
        public decimal? DiscPercent4 { get; set; }
        public decimal? DiscAmount4 { get; set; }
        public decimal? PriceAfterTax { get; set; }
        public decimal? Commision { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsDelivered { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        public decimal? NotPaid { get; set; }
        public bool? IsPos { get; set; }
        public int? ShiftId { get; set; }
        public bool? IsShippingInv { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
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
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public bool? EtaxSent { get; set; }
        public DateTime? EtaxSentTime { get; set; }
        public string? EtaxRemarks { get; set; }
        public string? EtaxReference { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsRemoteEntity { get; set; }
        public int? RemotId { get; set; }
        public int? MainCustServerId { get; set; }
        public decimal? BankTransfer { get; set; }
        public string? PayMethodDatafield { get; set; }
        public int? PayMethodId2 { get; set; }
        public decimal? PayMethodPercent2 { get; set; }
        public decimal? PayMethodValue2 { get; set; }
        public string? PayMethodDatafield2 { get; set; }
        public int? PayMethodId3 { get; set; }
        public decimal? PayMethodPercent3 { get; set; }
        public decimal? PayMethodValue3 { get; set; }
        public string? PayMethodDatafield3 { get; set; }
        public decimal? TotalServicePrice { get; set; }
        public decimal? TotalProfitPrice { get; set; }
        public int? VisaPayMethodId { get; set; }
        public int? BankTranPayMethodId { get; set; }
        public int? OtherPayMethodId2 { get; set; }

        public virtual ICollection<MsPaymentNote> MsPaymentNotes { get; set; }
        public virtual ICollection<MsReturnSalesCurrency> MsReturnSalesCurrencies { get; set; }
        public virtual ICollection<MsReturnSalesExpense> MsReturnSalesExpenses { get; set; }
        public virtual ICollection<MsReturnSalesItemCard> MsReturnSalesItemCards { get; set; }
        public virtual ICollection<MsReturnSalesMultiAccount> MsReturnSalesMultiAccounts { get; set; }
    }
}
