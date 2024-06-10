﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class msCustomerDto
    {
        public int? CustomerId { get; set; }
        public int? AccountId { get; set; }

        public int? CustomerCatId { get; set; }
        public int? CustomerTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CityId { get; set; }
        public int? EmpId { get; set; }
        public int? CostCenterId { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        public int? CreditPeriod { get; set; }
        public byte? PeriodType { get; set; }
        public decimal? CreditLimit { get; set; }
        public string? Nationality { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Tel5 { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PassPortNo { get; set; }
        public DateTime? PassPortIssueDate { get; set; }
        public DateTime? PassPortExpiryDate { get; set; }
        public string? PassPortIssuePlace { get; set; }
        public string? CarLicenseNo { get; set; }
        public DateTime? CarLicenseIssueDate { get; set; }
        public string? CarLicenseIssuePlace { get; set; }
        public DateTime? CarLicenseExpiryDate { get; set; }
        public DateTime? DtReg { get; set; }
        public DateTime? DtRegRenew { get; set; }
        public byte? SalPrice { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public bool? ForAdjustOnly { get; set; }

        public int? AddAccount1 { get; set; }
        public int? AddAccount2 { get; set; }
        public int? AddAccount3 { get; set; }
        public int? AddAccount4 { get; set; }
        public int? AddAccount5 { get; set; }
        public int? AddAccount6 { get; set; }
        public int? AddAccount7 { get; set; }
        public int? AddAccount8 { get; set; }
        public int? AddAccount9 { get; set; }
        public int? AddAccount10 { get; set; }

        public bool? IsPrimaryAccountChangedForm { get;set;}
        public bool? IsAddAccount1ChangedForm { get;set;}
        public bool? IsAddAccount2ChangedForm { get;set;}
        public bool? IsAddAccount3ChangedForm { get;set;}
        public bool? IsAddAccount4ChangedForm { get;set;}
        public bool? IsAddAccount5ChangedForm { get;set;}
        public bool? IsAddAccount6ChangedForm { get;set;}
        public bool? IsAddAccount7ChangedForm { get;set;}
        public bool? IsAddAccount8ChangedForm { get;set;}
        public bool? IsAddAccount9ChangedForm { get;set;}
        public bool? IsAddAccount10ChangedForm { get;set; }
      
    }
}
