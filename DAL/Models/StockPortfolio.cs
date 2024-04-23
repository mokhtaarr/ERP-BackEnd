using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockPortfolio
    {
        public StockPortfolio()
        {
            StockPortfolioAccounts = new HashSet<StockPortfolioAccount>();
            StockPortfolioStocks = new HashSet<StockPortfolioStock>();
        }

        public int StockPortfolioId { get; set; }
        public string Code { get; set; } = null!;
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? PortfolioNo { get; set; }
        public int? CurrencyId { get; set; }
        public int? StockBrokersId { get; set; }
        public bool? ManagedByOthers { get; set; }
        public bool? FollowOtherPortfolio { get; set; }
        public decimal? StockBalance { get; set; }
        public decimal? InvestBoxBalance { get; set; }
        public decimal? CashBalance { get; set; }
        public decimal? TotalBalance { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<StockPortfolioAccount> StockPortfolioAccounts { get; set; }
        public virtual ICollection<StockPortfolioStock> StockPortfolioStocks { get; set; }
    }
}
