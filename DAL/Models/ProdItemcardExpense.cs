using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdItemcardExpense
    {
        public int ProdExpensId { get; set; }
        public int? ItemCardId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsPercent { get; set; }
        public byte? PercentOf { get; set; }
        public decimal? ExpenseValu { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
