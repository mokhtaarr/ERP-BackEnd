using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsVendotContactDto
    {
        public int? VendContactId { get; set; }
        public int? VendorId { get; set; }
        public string? ContactCode { get; set; }
        public string? ContactName1 { get; set; }
        public string? ContactName2 { get; set; }
        public string? ContactPhone1 { get; set; }
        public string? ContactPhone2 { get; set; }
        public string? ContactPhone3 { get; set; }
        public string? ContactPhone4 { get; set; }
        public string? ContactPhone5 { get; set; }
        public string? ContactAddress1 { get; set; }
        public string? ContactAddress2 { get; set; }
        public string? ContactAddress3 { get; set; }
        public string? ContactEmail1 { get; set; }
        public string? ContactEmail2 { get; set; }
        public string? ContactEmail3 { get; set; }
        public string? Idno { get; set; }
        public string? PassPortNo { get; set; }
        public string? Bank1 { get; set; }
        public string? Bank2 { get; set; }
        public string? Bank3 { get; set; }
        public string? BankAccNo1 { get; set; }
        public string? BankAccNo2 { get; set; }
        public string? BankAccNo3 { get; set; }
        public string? Remark1 { get; set; }
        public string? Remark2 { get; set; }
        public bool? Isprimary { get; set; }

    }
}
