using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicle
    {
        public SrVehicle()
        {
            SrJobOrders = new HashSet<SrJobOrder>();
            SrTrafficLinePriceLists = new HashSet<SrTrafficLinePriceList>();
            SrVehicleJobOrders = new HashSet<SrVehicleJobOrder>();
        }

        /// <summary>
        /// ItemCardId
        /// </summary>
        public int VehicleId { get; set; }
        public string? VehicleCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? InvItemCardId { get; set; }
        public int? ItemCardId { get; set; }
        public int? InvId { get; set; }
        public int? CustomerId { get; set; }
        public int? VehicleTypId { get; set; }
        public int? VehicleShapeId { get; set; }
        public int? TrafficLineId { get; set; }
        public int? Wid { get; set; }
        public int? DriverId1 { get; set; }
        public int? DriverId2 { get; set; }
        public int? GarageId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CurrencyId { get; set; }
        public bool? IsCompanyCar { get; set; }
        public bool? InWarranty { get; set; }
        public string? RegNo { get; set; }
        public string? BodyNo { get; set; }
        public string? MotorNo { get; set; }
        public long? StartCounterNo { get; set; }
        public long? CounterNo { get; set; }
        public int? YearModel { get; set; }
        public string? Color { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerAddress { get; set; }
        public string? Remarks { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? VendorId { get; set; }
        /// <summary>
        /// 1 car,2 pump
        /// </summary>
        public byte? VtypeConcrete { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public bool? Stopped { get; set; }
        public decimal? DayCost { get; set; }

        public virtual SrGarage? Garage { get; set; }
        public virtual SrVehicleShape? VehicleShape { get; set; }
        public virtual SrVehicleType? VehicleTyp { get; set; }
        public virtual SrWarranty? WidNavigation { get; set; }
        public virtual ICollection<SrJobOrder> SrJobOrders { get; set; }
        public virtual ICollection<SrTrafficLinePriceList> SrTrafficLinePriceLists { get; set; }
        public virtual ICollection<SrVehicleJobOrder> SrVehicleJobOrders { get; set; }
    }
}
