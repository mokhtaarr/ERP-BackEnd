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
    public class ProdEquipmentsController : ControllerBase
    {
        private readonly ERPContext _db;
        public ProdEquipmentsController(ERPContext db)
        {
            _db = db;
        }


        [HttpGet("GetAllProdEquipments")]
        public async Task<IActionResult> GetAllProdEquipments()
        {
            return Ok(await _db.ProdEquipments.Where(q => q.DeletedAt == null).OrderByDescending(q => q.CreatedAt).ToListAsync());
        }



        [HttpPost("AddProdEquipment")]
        public async Task<IActionResult> AddProdEquipment(ProdEquipmentDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                ProdEquipment getProdEquipment = await _db.ProdEquipments.FindAsync(dto.EquipId);

                if (getProdEquipment == null)
                {


                    ProdEquipment existingEquipCode = await _db.ProdEquipments.Where(c => c.EquipCode == dto.EquipCode).FirstOrDefaultAsync();
                    if (existingEquipCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.EquipCode}  ",
                            messageEn = $"This Prod Equipment code already exists {dto.EquipCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    ProdEquipment newProdEquipment = new ProdEquipment
                    {
                        EquipCode = dto.EquipCode,
                        EquipName1 = dto.EquipName1,
                        EquipName2 = dto.EquipName2,
                        Jdesc = dto.Jdesc,
                        Remarks = dto.Remarks,
                        StandardMonthlyCost = dto.StandardMonthlyCost,
                        StandardHolyDays = dto.StandardHolyDays,
                        StandardDailyCost = dto.StandardDailyCost,
                        StandardDailyWorkHours = dto.StandardDailyWorkHours,
                        StandardHourlyCost = dto.StandardHourlyCost,
                        NumberAvailable = dto.NumberAvailable,
                        TimeRate = dto.TimeRate,
                        IsScale  = dto.IsScaleBoolean == true ? 1 : 0,
                        MaxWeight = dto.MaxWeight,
                        MinWeight = dto.MinWeight,
                        CreatedAt = DateTime.Now
                    };

                    _db.ProdEquipments.Add(newProdEquipment);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newProdEquipment.EquipId
                    };

                    return Ok(response);
                }
                else
                {
                        getProdEquipment.EquipName1 = dto.EquipName1;
                        getProdEquipment.EquipName2 = dto.EquipName2;
                        getProdEquipment.Jdesc = dto.Jdesc;
                        getProdEquipment.Remarks = dto.Remarks;
                        getProdEquipment.StandardMonthlyCost = dto.StandardMonthlyCost;
                        getProdEquipment.StandardHolyDays = dto.StandardHolyDays;
                        getProdEquipment.StandardDailyCost = dto.StandardDailyCost;
                        getProdEquipment.StandardDailyWorkHours = dto.StandardDailyWorkHours;
                        getProdEquipment.StandardHourlyCost = dto.StandardHourlyCost;
                        getProdEquipment.NumberAvailable = dto.NumberAvailable;
                        getProdEquipment.TimeRate = dto.TimeRate;
                        getProdEquipment.IsScale = dto.IsScaleBoolean == true ? 1 : 0;
                        getProdEquipment.MaxWeight = dto.MaxWeight;
                        getProdEquipment.MinWeight = dto.MinWeight;
                        getProdEquipment.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Prod Equipment has been modified successfully",
                        id = getProdEquipment.EquipId
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

        [HttpDelete("DeleteProdEquipment")]
        public async Task<IActionResult> DeleteProdEquipment(int EquipId)
        {
            try
            {
                if (EquipId == 0) return BadRequest("EquipId  is equal zero");

                ProdEquipment getProdEquipment = await _db.ProdEquipments.FindAsync(EquipId);


                if (getProdEquipment == null) return NotFound("ProdEquipment is not found");

                getProdEquipment.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "ProdEquipment deleted successfully",
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
