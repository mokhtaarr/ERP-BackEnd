using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalJurnalEntry
    {
        public CalJurnalEntry()
        {
            CalJurnalDetails = new HashSet<CalJurnalDetail>();
            MsCashTransactionDetails = new HashSet<MsCashTransactionDetail>();
        }

        public int JurnalId { get; set; }
        public int? StorId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? AdjustId { get; set; }
        public int? BoxTranId { get; set; }
        public int? DeliverId { get; set; }
        public int? PurInvId { get; set; }
        public int? RectId { get; set; }
        public int? RetPurchId { get; set; }
        public int? RetSaleId { get; set; }
        public int? InvId { get; set; }
        public int? StockRecId { get; set; }
        public int? TranId { get; set; }
        public int? PayId { get; set; }
        public int? StockAdjustId { get; set; }
        public int? TrOpenningBalanceId { get; set; }
        public int? KeeperId { get; set; }
        public int? BankNoticId { get; set; }
        public int? PettycashId { get; set; }
        public int? PurOrderId { get; set; }
        public int? SalesOfferId { get; set; }
        public int? SalesOrderId { get; set; }
        public int? ReservId { get; set; }
        public int? SalaryIssuDocId { get; set; }
        public int? DeprDocId { get; set; }
        public int? AssetTerminatId { get; set; }
        public int? AssetAddId { get; set; }
        public int? AssetDeductId { get; set; }
        public int? DeliverAssetId { get; set; }
        public int? FixAssetId { get; set; }
        public int? AssetMovId { get; set; }
        public int? ReceiveAssetId { get; set; }
        public int? JorderEmpDocId { get; set; }
        public int? JorderEquipDocId { get; set; }
        public int? JorderClosId { get; set; }
        public int? LetOfGrnteeTranId { get; set; }
        public int? VjorderId { get; set; }
        public int? TranReqId { get; set; }
        public int? Aid { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? JurnalDesc { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalCredit { get; set; }
        public bool? IsOpenning { get; set; }
        public bool? IsManual { get; set; }
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
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? VehiclMovId { get; set; }
        public int? ShiftId { get; set; }
        public int? TenderContractId { get; set; }
        public int? ContractorContractId { get; set; }
        public int? ContractorExitractId { get; set; }
        public int? OwnerExitractId { get; set; }
        public int? ExecutExitractId { get; set; }

        public virtual SysAnalyticalCode? AidNavigation { get; set; }
        public virtual MsStore? Stor { get; set; }
        public virtual ICollection<CalJurnalDetail> CalJurnalDetails { get; set; }
        public virtual ICollection<MsCashTransactionDetail> MsCashTransactionDetails { get; set; }
    }
}
