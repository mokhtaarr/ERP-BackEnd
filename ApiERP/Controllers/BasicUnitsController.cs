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
    public class BasicUnitsController : ControllerBase
    {
        private readonly ERPContext _db;

        public BasicUnitsController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAlBasicUnits")]
        public async Task<IActionResult> GetAlBasicUnits()
        {
            return Ok(await _db.ProdBasicUnits.Where(p => p.DeletedAt == null)
                .Select(p => new { p.BasUnitId, p.UnitCode, p.UnitNam, p.UnitNameE,p.UnittRate,p.EtaxUnitCode,p.Remarks,p.AutoDesc,p.CreatedAt })
                .OrderByDescending(p=>p.CreatedAt).ToListAsync());
        }

        [HttpPost("AddBasicUnit")]
        public async Task<IActionResult> AddBasicUnit(ProdBasicUnitDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                ProdBasicUnit getBasicUnit = await _db.ProdBasicUnits.FindAsync(dto.BasUnitId);

                if (getBasicUnit == null)
                {


                    ProdBasicUnit existingunitCode = await _db.ProdBasicUnits.Where(c => c.UnitCode == dto.UnitCode).FirstOrDefaultAsync();
                    if (existingunitCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.UnitCode}  ",
                            messageEn = $"This unit code already exists {dto.UnitCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    ProdBasicUnit newBasicUnit = new ProdBasicUnit
                    {
                        UnitCode = dto.UnitCode,
                        UnitNam = dto.UnitNam,
                        UnitNameE = dto.UnitNameE,
                        UnittRate = dto.UnittRate,
                        EtaxUnitCode = dto.EtaxUnitCode,
                        Remarks = dto.Remarks,
                        AutoDesc = dto.AutoDesc,
                        CreatedAt = DateTime.Now,
                    };

                    _db.ProdBasicUnits.Add(newBasicUnit);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newBasicUnit.BasUnitId
                    };

                    return Ok(response);
                }
                else
                {
                    getBasicUnit.UnitNam = dto.UnitNam;
                    getBasicUnit.UnitNameE = dto.UnitNameE;
                    getBasicUnit.UnittRate = dto.UnittRate;
                    getBasicUnit.EtaxUnitCode = dto.EtaxUnitCode;
                    getBasicUnit.Remarks = dto.Remarks;
                    getBasicUnit.AutoDesc = dto.AutoDesc;
                    getBasicUnit.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "BasicUnit has been modified successfully",
                        id = getBasicUnit.BasUnitId

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

        [HttpDelete("DeleteBasicUnit")]
        public async Task<IActionResult> DeleteBasicUnit(int BasUnitId)
        {
            try
            {
                if (BasUnitId == 0) return BadRequest("CityId  is equal zero");

                ProdBasicUnit getBasicUnit = await _db.ProdBasicUnits.FindAsync(BasUnitId);


                if (getBasicUnit == null) return NotFound("Basic Unit is not found");

                getBasicUnit.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Basic Unit deleted successfully",
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
