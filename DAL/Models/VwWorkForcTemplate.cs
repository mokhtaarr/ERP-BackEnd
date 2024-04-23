using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwWorkForcTemplate
    {
        public int WftempId { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public string? SeasonName2 { get; set; }
        public DateTime? EmbassyDate { get; set; }
        public DateTime? AcceptAgeFrom { get; set; }
        public DateTime? AcceptAgeTo { get; set; }
        public DateTime? PassPortExpiry { get; set; }
    }
}
