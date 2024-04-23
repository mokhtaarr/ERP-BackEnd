using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrHotel
    {
        public SrHotel()
        {
            SrAccomodations = new HashSet<SrAccomodation>();
            SrExtensions = new HashSet<SrExtension>();
        }

        public int HotelId { get; set; }
        public string? HotelCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public byte? Stars { get; set; }
        public int? CityId { get; set; }
        public int? ElevatorNum { get; set; }
        public int? RoomSingleCount { get; set; }
        public decimal? RoomSingleCost { get; set; }
        public int? DoubleRoomCount { get; set; }
        public decimal? DoubleRoomCost { get; set; }
        public int? TribleRoomCount { get; set; }
        public decimal? TribleRoomCost { get; set; }
        public int? QuadRoomCount { get; set; }
        public decimal? QuadRoomCost { get; set; }
        public int? SuitRoomCount { get; set; }
        public decimal? SuitRoomCost { get; set; }
        public int? SpecialRoomCount { get; set; }
        public decimal? SpecialRoomCost { get; set; }
        public bool? SupportFb { get; set; }
        public bool? SupportHb { get; set; }
        public bool? SupportBb { get; set; }
        public bool? SupportRo { get; set; }
        public bool? RoomsWithWc { get; set; }
        public decimal? Fbcost { get; set; }
        public decimal? Hbcost { get; set; }
        public decimal? Bbcost { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Email2 { get; set; }
        public string? Email3 { get; set; }
        public string? Email4 { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Tel5 { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? Remark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MsgaCity? City { get; set; }
        public virtual ICollection<SrAccomodation> SrAccomodations { get; set; }
        public virtual ICollection<SrExtension> SrExtensions { get; set; }
    }
}
