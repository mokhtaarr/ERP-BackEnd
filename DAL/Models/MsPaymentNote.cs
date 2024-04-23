using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPaymentNote
    {
        public MsPaymentNote()
        {
            MsCashTransactionDetails = new HashSet<MsCashTransactionDetail>();
            MsPaymentNoteCurrencies = new HashSet<MsPaymentNoteCurrency>();
            MsPaymentNoteItems = new HashSet<MsPaymentNoteItem>();
            MsPettyPaymentJoins = new HashSet<MsPettyPaymentJoin>();
            SrVehicleRentPayJoins = new HashSet<SrVehicleRentPayJoin>();
        }

        public int PayId { get; set; }
        public int? PurInvId { get; set; }
        public int? RetSaleId { get; set; }
        public int? BoxId { get; set; }
        public int? CurrencyId { get; set; }
        public int? VendorId { get; set; }
        public int? StoreId { get; set; }
        public int? EmpId { get; set; }
        public int? CustodyEmpId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? ChequeOpenId { get; set; }
        public int? ExpensesId { get; set; }
        public int? BankNoticId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TripId { get; set; }
        public string? DbtableName { get; set; }
        public int? DbtableId { get; set; }
        public string? AccountTableName { get; set; }
        public int? AccountId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        /// <summary>
        /// 0  Cash ; 1  Check
        /// </summary>
        public byte? TranType { get; set; }
        /// <summary>
        ///  1  Customer ; 2 vendor ; 3  Other
        /// </summary>
        public byte? RectSourceType { get; set; }
        public string? OtherSource { get; set; }
        public decimal? Rate { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? ValueBeforeRate { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value1BeforeRate { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value2BeforeRate { get; set; }
        public decimal? Value3 { get; set; }
        public decimal? Value3BeforeRate { get; set; }
        public decimal? Value4 { get; set; }
        public decimal? Value4BeforeRate { get; set; }
        public decimal? Value5 { get; set; }
        public decimal? Value5BeforeRate { get; set; }
        public decimal? Value6 { get; set; }
        public decimal? Value6BeforeRate { get; set; }
        public decimal? Value7 { get; set; }
        public decimal? Value7BeforeRate { get; set; }
        public decimal? Value8 { get; set; }
        public decimal? Value8BeforeRate { get; set; }
        public decimal? Value9 { get; set; }
        public decimal? Value9BeforeRate { get; set; }
        public decimal? Value10 { get; set; }
        public decimal? Value10BeforeRate { get; set; }
        public string? Equation { get; set; }
        public string? CheckNumber { get; set; }
        public string? BankAccNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        /// <summary>
        /// 0 Paid ; 1 Back ; 2  Transfer;
        /// </summary>
        public byte? CheckType { get; set; }
        public string? StrCustm1 { get; set; }
        public string? StrCustm2 { get; set; }
        public string? Remarks { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public bool? IsPrinted { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? IsPettyCash { get; set; }
        public int? CheqBookId { get; set; }
        public int? NoteNum { get; set; }
        public bool? IsKembiala { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public decimal? TotalInvoices { get; set; }
        public decimal? NotPaidInvoices { get; set; }
        public decimal? DifferenceInvoices { get; set; }
        public decimal? ResourceBalance { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        public decimal? NotPaid { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public decimal? TotalItems { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? RectId { get; set; }
        public int? ShiftId { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsRemoteEntity { get; set; }
        public int? RemotId { get; set; }
        public int? MainVendServerId { get; set; }
        public int? PayMethodId { get; set; }
        public decimal? PayMethodPercent { get; set; }
        public decimal? PayMethodValue { get; set; }
        public string? PayMethodDatafield { get; set; }
        public int? PayMethodId2 { get; set; }
        public decimal? PayMethodPercent2 { get; set; }
        public decimal? PayMethodValue2 { get; set; }
        public string? PayMethodDatafield2 { get; set; }
        public int? PayMethodId3 { get; set; }
        public decimal? PayMethodPercent3 { get; set; }
        public decimal? PayMethodValue3 { get; set; }
        public string? PayMethodDatafield3 { get; set; }

        public virtual MsBoxBank? Box { get; set; }
        public virtual MsPurchasInvoice? PurInv { get; set; }
        public virtual MsReturnSale? RetSale { get; set; }
        public virtual ICollection<MsCashTransactionDetail> MsCashTransactionDetails { get; set; }
        public virtual ICollection<MsPaymentNoteCurrency> MsPaymentNoteCurrencies { get; set; }
        public virtual ICollection<MsPaymentNoteItem> MsPaymentNoteItems { get; set; }
        public virtual ICollection<MsPettyPaymentJoin> MsPettyPaymentJoins { get; set; }
        public virtual ICollection<SrVehicleRentPayJoin> SrVehicleRentPayJoins { get; set; }
    }
}
