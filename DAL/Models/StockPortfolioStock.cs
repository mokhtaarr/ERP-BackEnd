using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockPortfolioStock
    {
        public StockPortfolioStock()
        {
            StockPortfolioStockArchives = new HashSet<StockPortfolioStockArchive>();
        }

        public int StockPortJoinId { get; set; }
        public int? StockPortfolioId { get; set; }
        public int? StockId { get; set; }
        public int? StockQuantity { get; set; }
        public decimal? CostAverage { get; set; }

        public virtual StockStock? Stock { get; set; }
        public virtual StockPortfolio? StockPortfolio { get; set; }
        public virtual ICollection<StockPortfolioStockArchive> StockPortfolioStockArchives { get; set; }
    }
}
