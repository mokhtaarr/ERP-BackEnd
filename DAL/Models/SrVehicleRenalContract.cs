using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleRenalContract
    {
        public SrVehicleRenalContract()
        {
            SrVehicleRentPayJoins = new HashSet<SrVehicleRentPayJoin>();
            SrVehicleRentPurchJoins = new HashSet<SrVehicleRentPurchJoin>();
            SrVehicleRentRecJoins = new HashSet<SrVehicleRentRecJoin>();
            SrVehicleRentSalesInvJoins = new HashSet<SrVehicleRentSalesInvJoin>();
        }

        public int VrentContractId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        /// <summary>
        /// ItemCardId
        /// </summary>
        public int? VehicleId { get; set; }
        public int? Aid { get; set; }
        public int? DriverId1 { get; set; }
        public int? DriverId2 { get; set; }
        public int? DriverId3 { get; set; }
        public int? CustomerId { get; set; }
        public int? HotelId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? ExpectedStartDate { get; set; }
        public DateTime? RealStartDate { get; set; }
        public DateTime? GetOutDate { get; set; }
        public byte? PaymentMethod { get; set; }
        public string? HotelRoom { get; set; }
        public long? StartCounter { get; set; }
        public long? EndCounter { get; set; }
        public long? ConsumedCounter { get; set; }
        public long? AllowanceCounter { get; set; }
        public long? ExtraCounter { get; set; }
        public long? DailyCounter { get; set; }
        public decimal? FuelIn { get; set; }
        public decimal? FuelOut { get; set; }
        public string? VisaNo { get; set; }
        public string? Type { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public string? VisaCode { get; set; }
        public decimal? VisaAmount { get; set; }
        public bool? VisaApproved { get; set; }
        public decimal? InsuranceValue { get; set; }
        public decimal? InsuranceValue2 { get; set; }
        public int? ContractDays { get; set; }
        public decimal? DayPrice { get; set; }
        public decimal? InvTotal { get; set; }
        public decimal? DeliveryCost { get; set; }
        public decimal? DriverCost { get; set; }
        public decimal? FuelCost { get; set; }
        public decimal? MaintenanceCost { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? NetDue { get; set; }
        public decimal? Repaid { get; set; }
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
        public decimal? Commision { get; set; }
        public decimal? Rate { get; set; }
        public decimal? NetPriceBeforCurr { get; set; }
        public decimal? ExpenValueBeforCurr { get; set; }
        public decimal? ExpenValueWithCurr { get; set; }
        public decimal? NotPaid { get; set; }
        public bool? IsPaid { get; set; }
        public decimal? TotalPurchInv { get; set; }
        public decimal? TotalPayment { get; set; }
        public decimal? TotalPaidReciept { get; set; }
        public decimal? TotalSalesInv { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalCostBeforeCurr { get; set; }
        public decimal? Profit { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Email2 { get; set; }
        public string? Email3 { get; set; }
        public string? Email4 { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Tel5 { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
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
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<SrVehicleRentPayJoin> SrVehicleRentPayJoins { get; set; }
        public virtual ICollection<SrVehicleRentPurchJoin> SrVehicleRentPurchJoins { get; set; }
        public virtual ICollection<SrVehicleRentRecJoin> SrVehicleRentRecJoins { get; set; }
        public virtual ICollection<SrVehicleRentSalesInvJoin> SrVehicleRentSalesInvJoins { get; set; }
    }
}
