using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcTempId
    {
        public int WftempId { get; set; }
        public int? SeasonId { get; set; }
        public DateTime? TrDate { get; set; }
        public string? PersonId { get; set; }
        public string? PassPortNo { get; set; }
        public int? JobId { get; set; }
        public bool? Succeeded { get; set; }
        public byte[]? PersonImage { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? Grade { get; set; }
        public string? ImagePath { get; set; }
        public string? ImagePath2 { get; set; }
        public string? ImagePath3 { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? PersonImagePath { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Grade2 { get; set; }
    }
}
