using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobOrder
    {
        public SrJobOrder()
        {
            SrJobAdditionalCosts = new HashSet<SrJobAdditionalCost>();
            SrJobComments = new HashSet<SrJobComment>();
            SrJobExtrnalExpens = new HashSet<SrJobExtrnalExpen>();
            SrJobFiles = new HashSet<SrJobFile>();
            SrJobSparts = new HashSet<SrJobSpart>();
            SrJobSwages = new HashSet<SrJobSwage>();
        }

        public int JorderId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? SrTypId { get; set; }
        public int? ReciptionId { get; set; }
        public int? CustId { get; set; }
        public int? VehicleId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? AddAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? CurrencyId { get; set; }
        public string? Remarks { get; set; }
        public decimal? SparePrts { get; set; }
        public decimal? Wages { get; set; }
        public decimal? Expense { get; set; }
        public decimal? OtherCosts { get; set; }
        public decimal? NetValue { get; set; }
        public bool? CustSatisfy { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? ApprovedBy { get; set; }
        public bool? FreeService { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual SrReciption? Reciption { get; set; }
        public virtual SrServiceType? SrTyp { get; set; }
        public virtual SrVehicle? Vehicle { get; set; }
        public virtual ICollection<SrJobAdditionalCost> SrJobAdditionalCosts { get; set; }
        public virtual ICollection<SrJobComment> SrJobComments { get; set; }
        public virtual ICollection<SrJobExtrnalExpen> SrJobExtrnalExpens { get; set; }
        public virtual ICollection<SrJobFile> SrJobFiles { get; set; }
        public virtual ICollection<SrJobSpart> SrJobSparts { get; set; }
        public virtual ICollection<SrJobSwage> SrJobSwages { get; set; }
    }
}
