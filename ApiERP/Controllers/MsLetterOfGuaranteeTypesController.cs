using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MsLetterOfGuaranteeTypesController : ControllerBase
    {
        private readonly ERPContext _db;
        public MsLetterOfGuaranteeTypesController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllLetter")]
        public async Task<IActionResult> GetAllLetter()
        {
            return Ok(await _db.MsLetterOfGuaranteeTypes.AsNoTracking().Where(l => l.DeletedAt == null).ToListAsync());
        }

        [HttpPost("AddLetter")]
        public async Task<IActionResult> AddLetter(MsLetterOfGuaranteeTypeDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsLetterOfGuaranteeType getletter = await _db.MsLetterOfGuaranteeTypes.FindAsync(dto.LetOfGrnteeTypeId);

                if (getletter is null)
                {


                    MsLetterOfGuaranteeType existingLetterCode = await _db.MsLetterOfGuaranteeTypes.Where(c => c.Code == dto.Code).FirstOrDefaultAsync();
                    if (existingLetterCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.Code}  ",
                            messageEn = $"This letter code already exists {dto.Code}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsLetterOfGuaranteeType NewLetter = new MsLetterOfGuaranteeType
                    {
                        Code = dto.Code,
                        Name1 = dto.Name1,
                        Name2 = dto.Name2,
                        Remarks = dto.Remarks
                    };

                    _db.MsLetterOfGuaranteeTypes.Add(NewLetter);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = NewLetter.LetOfGrnteeTypeId
                    };

                    return Ok(response);
                }
                else
                {
                    getletter.Code = dto.Code;
                    getletter.Name1 = dto.Name1;
                    getletter.Name2 = dto.Name2;
                    getletter.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "letter has been modified successfully",
                        id = getletter.LetOfGrnteeTypeId

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

        [HttpDelete("DeleteLetter")]
        public async Task<IActionResult> DeleteLetter(int LetOfGrnteeTypeId)
        {
            try
            {
                if (LetOfGrnteeTypeId == 0) return BadRequest("LetOfGrnteeTypeId  is equal zero");

                MsLetterOfGuaranteeType getletter = await _db.MsLetterOfGuaranteeTypes.FindAsync(LetOfGrnteeTypeId);


                if (getletter == null) return NotFound("letter is not found");

                _db.MsLetterOfGuaranteeTypes.Remove(getletter);
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
