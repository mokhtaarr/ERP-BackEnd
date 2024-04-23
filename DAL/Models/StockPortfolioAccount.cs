using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockPortfolioAccount
    {
        public int StockPortAccountsId { get; set; }
        public int? StockPortfolioId { get; set; }
        public int? AccountId { get; set; }
        public decimal? OpenningBalance { get; set; }
        public decimal? CurrentBalance { get; set; }
        public bool? Auto { get; set; }
        public bool? NoTranEffect { get; set; }

        public virtual CalAccountChart? Account { get; set; }
        public virtual StockPortfolio? StockPortfolio { get; set; }
    }
}
