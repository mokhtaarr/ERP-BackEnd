using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ERPContext _db;
        public CustomersController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            return Ok(await _db.MsCustomers.Where(c => c.DeletedAt == null).OrderByDescending(c=>c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllCustomersTypes")]
        public async Task<IActionResult> GetAllCustomersTypes()
        {
            return Ok(await _db.MsCustomerTypes.Where(c => c.DeletedAt == null)
                .Select(t => new {t.CustomerTypeId,t.CustomerTypeCode,t.CustomerTypeDescA,t.CreatedAt}).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }


        [HttpGet("GetAllCostCenter")]
        public async Task<IActionResult> GetAllCostCenter()
        {
            return Ok(await _db.CalCostCenters.Where(c => c.DeletedAt == null)
                .Select(c => new {c.CostCenterId,c.CostCenterCode,c.CostCenterNameA,c.CostCenterNameE,c.CreatedAt}).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }


        [HttpGet("GetAllHrEmployees")]
        public async Task<IActionResult> GetAllHrEmployees()
        {
            return Ok(await _db.HrEmployees.Where(c => c.DeletedAt == null)
                .Select(c => new { c.EmpId,c.EmpCode,c.Name1,c.Name2,c.CreatedAt }).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllCustomerCategory")]
        public async Task<IActionResult> GetAllCustomerCategory()
        {
            return Ok(await _db.MsCustomerCategories.Where(c => c.DeletedAt == null)
                .Select(c => new { c.CustomerCatId, c.CatCode, c.CatDescA, c.CatDescE, c.CreatedAt }).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllCurrency")]
        public async Task<IActionResult> GetAllCurrency()
        {
            return Ok(await _db.MsCurrencies.Where(c => c.DeletedAt == null)
                .Select(c => new { c.CurrencyId,c.CurrencyCode,c.CurrencyDescA,c.CurrencyDescE,c.CreatedAt}).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllCalAccountChart")]
        public async Task<IActionResult> GetAllCalAccountChart()
        {
            return Ok(await _db.CalAccountCharts.Where(c => c.DeletedAt == null && c.AccountType == 3)
                .Select(c => new { c.AccountId, c.AccountCode, c.AccountNameA, c.AccountNameE, c.CreatedAt }).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllCities")]
        public async Task<IActionResult> GetAllCities()
        {
            return Ok(await _db.MsgaCities.Where(c => c.DeletedAt == null)
                .Select(c => new { c.CityId, c.CityCode, c.CityName, c.CreatedAt }).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(msCustomerDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsCustomer getCustomer = await _db.MsCustomers.FindAsync(dto.CustomerId);

                if (getCustomer == null)
                {


                    MsCustomer existingCustomerCode = await _db.MsCustomers.Where(c => c.CustomerCode == dto.CustomerCode).FirstOrDefaultAsync();
                    if (existingCustomerCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.CustomerCode}  ",
                            messageEn = $"This customer code already exists {dto.CustomerCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    MsCustomer newCustomer = new MsCustomer
                    {
                        CustomerCode = dto.CustomerCode,
                        CustomerDescA = dto.CustomerDescA,
                        CustomerDescE = dto.CustomerDescE,
                        CustomerCatId = dto.CustomerCatId,
                        CustomerTypeId = dto.CustomerTypeId,
                        CurrencyId = dto.CurrencyId,
                        CityId = dto.CityId,
                        EmpId = dto.EmpId,
                        CostCenterId = dto.CostCenterId,
                        IsActive = dto.IsActive,
                        CreditPeriod = dto.CreditPeriod,
                        PeriodType = dto.PeriodType,
                        CreditLimit = dto.CreditLimit,
                        Nationality = dto.Nationality,
                        Tel = dto.Tel,
                        Fax = dto.Fax,
                        Address = dto.Address,
                        Address2 = dto.Address2,
                        Address3 = dto.Address3,
                        Tel2 = dto.Tel2,
                        Tel3 = dto.Tel3,
                        Tel4 = dto.Tel4,
                        Tel5 = dto.Tel5,
                        DateOfBirth = dto.DateOfBirth,
                        PassPortNo = dto.PassPortNo,
                        PassPortIssueDate = dto.PassPortIssueDate,
                        PassPortExpiryDate = dto.PassPortExpiryDate,
                        PassPortIssuePlace = dto.PassPortIssuePlace,
                        CarLicenseNo = dto.CarLicenseNo,
                        CarLicenseIssueDate = dto.CarLicenseIssueDate,
                        CarLicenseIssuePlace = dto.CarLicenseIssuePlace,
                        CarLicenseExpiryDate = dto.CarLicenseExpiryDate,
                        DtReg = dto.DtReg,
                        DtRegRenew = dto.DtRegRenew,
                        AddField1 = dto.AddField1,
                        AddField2 = dto.AddField2,
                        AddField3 = dto.AddField3,
                        AddField4 = dto.AddField4,
                        AddField5 = dto.AddField5,
                        ForAdjustOnly = dto.ForAdjustOnly,
                        CreatedAt = DateTime.Now
                    };

                    var customerCategory = _db.MsCustomerCategories.SingleOrDefault(sal => sal.CustomerCatId == dto.CustomerCatId);
                    if(customerCategory is not null) newCustomer.SalPrice = customerCategory?.SalPrice;


                    _db.MsCustomers.Add(newCustomer);
                    await _db.SaveChangesAsync();


                    var customerAccountIds = _db.MsPossettings.Select(p => new
                    {
                        CustomerAccountId = p.CustomerAccountId
                    });

                    var PoosSettingCustomerAccountId = customerAccountIds.FirstOrDefault()?.CustomerAccountId;

                    var accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == PoosSettingCustomerAccountId);

                    var Account = new CalCustAccount()
                    {
                        AccountNameA = accountChart.AccountNameA + "-" + newCustomer.CustomerDescA,
                        AccountNameE = accountChart.AccountNameE + "-" + newCustomer.CustomerDescE,
                        AccountDescription = "BasicAccCode",
                        CustomerId = newCustomer.CustomerId,
                        AccountId = PoosSettingCustomerAccountId,
                        AccountCode = newCustomer.CustomerCode + "-" + accountChart.AccountCode,
                        IsInUse = true,
                        IsPrimeAccount = true,
                    };

                    await _db.CalCustAccounts.AddAsync(Account);
                    _db.SaveChanges();


                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newCustomer.CustomerId
                    };

                    return Ok(response);
                }
                else
                {
                        getCustomer.CustomerDescA = dto.CustomerDescA;
                        getCustomer.CustomerDescE = dto.CustomerDescE;
                        getCustomer.CustomerCatId = dto.CustomerCatId;
                        getCustomer.CustomerTypeId = dto.CustomerTypeId;
                        getCustomer.CurrencyId = dto.CurrencyId;
                        getCustomer.CityId = dto.CityId;
                        getCustomer.EmpId = dto.EmpId;
                        getCustomer.CostCenterId = dto.CostCenterId;
                        getCustomer.IsActive = dto.IsActive;
                        getCustomer.CreditPeriod = dto.CreditPeriod;
                        getCustomer.PeriodType = dto.PeriodType;
                        getCustomer.CreditLimit = dto.CreditLimit;
                        getCustomer.Nationality = dto.Nationality;
                        getCustomer.Tel = dto.Tel;
                        getCustomer.Fax = dto.Fax;
                        getCustomer.Address = dto.Address;
                        getCustomer.Address2 = dto.Address2;
                        getCustomer.Address3 = dto.Address3;
                        getCustomer.Tel2 = dto.Tel2;
                        getCustomer.Tel3 = dto.Tel3;
                        getCustomer.Tel4 = dto.Tel4;
                        getCustomer.Tel5 = dto.Tel5;
                        getCustomer.DateOfBirth = dto.DateOfBirth;
                        getCustomer.PassPortNo = dto.PassPortNo;
                        getCustomer.PassPortIssueDate = dto.PassPortIssueDate;
                        getCustomer.PassPortExpiryDate = dto.PassPortExpiryDate;
                        getCustomer.PassPortIssuePlace = dto.PassPortIssuePlace;
                        getCustomer.CarLicenseNo = dto.CarLicenseNo;
                        getCustomer.CarLicenseIssueDate = dto.CarLicenseIssueDate;
                        getCustomer.CarLicenseIssuePlace = dto.CarLicenseIssuePlace;
                        getCustomer.CarLicenseExpiryDate = dto.CarLicenseExpiryDate;
                        getCustomer.DtReg = dto.DtReg;
                        getCustomer.DtRegRenew = dto.DtRegRenew;
                        getCustomer.AddField1 = dto.AddField1;
                        getCustomer.AddField2 = dto.AddField2;
                        getCustomer.AddField3 = dto.AddField3;
                        getCustomer.AddField4 = dto.AddField4;
                        getCustomer.AddField5 = dto.AddField5;
                        getCustomer.ForAdjustOnly = dto.ForAdjustOnly;
                        getCustomer.UpdateAt = DateTime.Now;
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Customer has been modified successfully",
                        id = getCustomer.CustomerId

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

        [HttpDelete("DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(int customerId)
        {
            try
            {
                if (customerId == 0) return BadRequest("customerId  is equal zero");

                MsCustomer getCustomer = await _db.MsCustomers.FindAsync(customerId);


                if (getCustomer == null) return NotFound("customer is not found");

                getCustomer.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "customer deleted successfully",
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

        [HttpPost("AddCustomerBranch")]
        public async Task<IActionResult> AddCustomerBranch(MsCustomerBranchDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsCustomerBranch getcustomerBranch = await _db.MsCustomerBranches.FindAsync(dto.CustBranchId);

                if(getcustomerBranch == null)
                {
                    MsCustomerBranch existingCustBranchCode = await _db.MsCustomerBranches.Where(c => c.CustBranchCode == dto.CustBranchCode).FirstOrDefaultAsync();
                    if (existingCustBranchCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.CustBranchCode}  ",
                            messageEn = $"This customer branch code already exists {dto.CustBranchCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    MsCustomerBranch newCustomerBranch = new MsCustomerBranch
                    {
                        CustBranchCode = dto.CustBranchCode,
                        CustBranchName1 = dto.CustBranchName1,
                        CustBranchName2 = dto.CustBranchName2,
                        CustomerId = dto.CustomerId,
                        Address = dto.Address,
                        Remarks = dto.Remarks,
                    };

                    _db.MsCustomerBranches.Add(newCustomerBranch);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = dto.CustomerId,
                    };

                    return Ok(response);
                }
                else
                {
                    getcustomerBranch.CustBranchName1 = dto.CustBranchName1;
                    getcustomerBranch.CustBranchName2 = dto.CustBranchName2;
                    getcustomerBranch.Address = dto.Address;
                    getcustomerBranch.Remarks = dto.Remarks;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Customer Branch has been modified successfully",
                        id = getcustomerBranch.CustomerId,

                    };

                    return Ok(response);

                }
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

        [HttpGet("GetAllCustomerBranches")]
        public async Task<IActionResult> GetAllCustomerBranches(int? customerId)
        {
            if (customerId == 0) return BadRequest();
            return Ok(await _db.MsCustomerBranches.Where(c=>c.CustomerId == customerId).OrderByDescending(c=>c.CustBranchId).ToListAsync());
        }

        [HttpDelete("DeleteCustomerBranch")]
        public async Task<IActionResult> DeleteCustomerBranch(int? custBranchId)
        {
            try
            {
                MsCustomerBranch getCustomerBranch =await _db.MsCustomerBranches.FindAsync(custBranchId);
                if (getCustomerBranch is null) return NotFound();

                _db.MsCustomerBranches.Remove(getCustomerBranch);
                await  _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "customer branch deleted successfully",
                    id = getCustomerBranch.CustomerId,
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
