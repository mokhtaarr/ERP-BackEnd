using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetRecipeRank
    {
        public long? RowRank { get; set; }
        public int RecipeId { get; set; }
        public string? RecipeCode { get; set; }
    }
}
