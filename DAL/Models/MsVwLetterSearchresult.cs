using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVwLetterSearchresult
    {
        public bool? LetterType { get; set; }
        public string? BodySn { get; set; }
        public string? MotorSn { get; set; }
        public int? MotorSntrNo { get; set; }
        public int? DeliverTrNo { get; set; }
        public DateTime? DeliverTrDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public int? LetterTrNo { get; set; }
        public DateTime? LetterTrDate { get; set; }
        public string? BuyerName { get; set; }
        public int? LetterId { get; set; }
        public int MotorSearialId { get; set; }
        public int? StoreId { get; set; }
        public string? CityName { get; set; }
        public string? Size { get; set; }
        public string? MachineName { get; set; }
        public string? MororName { get; set; }
    }
}
