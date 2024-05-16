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
    public class VendorTypeController : ControllerBase
    {
        private readonly ERPContext _db;

        public VendorTypeController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllVendorType")]
        public async Task<IActionResult> GetAllVendorType()
        {
            var query = await  (from vendorType in _db.MsVendorTypes
                         where vendorType.DeletedAt == null
                         select new VendorTypeDto
                         {
                             VendorTypeId = vendorType.VendorTypeId,
                             VendorTypeCode = vendorType.VendorTypeCode,
                             VendorTypeDescA = vendorType.VendorTypeDescA,
                             VendorTypeDescE = vendorType.VendorTypeDescE,
                             VendorTypeParent = vendorType.VendorTypeParent,
                             VendorTypeLevel = vendorType.VendorTypeLevel,
                             Remarks = vendorType.Remarks,
                             VendorTypeLevelType = vendorType.VendorTypeLevelType,
                             Name_VendorTypeParent = _db.MsVendorTypes.Where(v => v.VendorTypeId == vendorType.VendorTypeParent && v.DeletedAt == null).Select(v => v.VendorTypeDescA).SingleOrDefault(),
                             NameEn_VendorTypeParent = _db.MsVendorTypes.Where(v => v.VendorTypeId == vendorType.VendorTypeParent && v.DeletedAt == null).Select(v => v.VendorTypeDescE).SingleOrDefault(),
                             CreatedAt = vendorType.CreatedAt
                         }).OrderByDescending(v => v.CreatedAt).ToListAsync();


            return Ok(query);
        }


        [HttpPost("AddVendorType")]
        public async Task<IActionResult> AddVendorType(VendorTypeDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsVendorType getVendorType = await _db.MsVendorTypes.FindAsync(dto.VendorTypeId);

                if (getVendorType == null)
                {

                    MsVendorType existingVendorType = await _db.MsVendorTypes.Where(v => v.VendorTypeCode == dto.VendorTypeCode).FirstOrDefaultAsync();
                    if(existingVendorType is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" كود هذا المورد موجود من قبل {dto.VendorTypeCode}  ",
                            messageEn = $"This vendor Type code already exists {dto.VendorTypeCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsVendorType newVendor = new MsVendorType
                    {
                        VendorTypeCode = dto.VendorTypeCode,
                        VendorTypeDescA = dto.VendorTypeDescA,
                        VendorTypeDescE = dto.VendorTypeDescE,
                        VendorTypeParent = dto.VendorTypeParent,
                        VendorTypeLevel = dto.VendorTypeLevel,
                        VendorTypeLevelType = dto.VendorTypeLevelType,
                        Remarks = dto.Remarks

                    };

                    _db.MsVendorTypes.Add(newVendor);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                    };

                    return Ok(response);
                }
                else
                {
                    getVendorType.VendorTypeDescA = dto.VendorTypeDescA;
                    getVendorType.VendorTypeDescE = dto.VendorTypeDescE;
                    getVendorType.VendorTypeParent = dto.VendorTypeParent;
                    getVendorType.VendorTypeLevel = dto.VendorTypeLevel;
                    getVendorType.VendorTypeLevelType = dto.VendorTypeLevelType;
                    getVendorType.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم تعديل نوع المورد بنجاح",
                        messageEn = "vendor type has been modified successfully",
                    };

                    return Ok(response);
                }

            }
            catch(Exception ex)
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

        [HttpDelete("DeleteVendorType")]
        public async Task<IActionResult> DeleteVendorType(int? vendorTypeId)
        {
            try
            {
                if (vendorTypeId == null) return BadRequest("vendorTypeId is null");

                MsVendorType getVendor = await _db.MsVendorTypes.FindAsync(vendorTypeId);
                if (getVendor == null) return NotFound("vendor not found");

                getVendor.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم حذف نوع المورد بنجاح",
                    messageEn = "vendor type deleted successfully",
                };

                return Ok(response);
            }
            catch(Exception ex)
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
