using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnAnimalDeathDetail
    {
        public int AnDeathIdDetail { get; set; }
        public int? AnDeathId { get; set; }
        public int? ItemCardId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public decimal? QuantityRecieved { get; set; }
        public decimal? QtyRecievedBeforRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? QtyIunit2 { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public decimal? ExpenseShare { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public int? Aid { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? DbtableName { get; set; }
        public int? AnimalAge { get; set; }
        public bool? IsmedicinNotify { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }

        public virtual AnAnimalDeath? AnDeath { get; set; }
    }
}
