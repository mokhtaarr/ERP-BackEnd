using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdRecipeDetail
    {
        public int RecipeDetaiId { get; set; }
        public int? RecipeId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? ProLineId { get; set; }

        public virtual ProdRecipe? Recipe { get; set; }
    }
}
