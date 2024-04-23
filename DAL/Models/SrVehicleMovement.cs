using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleMovement
    {
        public SrVehicleMovement()
        {
            SrVehicleMovementDetails = new HashSet<SrVehicleMovementDetail>();
        }

        public int VehiclMovId { get; set; }
        public int? VendorId { get; set; }
        public int? StorId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? Aid { get; set; }
        public int? FinancialIntervalsId { get; set; }
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
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public decimal? Rate { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? NetTime { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? Remarks { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
        public int? TaxesId1 { get; set; }
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        public decimal? TaxValue3 { get; set; }
        public decimal? TotalItemTax1 { get; set; }
        public decimal? TotalItemTax2 { get; set; }
        public decimal? TotalItemTax3 { get; set; }
        public decimal? TotalExpensesTaxes1 { get; set; }
        public decimal? TotalExpensesTaxes2 { get; set; }
        public decimal? TotalExpensesTaxes3 { get; set; }
        public decimal? TotalTaxValu { get; set; }
        public DateTime? InvDueDate { get; set; }
        public decimal? DiscPercent { get; set; }
        public decimal? DiscAmount { get; set; }
        public decimal? DiscPercent2 { get; set; }
        public decimal? DiscAmount2 { get; set; }
        public decimal? DiscPercent3 { get; set; }
        public decimal? DiscAmount3 { get; set; }
        public decimal? DiscPercent4 { get; set; }
        public decimal? DiscAmount4 { get; set; }
        public decimal? PriceAfterTax { get; set; }
        public decimal? ExpenValue { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? PaidPriceVisa { get; set; }
        public decimal? BankTransfer { get; set; }
        public decimal? NetPriceBeforCurr { get; set; }
        public decimal? ExpenValueBeforCurr { get; set; }
        public decimal? ExpenValueWithCurr { get; set; }
        public decimal? AdvancExpenseWithCurr { get; set; }
        public decimal? AdvancExpenseBeforCurr { get; set; }

        public virtual ICollection<SrVehicleMovementDetail> SrVehicleMovementDetails { get; set; }
    }
}
