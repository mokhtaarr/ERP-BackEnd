using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaMotorSndetail
    {
        public int MotorSearialId { get; set; }
        public int? MotorDocId { get; set; }
        public int? LetterNormId { get; set; }
        public int? LetterFayumId { get; set; }
        public int? MororId { get; set; }
        public int? CityId { get; set; }
        public int? CapcityId { get; set; }
        public int? MachineId { get; set; }
        public string? MotorSn { get; set; }
        public string? BodySn { get; set; }
        public string? Remarks { get; set; }
        /// <summary>
        /// 0 Cash ; 1 Installment
        /// </summary>
        public byte? BasicSaleType { get; set; }
        public bool? LetterType { get; set; }
        public string? Model { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }

        public virtual MsGaLetterFayum? LetterFayum { get; set; }
        public virtual MsGaLetterNormal? LetterNorm { get; set; }
        public virtual MsGaMotorSn? MotorDoc { get; set; }
    }
}
