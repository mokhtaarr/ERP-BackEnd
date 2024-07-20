using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MSCurrencyController : ControllerBase
    {
        private readonly ERPContext _db;
        public MSCurrencyController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("getAllCurrencies")]
        public async Task<IActionResult> getAllCurrencies()
        {
            return Ok(await _db.MsCurrencies.Where(c=>c.DeletedAt == null).OrderByDescending(c=>c.CurrencyId).ToListAsync());
        }

        [HttpPost("AddCurrency")]
        public async Task<IActionResult> AddCurrency(MsCurrencyDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(dto);

                MsCurrency getCurrency = await _db.MsCurrencies.FindAsync(dto.CurrencyId);

                if (getCurrency == null)
                {

                    MsCurrency existingCurrencyCode = await _db.MsCurrencies.Where(i => i.CurrencyCode == dto.CurrencyCode).FirstOrDefaultAsync();
                    if (existingCurrencyCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.CurrencyCode}  ",
                            messageEn = $"This currency  code already exists {dto.CurrencyCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsCurrency NewCurrency = new MsCurrency
                    {
                        CurrencyCode = dto.CurrencyCode,
                        CurrencyDescA = dto.CurrencyDescA,
                        CurrencyDescE = dto.CurrencyDescE,
                        Rate = dto.Rate,
                        Remarks = dto.Remarks
                    };

                    _db.MsCurrencies.Add(NewCurrency);
                    await _db.SaveChangesAsync();


                    var response = new
                    {
                        status = true,
                        message = "تم أضافة العمله بنجاح",
                        messageEn = "The currency has been added successfully",
                    };

                    return Ok(response);

                }
                else
                {

                    getCurrency.CurrencyCode = dto.CurrencyCode;
                    getCurrency.CurrencyDescA = dto.CurrencyDescA;
                    getCurrency.CurrencyDescE = dto.CurrencyDescE;
                    getCurrency.Rate = dto.Rate;
                    getCurrency.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم تعديل العمله بنجاح",
                        messageEn = "The currency  has been modified successfully",
                    };

                    return Ok(response);
                }

            }
            catch
            {
                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء أضافة العمله",
                    messageEn = "something went wrong",
                };

                return Ok(Bad_response);
            }

        }

        [HttpDelete("DeleteCurrency")]
        public async Task<IActionResult> DeleteCurrency(int? currencyId)
        {
            try
            {
                if (currencyId == 0) return BadRequest("currency equal zero");

                MsCurrency getCurrency = await _db.MsCurrencies.FindAsync(currencyId);

                if (getCurrency == null) return NotFound("currency is not found");

                _db.MsCurrencies.Remove(getCurrency);
                await   _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم حذف العمله بنجاح",
                    messageEn = "The currency deleted successfully",
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

