using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjUnitReservation
    {
        public ProjUnitReservation()
        {
            ProjProjUnitServices = new HashSet<ProjProjUnitService>();
            ProjReservInstallments = new HashSet<ProjReservInstallment>();
            ProjReserveUnitDocuments = new HashSet<ProjReserveUnitDocument>();
            ProjReserveUnitOwners = new HashSet<ProjReserveUnitOwner>();
            ProjReserveUnitSellers = new HashSet<ProjReserveUnitSeller>();
            ProjUnitReservationGuarantors = new HashSet<ProjUnitReservationGuarantor>();
        }

        public int ReservId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? InstallTempId { get; set; }
        public int? InstallId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsCustBalancInstall { get; set; }
        public decimal? CustomerBalace { get; set; }
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Rate { get; set; }
        public int? ContractTrNo { get; set; }
        public int? ContractBookId { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? PayStartDate { get; set; }
        public int? ProjUnitId { get; set; }
        public int? ProjectId { get; set; }
        public int? SalesEmpId { get; set; }
        public decimal? UnitMeterPrice { get; set; }
        public decimal? UnitArea { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? PaidInCash { get; set; }
        public decimal? ActualSalesPrice { get; set; }
        public decimal? TotalInstallments { get; set; }
        public decimal? NotPaidInstallments { get; set; }
        public decimal? CommissionPercent { get; set; }
        public decimal? CommissionValue { get; set; }
        public decimal? LeavePercent { get; set; }
        public decimal? LeaveValue { get; set; }
        public decimal? FeesPercent { get; set; }
        public decimal? FeesValue { get; set; }
        public decimal? FinishMeterPrice { get; set; }
        public decimal? FinishValue { get; set; }
        public decimal? DiscPercent { get; set; }
        public decimal? DiscValue { get; set; }
        public decimal? TotalServices { get; set; }
        public decimal? TotalUnitArea { get; set; }
        public bool? IsContract { get; set; }
        /// <summary>
        /// 0 without,1=10,2=100,3=1000,4=10000
        /// </summary>
        public byte? RoundType { get; set; }
        public string? Remarks { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public decimal? NotPaid { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
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
        public bool? IsRental { get; set; }
        public int? ShiftId { get; set; }
        public decimal? GaragCost { get; set; }
        public decimal? Cost2 { get; set; }
        public decimal? Cost3 { get; set; }

        public virtual ICollection<ProjProjUnitService> ProjProjUnitServices { get; set; }
        public virtual ICollection<ProjReservInstallment> ProjReservInstallments { get; set; }
        public virtual ICollection<ProjReserveUnitDocument> ProjReserveUnitDocuments { get; set; }
        public virtual ICollection<ProjReserveUnitOwner> ProjReserveUnitOwners { get; set; }
        public virtual ICollection<ProjReserveUnitSeller> ProjReserveUnitSellers { get; set; }
        public virtual ICollection<ProjUnitReservationGuarantor> ProjUnitReservationGuarantors { get; set; }
    }
}
