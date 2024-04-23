using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPossetting
    {
        public int PosSetId { get; set; }
        public int? DefCustomerId { get; set; }
        public int? DefEmpId { get; set; }
        public int? BookId { get; set; }
        public int? RetBookId { get; set; }
        public int? CashTermId { get; set; }
        public int? CreditTermId { get; set; }
        public int? PayMethodTermId { get; set; }
        public int? ReturnCashTermId { get; set; }
        public int? ReturnCreditTermId { get; set; }
        public int? ReturnPayMethodTermId { get; set; }
        public bool? UseItemDefStorIfNoQty { get; set; }
        public bool? MinusNoteQty { get; set; }
        public bool? UseOffers { get; set; }
        public string? CmdNew { get; set; }
        public string? CmdNew2 { get; set; }
        public string? CmdEdit { get; set; }
        public string? CmdEdit2 { get; set; }
        public string? CmdPreview { get; set; }
        public string? CmdPreview2 { get; set; }
        public string? CmdPrint { get; set; }
        public string? CmdPrint2 { get; set; }
        public string? CmdSave { get; set; }
        public string? CmdSave2 { get; set; }
        public string? CmdPay { get; set; }
        public string? CmdPay2 { get; set; }
        public string? CmdCredit { get; set; }
        public string? CmdCredit2 { get; set; }
        public string? CmdHold { get; set; }
        public string? CmdHold2 { get; set; }
        public string? CmdDelete { get; set; }
        public string? CmdDelete2 { get; set; }
        public string? CmdDiscount { get; set; }
        public string? CmdDiscount2 { get; set; }
        public string? CmdShortage { get; set; }
        public string? CmdShortage2 { get; set; }
        public string? CmdDocSearch { get; set; }
        public string? CmdDocSearch2 { get; set; }
        public string? CmdItemSearch1 { get; set; }
        public string? CmdItemSearch2 { get; set; }
        public string? CmdItemEdit { get; set; }
        public string? CmdItemEdit2 { get; set; }
        public string? CmdDeleteItem { get; set; }
        public string? CmdDeleteItem2 { get; set; }
        public string? CmdUndo { get; set; }
        public string? CmdUndo2 { get; set; }
        public string? CmdRetWithInv { get; set; }
        public string? CmdRetWithInv2 { get; set; }
        public string? CmdRetWithoutInv { get; set; }
        public string? CmdRetWithoutInv2 { get; set; }
        public string? CmdFirst { get; set; }
        public string? CmdFirst2 { get; set; }
        public string? CmdLast { get; set; }
        public string? CmdLast2 { get; set; }
        public string? CmdPrevious { get; set; }
        public string? CmdPrevious2 { get; set; }
        public string? CmdNext { get; set; }
        public string? CmdNext2 { get; set; }
        public string? CmdOffer1 { get; set; }
        public string? CmdOffer2 { get; set; }
        public int? CustomerAccountId { get; set; }
        public int? VendorAccountId { get; set; }
        public int? EmpAccountId { get; set; }
        public int? BasUnitId { get; set; }
        public int? BtnItemCatWidth { get; set; }
        public int? BtnItemCatHeight { get; set; }
        public int? BtnItemWidth { get; set; }
        public int? BtnItemHeight { get; set; }
        public int? BtnPayMethodWidth { get; set; }
        public int? BtnPayMethodHeight { get; set; }
    }
}
