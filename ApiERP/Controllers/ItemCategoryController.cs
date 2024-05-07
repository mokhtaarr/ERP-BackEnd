using DAL.Context;
using DAL.Dtos;
using DAL.Models;
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
                               where itemCategory.DeletedAt == null
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
                             CreatedAt = itemCategory.CreatedAt,
                             DeletedBy = itemCategory.DeletedBy,
                             CreatedBy = itemCategory.CreatedBy,
                             CurrentTrNo = itemCategory.CurrentTrNo,
                             DeletedAt = itemCategory.DeletedAt,
                             ItemCategoryType = itemCategory.ItemCategoryType,
                             ItemCategoryCatLevel = itemCategory.ItemCategoryCatLevel,
                             Remarks = itemCategory.Remarks,
                             
                             }).OrderByDescending(c=>c.CreatedAt).ToListAsync();



             return Ok(query);
        }

        [HttpPost("AddItemCategory")]
        public async Task<IActionResult> AddItemCategory(Add_MsItemCategoryDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(dto);

                MsItemCategory getItemCat = await _db.MsItemCategories.FindAsync(dto.ItemCategoryId);

                if (getItemCat == null)
                {

                    MsItemCategory itemCat = new MsItemCategory
                    {
                        ItemCatCode = dto.ItemCatCode,
                        ItemCatDescA = dto.ItemCatDescA,
                        ItemCatDescE = dto.ItemCatDescE,
                        Remarks = dto.Remarks,
                        ParentItemCategoryId = dto.ParentItemCategoryId,
                        ItemCategoryType = dto.ItemCategoryType,
                        CreatedAt = DateTime.Now
                    };

                    _db.MsItemCategories.Add(itemCat);
                    await _db.SaveChangesAsync();


                    var response = new
                    {
                        status = true,
                        message = "تم أضافة فئة الصنف بنجاح",
                        messageEn = "The item category has been added successfully",
                    };

                    return Ok(response);

                }
                else
                {
                   
                    getItemCat.ItemCatCode = dto.ItemCatCode;
                    getItemCat.ItemCatDescA = dto.ItemCatDescA;
                    getItemCat.ItemCatDescE = dto.ItemCatDescE;
                    getItemCat.Remarks = dto.Remarks;
                    getItemCat.ParentItemCategoryId = dto.ParentItemCategoryId;
                    getItemCat.ItemCategoryType = dto.ItemCategoryType;
                    getItemCat.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم تعديل فئة الصنف بنجاح",
                        messageEn = "The item category has been modified successfully",
                    };

                    return Ok(response);
                }

            }
            catch
            {
                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء أضافة الفرع",
                    messageEn = "something went wrong",
                };

                return Ok(Bad_response);
            }
            
        }


        [HttpPost("UpdateItemCategory")]
        public async Task<IActionResult> UpdateItemCategory(Add_MsItemCategoryDto dto)
        {
            try
            {

                if (dto == null) return BadRequest("Empty Model");

                MsItemCategory getItemCat = await _db.MsItemCategories.FindAsync(dto.ItemCategoryId);

                if (getItemCat == null) return NotFound("item Category not found");

                getItemCat.ItemCatCode = dto.ItemCatCode;
                getItemCat.ItemCatDescA = dto.ItemCatDescA;
                getItemCat.ItemCatDescE = dto.ItemCatDescE;
                getItemCat.Remarks = dto.Remarks;
                getItemCat.ParentItemCategoryId = dto.ParentItemCategoryId;
                getItemCat.ItemCategoryType = dto.ItemCategoryType;
                getItemCat.UpdateAt = DateTime.Now;

                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم تعديل فئة الصنف بنجاح",
                    messageEn = "The item category has been modified successfully",
                };

                return Ok(response);
            }
            catch
            {
                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء تعديل فئة الصنف",
                    messageEn = "An error occurred while modifying the item category",
                };

                return Ok(Bad_response);
            }
        }

        [HttpDelete("DeleteItemCategory")]
        public async Task<IActionResult> DeleteItemCategory(int? ItemCategoryId)
        {
            try
            {
                if (ItemCategoryId == 0) return BadRequest("item categoryId equal zero");

                MsItemCategory getItemCategory = await _db.MsItemCategories.FindAsync(ItemCategoryId);

                if (getItemCategory == null) return NotFound("item category is not found");

                getItemCategory.DeletedAt = DateTime.Now;
                _db.SaveChanges();

                var response = new
                {
                    status = true,
                    message = "تم حذف فئة الصنف بنجاح",
                    messageEn = "The item category was deleted successfully",
                };

                return Ok(response);
            }
            catch
            {
                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء مسح فئة الصنف",
                    messageEn = "An error occurred while deleting the item category",
                };

                return Ok(Bad_response);
            }
        }
    }

}
