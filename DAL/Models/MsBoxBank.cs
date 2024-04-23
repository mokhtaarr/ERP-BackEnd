using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsBoxBank
    {
        public MsBoxBank()
        {
            MsBoxCurrencies = new HashSet<MsBoxCurrency>();
            MsBoxUsers = new HashSet<MsBoxUser>();
            MsPaymentNotes = new HashSet<MsPaymentNote>();
            MsReceiptNotes = new HashSet<MsReceiptNote>();
            MsStores = new HashSet<MsStore>();
        }

        /// <summary>
        /// 0 Box ,1  Bank
        /// </summary>
        public int BoxId { get; set; }
        public string BoxCode { get; set; } = null!;
        public string? Desca { get; set; }
        public string? Desce { get; set; }
        public int? AccountId { get; set; }
        public int? StoreId { get; set; }
        public string? KeeperName { get; set; }
        public string? BankResposableName { get; set; }
        public string? BankTel { get; set; }
        public string? BankMobile { get; set; }
        public string? BankFax { get; set; }
        public bool? IsActive { get; set; }
        /// <summary>
        /// 0 Box ; 1 Bank
        /// </summary>
        public bool? IsBank { get; set; }
        public int? CheckPrintId { get; set; }
        public bool? ForAdjustOnly { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<MsBoxCurrency> MsBoxCurrencies { get; set; }
        public virtual ICollection<MsBoxUser> MsBoxUsers { get; set; }
        public virtual ICollection<MsPaymentNote> MsPaymentNotes { get; set; }
        public virtual ICollection<MsReceiptNote> MsReceiptNotes { get; set; }
        public virtual ICollection<MsStore> MsStores { get; set; }
    }
}
