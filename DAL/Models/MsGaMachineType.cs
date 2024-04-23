using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaMachineType
    {
        public int MachineId { get; set; }
        public string MachineCode { get; set; } = null!;
        public string? MachineName { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? VehicleShapeId { get; set; }
        public int? VehicleTypId { get; set; }
    }
}
