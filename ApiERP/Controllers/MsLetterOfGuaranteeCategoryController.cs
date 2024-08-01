using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MsLetterOfGuaranteeCategoryController : ControllerBase
    {
        private readonly ERPContext _db;
        public MsLetterOfGuaranteeCategoryController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllLetterCategory")]
        public async Task<IActionResult> GetAllLetterCategory()
        {
            return Ok(await _db.MsLetterOfGuaranteeCategories.AsNoTracking().Where(l => l.DeletedAt == null).ToListAsync());
        }

        [HttpPost("AddLetter")]
        public async Task<IActionResult> AddLetterCategory(MsLetterOfGuaranteeCategoriesDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsLetterOfGuaranteeCategory getletterCategory = await _db.MsLetterOfGuaranteeCategories.FindAsync(dto.LetOfGrnteeCatId);

                if (getletterCategory is null)
                {


                    MsLetterOfGuaranteeCategory existingLetterCode = await _db.MsLetterOfGuaranteeCategories.Where(c => c.Code == dto.Code).FirstOrDefaultAsync();
                    if (existingLetterCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.Code}  ",
                            messageEn = $"This letter category code already exists {dto.Code}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsLetterOfGuaranteeCategory NewLetter = new MsLetterOfGuaranteeCategory
                    {
                        Code = dto.Code,
                        Name1 = dto.Name1,
                        Name2 = dto.Name2,
                        Remarks = dto.Remarks
                    };

                    _db.MsLetterOfGuaranteeCategories.Add(NewLetter);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = NewLetter.LetOfGrnteeCatId
                    };

                    return Ok(response);
                }
                else
                {
                    getletterCategory.Code = dto.Code;
                    getletterCategory.Name1 = dto.Name1;
                    getletterCategory.Name2 = dto.Name2;
                    getletterCategory.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "letter category has been modified successfully",
                        id = getletterCategory.LetOfGrnteeCatId

                    };

                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                var Bad_response = new
                {
                    status = false,
                    message = $" {ex.Message} حدث خطا",
                    messageEn = $"something went wrong {ex.Message}",
                };

                return Ok(Bad_response);
            }
        }

        [HttpDelete("DeleteLetterCategory")]
        public async Task<IActionResult> DeleteLetterCategory(int LetOfGrnteeCatId)
        {
            try
            {
                if (LetOfGrnteeCatId == 0) return BadRequest("LetOfGrnteeCatId  is equal zero");

                MsLetterOfGuaranteeCategory getletterCategory = await _db.MsLetterOfGuaranteeCategories.FindAsync(LetOfGrnteeCatId);


                if (getletterCategory == null) return NotFound("letter is not found");

                _db.MsLetterOfGuaranteeCategories.Remove(getletterCategory);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "deleted successfully",
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                var Bad_response = new
                {
                    status = false,
                    message = $"{ex.Message} حدث خطأ ما",
                    messageEn = $"something went wrong {ex.Message}",
                };

                return Ok(Bad_response);
            }
        }
    }
}
