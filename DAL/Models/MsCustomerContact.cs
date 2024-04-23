using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCustomerContact
    {
        public int CustContactId { get; set; }
        public int? CustomerId { get; set; }
        public int? AccountId1 { get; set; }
        public int? AccountId2 { get; set; }
        public int? AccountId3 { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public string? ContactCode { get; set; }
        public int? CityId { get; set; }
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

        public virtual MsCustomer? Customer { get; set; }
    }
}
