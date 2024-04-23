using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockStock
    {
        public StockStock()
        {
            StockCapitalUpdates = new HashSet<StockCapitalUpdate>();
            StockPortfolioStocks = new HashSet<StockPortfolioStock>();
        }

        public int StockId { get; set; }
        public string Code { get; set; } = null!;
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Symbol { get; set; }
        public string? SymbolAr { get; set; }
        public decimal? SharePercent { get; set; }
        public int? StockMarketId { get; set; }
        public int? StockSectorsId { get; set; }
        public int? StockCatId { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? FinancialEndDate { get; set; }
        public bool? Listed { get; set; }
        public decimal? StockPrice { get; set; }
        public string? ZakatOnInvest { get; set; }
        public string? IslamicCompatibility { get; set; }
        public string? DocType { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Fax { get; set; }
        public string? WebSite { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime? LastMemberDate { get; set; }
        public DateTime? NextMemberDate { get; set; }
        public DateTime? EstablishDate { get; set; }
        public DateTime? MarketListDate { get; set; }
        public decimal? PaidCapital { get; set; }
        public decimal? StockNameValue { get; set; }
        public int? StockIssuesNo { get; set; }
        public int? StockCurrentNo { get; set; }
        public int? StockTreasuryNo { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual StockCategory? StockCat { get; set; }
        public virtual StockMarket? StockMarket { get; set; }
        public virtual StockSector? StockSectors { get; set; }
        public virtual ICollection<StockCapitalUpdate> StockCapitalUpdates { get; set; }
        public virtual ICollection<StockPortfolioStock> StockPortfolioStocks { get; set; }
    }
}
