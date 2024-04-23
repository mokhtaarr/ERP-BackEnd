using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnit
    {
        public ProjProjUnit()
        {
            ProjProjInsuranceUnits = new HashSet<ProjProjInsuranceUnit>();
            ProjProjUnitDocuments = new HashSet<ProjProjUnitDocument>();
            ProjProjUnitExploitJoins = new HashSet<ProjProjUnitExploitJoin>();
            ProjProjUnitInstallTemps = new HashSet<ProjProjUnitInstallTemp>();
            ProjProjUnitOccupTypeJoins = new HashSet<ProjProjUnitOccupTypeJoin>();
            ProjProjUnitOwnerJoins = new HashSet<ProjProjUnitOwnerJoin>();
            ProjProjUnitPermitActivityJoins = new HashSet<ProjProjUnitPermitActivityJoin>();
            ProjProjUnitPerspectiveJoins = new HashSet<ProjProjUnitPerspectiveJoin>();
            ProjProjUnitPictures = new HashSet<ProjProjUnitPicture>();
            ProjProjUnitServices = new HashSet<ProjProjUnitService>();
            ProjProjUnitSubUnits = new HashSet<ProjProjUnitSubUnit>();
        }

        public int ProjUnitId { get; set; }
        public int? ProjectId { get; set; }
        public int? UnittypeId { get; set; }
        public int? UnitStatId { get; set; }
        public int? UnitDegreeId { get; set; }
        public int? UnFinLevelId { get; set; }
        public int? UnitInsurstatId { get; set; }
        public int? ParkingId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? RentCaseId { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public string? Code { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? RoomCount { get; set; }
        public int? FloorNumber { get; set; }
        public long? WaterCounter { get; set; }
        public long? ElectricityCounter { get; set; }
        public bool? CalcAllMeters { get; set; }
        public decimal? BuildingArea { get; set; }
        public decimal? BuildingMeterPrice { get; set; }
        public decimal? UnitArea { get; set; }
        public decimal? UnitMeterPrice { get; set; }
        public decimal? EstimatedUnitArea { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool? CommissionIsPercent { get; set; }
        public decimal? CommissionValue { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? UnitStartDate { get; set; }
        public DateTime? UnitExpectedStartDate { get; set; }
        public decimal? ParkArea { get; set; }
        public decimal? ParkMeterPrice { get; set; }
        public decimal? RoofArea { get; set; }
        public decimal? RoofMeterPrice { get; set; }
        public decimal? GardenArea { get; set; }
        public decimal? GardenMeterPrice { get; set; }
        public decimal? BaseMentArea { get; set; }
        public decimal? BasementMeterPrice { get; set; }
        public bool? CanSaleUnits { get; set; }
        public bool? CanRentUnits { get; set; }
        public bool? ProjectStopped { get; set; }
        public bool? Sold { get; set; }
        public string? ContractDocNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public bool? Reserved { get; set; }
        public DateTime? ReserveDate { get; set; }
        public string? ReserveDocNo { get; set; }
        public bool? Rented { get; set; }
        public DateTime? RentDate { get; set; }
        public string? RentDocNo { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
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
        public byte? MaxRents { get; set; }
        public byte? UnitOrderInFloor { get; set; }

        public virtual ProjProject? Project { get; set; }
        public virtual ICollection<ProjProjInsuranceUnit> ProjProjInsuranceUnits { get; set; }
        public virtual ICollection<ProjProjUnitDocument> ProjProjUnitDocuments { get; set; }
        public virtual ICollection<ProjProjUnitExploitJoin> ProjProjUnitExploitJoins { get; set; }
        public virtual ICollection<ProjProjUnitInstallTemp> ProjProjUnitInstallTemps { get; set; }
        public virtual ICollection<ProjProjUnitOccupTypeJoin> ProjProjUnitOccupTypeJoins { get; set; }
        public virtual ICollection<ProjProjUnitOwnerJoin> ProjProjUnitOwnerJoins { get; set; }
        public virtual ICollection<ProjProjUnitPermitActivityJoin> ProjProjUnitPermitActivityJoins { get; set; }
        public virtual ICollection<ProjProjUnitPerspectiveJoin> ProjProjUnitPerspectiveJoins { get; set; }
        public virtual ICollection<ProjProjUnitPicture> ProjProjUnitPictures { get; set; }
        public virtual ICollection<ProjProjUnitService> ProjProjUnitServices { get; set; }
        public virtual ICollection<ProjProjUnitSubUnit> ProjProjUnitSubUnits { get; set; }
    }
}
