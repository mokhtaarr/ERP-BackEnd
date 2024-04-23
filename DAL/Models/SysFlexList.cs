using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysFlexList
    {
        public int FlexListId { get; set; }
        public int? NamingId { get; set; }
        public string? FlexCode { get; set; }
        public string? FlexName1 { get; set; }
        public string? FlexName2 { get; set; }
        public string? TableCode { get; set; }
        public string? FieldCode { get; set; }
        public string? Value1 { get; set; }
        public string? Value2 { get; set; }
        public string? Value3 { get; set; }
        public string? Value4 { get; set; }
        public string? Value5 { get; set; }
        public bool? Enabled { get; set; }
        public string? Culture { get; set; }
        public bool? AllLanguages { get; set; }
    }
}
