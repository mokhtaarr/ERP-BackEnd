using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCategoryController : ControllerBase
    {
        private readonly ERPContext _db;
        public CustomerCategoryController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllCustomerCategory")]
        public async Task<IActionResult> GetAllCustomerCategory()
        {
            return Ok(await _db.MsCustomerCategories.OrderByDescending(c=>c.CreatedAt).Where(c=>c.DeletedAt == null).ToListAsync());
        }

        [HttpPost("AddCustomerCategory")]
        public async Task<IActionResult> AddCustomerCategory(AddCustomerCategoryDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(dto);


                MsCustomerCategory getRecord = await  _db.MsCustomerCategories.FindAsync(dto.CustomerCatId);
                if(getRecord == null)
                {

                    MsCustomerCategory ExisitingCustomerCategoryCode = await _db.MsCustomerCategories.Where(c => c.CatCode == dto.CatCode).FirstOrDefaultAsync();
                    if(ExisitingCustomerCategoryCode is not null) {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" كود هذا العميل موجود من قبل {dto.CatCode}  ",
                            messageEn = $"This customer category code already exists {dto.CatCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }
                

                    MsCustomerCategory newCustomerCategory = new MsCustomerCategory
                    {
                        CatCode = dto.CatCode,
                        CatDescA = dto.CatDescA,
                        CatDescE = dto.CatDescE,
                        Remarks = dto.Remarks,
                        DefaultDisc = dto.DefaultDisc,
                        ReportDiscValu = dto.ReportDiscValu,
                        DiscPercentOrVal = dto.DiscPercentOrVal,
                        IsDiscountByItem = dto.IsDiscountByItem,
                        IsTaxExempted = dto.IsTaxExempted,
                        CreditPeriod = dto.CreditPeriod,
                        CreditLimit = dto.CreditLimit,
                        IsDealer = dto.IsDealer,
                        SalPrice = dto.SalPrice,
                        CreatedAt = DateTime.Now
                    };


                    _db.MsCustomerCategories.Add(newCustomerCategory);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم أضافة فئة العميل بنجاح",
                        messageEn = "The customer category has been added successfully",
                    };

                    return Ok(response);
                }
                else
                {
                    getRecord.CatDescA = dto.CatDescA;
                    getRecord.CatDescE = dto.CatDescE;
                    getRecord.Remarks = dto.Remarks;
                    getRecord.DefaultDisc = dto.DefaultDisc;
                    getRecord.ReportDiscValu = dto.ReportDiscValu;
                    getRecord.DiscPercentOrVal = dto.DiscPercentOrVal;
                    getRecord.IsDiscountByItem = dto.IsDiscountByItem;
                    getRecord.IsTaxExempted = dto.IsTaxExempted;
                    getRecord.CreditPeriod = dto.CreditPeriod;
                    getRecord.CreditLimit = dto.CreditLimit;
                    getRecord.IsDealer = dto.IsDealer;
                    getRecord.SalPrice = dto.SalPrice;
                    getRecord.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();


                    var response = new
                    {
                        status = true,
                        message = "تم تعديل فئة العميل بنجاح",
                        messageEn = "The customer category has been modified successfully",
                    };

                    return Ok(response);
                }

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

        [HttpDelete("DeleteCustomerCategory")]
        public async Task<IActionResult> DeleteCustomerCategory(int? CustomerCatId)
        {
            try
            {
                if (CustomerCatId == 0) return BadRequest("customerCatId equal zero");
                MsCustomerCategory get_CustomerCategory_For_Delete = await _db.MsCustomerCategories.FindAsync(CustomerCatId);
                
                
                    get_CustomerCategory_For_Delete.DeletedAt = DateTime.Now;
                    await _db.SaveChangesAsync();
                    var response = new
                    {
                        status = true,
                        message = "تم حذف فئة العميل بنجاح",
                        messageEn = "The customer category was deleted successfully",
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
