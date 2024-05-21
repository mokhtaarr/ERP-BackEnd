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
    public class CustomerTypeController : ControllerBase
    {
        private readonly ERPContext _db;
        public CustomerTypeController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllCustomerType")]
        public async Task<IActionResult> GetAllCustomerType()
        {
            var query = await (from customerType in _db.MsCustomerTypes
                               where customerType.DeletedAt == null
                               select new customerTypeDto
                               {
                                   CustomerTypeId = customerType.CustomerTypeId,
                                   CustomerTypeCode = customerType.CustomerTypeCode,
                                   CustomerTypeDescA = customerType.CustomerTypeDescA,
                                   CustomerTypeDescE = customerType.CustomerTypeDescE,
                                   CustomerTypeParent = customerType.CustomerTypeParent,
                                   CustomerTypeLevel = customerType.CustomerTypeLevel,
                                   CustomerTypeLevelType = customerType.CustomerTypeLevelType,
                                   CreatedAt = customerType.CreatedAt,
                                   Remarks = customerType.Remarks,
                                   Name_CustomerTypeParent = _db.MsCustomerTypes.Where(p => p.CustomerTypeId == customerType.CustomerTypeParent).Select(c => c.CustomerTypeDescA).SingleOrDefault(),
                                   NameEn_CustomerTypeParent = _db.MsCustomerTypes.Where(p => p.CustomerTypeId == customerType.CustomerTypeParent).Select(c => c.CustomerTypeDescE).SingleOrDefault()

                               }).OrderByDescending(c => c.CreatedAt).ToListAsync();

            return Ok(query);
        }


        [HttpPost("AddCustomerType")]
        public async Task<IActionResult> AddCustomerType(customerTypeDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsCustomerType getCustomerType = await _db.MsCustomerTypes.FindAsync(dto.CustomerTypeId);

                if (getCustomerType == null)
                {


                    MsCustomerType existingCustomerTypeCode =await _db.MsCustomerTypes.Where(c => c.CustomerTypeCode == dto.CustomerTypeCode).FirstOrDefaultAsync();
                    if(existingCustomerTypeCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" كود هذا العميل موجود من قبل {dto.CustomerTypeCode}  ",
                            messageEn = $"This customer Type code already exists {dto.CustomerTypeCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsCustomerType addCustomerType = new MsCustomerType
                    {
                        CustomerTypeCode = dto.CustomerTypeCode,
                        CustomerTypeDescA = dto.CustomerTypeDescA,
                        CustomerTypeDescE = dto.CustomerTypeDescE,
                        CreatedAt = DateTime.Now,
                        CustomerTypeParent = dto.CustomerTypeParent,
                        CustomerTypeLevel = dto.CustomerTypeLevel,
                        CustomerTypeLevelType = dto.CustomerTypeLevelType,
                        Remarks = dto.Remarks
                    };

                    _db.MsCustomerTypes.Add(addCustomerType);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = addCustomerType.CustomerTypeId

                    };

                    return Ok(response);
                }
                else
                {
                    getCustomerType.CustomerTypeDescA = dto.CustomerTypeDescA;
                    getCustomerType.CustomerTypeDescE = dto.CustomerTypeDescE;
                    getCustomerType.CreatedAt = DateTime.Now;
                    getCustomerType.CustomerTypeParent = dto.CustomerTypeParent;
                    getCustomerType.CustomerTypeLevel = dto.CustomerTypeLevel;
                    getCustomerType.CustomerTypeLevelType = dto.CustomerTypeLevelType;
                    getCustomerType.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم تعديل نوع العميل بنجاح",
                        messageEn = "customer type has been modified successfully",
                        id = getCustomerType.CustomerTypeId

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


        [HttpDelete("DeleteCustomerType")]
        public async Task<IActionResult> DeleteCustomerType(int customerTypeId)
        {
            try
            {
                if (customerTypeId == 0) return BadRequest("customerTypeId is equal zero");

                MsCustomerType getCustomerType = await _db.MsCustomerTypes.FindAsync(customerTypeId);

                if (getCustomerType == null) return NotFound("customer Type is not found");

                getCustomerType.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم حذف نوع العميل بنجاح",
                    messageEn = "customer type deleted successfully",
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
