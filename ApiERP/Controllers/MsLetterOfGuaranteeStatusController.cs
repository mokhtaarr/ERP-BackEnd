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
    public class MsLetterOfGuaranteeStatusController : ControllerBase
    {
        private readonly ERPContext _db;
        public MsLetterOfGuaranteeStatusController(ERPContext db)
        {
            _db = db;
        }


        [HttpGet("GetAllLetterStatus")]
        public async Task<IActionResult> GetAllLetterStatus()
        {
            return Ok(await _db.MsLetterOfGuaranteeStatuses.AsNoTracking().Where(l => l.DeletedAt == null).ToListAsync());
        }

        [HttpPost("AddLetterStatus")]
        public async Task<IActionResult> AddLetterStatus(MsLetterOfGuaranteeStatusDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsLetterOfGuaranteeStatus getletterStatu = await _db.MsLetterOfGuaranteeStatuses.FindAsync(dto.LetOfGrnteeStatusId);

                if (getletterStatu is null)
                {


                    MsLetterOfGuaranteeStatus existingLetterCode = await _db.MsLetterOfGuaranteeStatuses.Where(c => c.Code == dto.Code).FirstOrDefaultAsync();
                    if (existingLetterCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.Code}  ",
                            messageEn = $"This letter status code already exists {dto.Code}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsLetterOfGuaranteeStatus NewLetter = new MsLetterOfGuaranteeStatus
                    {
                        Code = dto.Code,
                        Name1 = dto.Name1,
                        Name2 = dto.Name2,
                        Remarks = dto.Remarks
                    };

                    _db.MsLetterOfGuaranteeStatuses.Add(NewLetter);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = NewLetter.LetOfGrnteeStatusId
                    };

                    return Ok(response);
                }
                else
                {
                    getletterStatu.Code = dto.Code;
                    getletterStatu.Name1 = dto.Name1;
                    getletterStatu.Name2 = dto.Name2;
                    getletterStatu.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "letter category has been modified successfully",
                        id = getletterStatu.LetOfGrnteeStatusId

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

        [HttpDelete("DeleteLetterStatus")]
        public async Task<IActionResult> DeleteLetterStatus(int LetOfGrnteeStatusId)
        {
            try
            {
                if (LetOfGrnteeStatusId == 0) return BadRequest("LetOfGrnteeStatusId  is equal zero");

                MsLetterOfGuaranteeStatus getletterStatu = await _db.MsLetterOfGuaranteeStatuses.FindAsync(LetOfGrnteeStatusId);


                if (getletterStatu == null) return NotFound("letter is not found");

                _db.MsLetterOfGuaranteeStatuses.Remove(getletterStatu);
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
