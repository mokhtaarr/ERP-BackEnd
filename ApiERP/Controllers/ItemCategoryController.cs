using DAL.Context;
using DAL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        private readonly ERPContext _db;

        public ItemCategoryController(ERPContext db)
        {
            _db = db;
        }


        [HttpGet("GetAllItemCategory")]
        public async Task<IActionResult> GetAllItemCategory()
        {

            var query = await (from itemCategory in _db.MsItemCategories
                         select new MsItemCategoryDto
                         {
                             ItemCategoryId = itemCategory.ItemCategoryId,
                             ItemCatCode = itemCategory.ItemCatCode,
                             ItemCatDescA = itemCategory.ItemCatDescA,
                             ItemCatDescE = itemCategory.ItemCatDescE,
                             ParentItemCategoryId = itemCategory.ParentItemCategoryId,
                             Name_ParentItemCategoryId = _db.MsItemCategories.Where(c => c.ItemCategoryId == itemCategory.ParentItemCategoryId).Select(p => p.ItemCatDescA).FirstOrDefault(),
                             NameEn_ParentItemCategoryId = _db.MsItemCategories.Where(c => c.ItemCategoryId == itemCategory.ParentItemCategoryId).Select(p => p.ItemCatDescE).FirstOrDefault(),
                             CategoryImage = itemCategory.CategoryImage,
                             CreatedAt = DateTime.Now,
                             DeletedBy = itemCategory.DeletedBy,
                             CreatedBy = itemCategory.CreatedBy,
                             CurrentTrNo = itemCategory.CurrentTrNo,
                             DeletedAt = itemCategory.DeletedAt,
                             ItemCategoryType = itemCategory.ItemCategoryType,
                             ItemCategoryCatLevel = itemCategory.ItemCategoryCatLevel,
                             Remarks = itemCategory.Remarks,
                             
                             }).ToListAsync();



             return Ok(query);
        }
    }
}
