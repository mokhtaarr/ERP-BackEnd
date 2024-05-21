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
    public class CityController : ControllerBase
    {
        private readonly ERPContext _db;

        public CityController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllCities")]
        public async Task<ActionResult<MsgaCity>> GetAllCities()
        {
            return Ok(await _db.MsgaCities.Where(c => c.DeletedAt == null).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpPost("AddCity")]
        public async Task<IActionResult> AddCity(MsgaCityDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsgaCity getCity = await _db.MsgaCities.FindAsync(dto.CityId);

                if (getCity == null)
                {


                    MsgaCity existingCityCode = await _db.MsgaCities.Where(c => c.CityCode == dto.CityCode).FirstOrDefaultAsync();
                    if (existingCityCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.CityCode}  ",
                            messageEn = $"This city code already exists {dto.CityCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsgaCity newCity = new MsgaCity
                    {
                        CityCode = dto.CityCode,
                        CityName = dto.CityName,
                        Remarks = dto.Remarks,
                        CreatedAt = DateTime.Now
                    };

                    _db.MsgaCities.Add(newCity);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newCity.CityId
                    };

                    return Ok(response);
                }
                else
                {
                    getCity.CityName = dto.CityName;
                    getCity.Remarks = dto.Remarks;
                    getCity.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Vehicle Shape has been modified successfully",
                        id = getCity.CityId

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

        [HttpDelete("DeleteCity")]
        public async Task<IActionResult> DeleteCity(int CityId)
        {
            try
            {
                if (CityId == 0) return BadRequest("CityId  is equal zero");

                MsgaCity getCity = await _db.MsgaCities.FindAsync(CityId);


                if (getCity == null) return NotFound("City is not found");

                getCity.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "City deleted successfully",
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
