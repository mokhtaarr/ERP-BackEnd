using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcSeason
    {
        public int SeasonId { get; set; }
        public string? SeasonCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? EmbassyDate { get; set; }
        public DateTime? AcceptAgeFrom { get; set; }
        public DateTime? AcceptAgeTo { get; set; }
        public DateTime? PassPortExpiry { get; set; }
        public string? CountryEnc { get; set; }
        public bool? IsCurrentSeason { get; set; }
        public bool? IsPreviousSeason { get; set; }
    }
}
