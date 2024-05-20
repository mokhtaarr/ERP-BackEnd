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
    public class VehicleShapesController : ControllerBase
    {
        private readonly ERPContext _db;

        public VehicleShapesController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllVehicleShapes")]
        public async Task<IActionResult> GetAllVehicleShapes()
        {
            return Ok(await _db.SrVehicleShapes.Where(v=>v.DeletedAt == null).OrderByDescending(j=>j.CreatedAt).ToListAsync());
        }

        [HttpPost("AddVehicleShapes")]
        public async Task<IActionResult> AddVehicleShapes(VehicleShapesDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                SrVehicleShape getVehicleShape = await _db.SrVehicleShapes.FindAsync(dto.vehicleShapeId);

                if (getVehicleShape == null)
                {


                    SrVehicleShape existingVehicleShapeCode = await _db.SrVehicleShapes.Where(c => c.ShapeCode == dto.ShapeCode).FirstOrDefaultAsync();
                    if (existingVehicleShapeCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.ShapeCode}  ",
                            messageEn = $"This Vehicle Shape code already exists {dto.ShapeCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    SrVehicleShape newVehicleShape = new SrVehicleShape
                    {
                        ShapeCode = dto.ShapeCode,
                        Name1 = dto.Name1,
                        Name2 = dto.Name2,
                        Remark = dto.Remark,
                        CreatedAt = DateTime.Now
                    };

                    _db.SrVehicleShapes.Add(newVehicleShape);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newVehicleShape.VehicleShapeId
                    };

                    return Ok(response);
                }
                else
                {
                    getVehicleShape.Name1 = dto.Name1;
                    getVehicleShape.Name2 = dto.Name2;
                    getVehicleShape.Remark = dto.Remark;
                    getVehicleShape.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Vehicle Shape has been modified successfully",
                        id = getVehicleShape.VehicleShapeId

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

        [HttpDelete("DeleteVehicleShape")]
        public async Task<IActionResult> DeleteVehicleShape(int VehicleShapeId)
        {
            try
            {
                if (VehicleShapeId == 0) return BadRequest("Vehicle ShapeId is equal zero");

                SrVehicleShape getVehicleShape = await _db.SrVehicleShapes.FindAsync(VehicleShapeId);


                if (getVehicleShape == null) return NotFound("Vehicle Shape  is not found");

                getVehicleShape.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Vehicle Shape deleted successfully",
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
