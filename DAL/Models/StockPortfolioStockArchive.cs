using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockPortfolioStockArchive
    {
        public int StockArchivesId { get; set; }
        public int? StockPortJoinId { get; set; }
        public int? StockArchId { get; set; }
        public int? StockQuantity { get; set; }

        public virtual StockArchive? StockArch { get; set; }
        public virtual StockPortfolioStock? StockPortJoin { get; set; }
    }
}
