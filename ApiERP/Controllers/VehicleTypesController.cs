using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypesController : ControllerBase
    {
        private readonly ERPContext _db;
        public VehicleTypesController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllVehicleType")]
        public async Task<IActionResult> GetAllVehicleType()
        {
            return Ok(await _db.SrVehicleTypes.Where(c => c.DeletedAt == null).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpPost("AddVehicleType")]
        public async Task<IActionResult> AddVehicleType(SrVehicleTypesDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                SrVehicleType getVechicleType = await _db.SrVehicleTypes.FindAsync(dto.VehicleTypId);

                if (getVechicleType == null)
                {


                    SrVehicleType existingVehicleTypeCode = await _db.SrVehicleTypes.Where(c => c.TypeCode == dto.TypeCode).FirstOrDefaultAsync();
                    if (existingVehicleTypeCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.TypeCode}  ",
                            messageEn = $"This Vehicle Type code already exists {dto.TypeCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    SrVehicleType newVehicleType = new SrVehicleType
                    {
                        TypeCode = dto.TypeCode,
                        Name1 = dto.Name1,
                        Name2 = dto.Name2,
                        Remark = dto.Remark,
                        CreatedAt = DateTime.Now
                    };


                    _db.SrVehicleTypes.Add(newVehicleType);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newVehicleType.VehicleTypId
                    };

                    return Ok(response);
                }
                else
                {
                        getVechicleType.Name1 = dto.Name1;
                        getVechicleType.Name2 = dto.Name2;
                        getVechicleType.Remark = dto.Remark;
                        getVechicleType.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Vehicle Shape has been modified successfully",
                        id = getVechicleType.VehicleTypId

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

        [HttpDelete("DeleteVehicleType")]
        public async Task<IActionResult> DeleteVehicleType(int VehicleTypId)
        {
            try
            {
                if (VehicleTypId == 0) return BadRequest("VehicleTypId  is equal zero");

                SrVehicleType getVehicleType = await _db.SrVehicleTypes.FindAsync(VehicleTypId);


                if (getVehicleType == null) return NotFound("getVehicle Type is not found");

                getVehicleType.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "getVehicle Type deleted successfully",
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
