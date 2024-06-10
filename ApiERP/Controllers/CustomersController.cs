using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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

        [HttpGet("GetMainCharAccount")]
        public async Task<IActionResult> GetMainCharAccount(int? customerId)
        {
            CalCustAccount getCalCustAccount = await _db.CalCustAccounts
                .FirstOrDefaultAsync(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "BasicAccCode");
            if (getCalCustAccount == null) return NotFound();

            return Ok(getCalCustAccount.AccountId);
        }

        [HttpGet("GetAllAdditionalAccount")]
        public async Task<IActionResult> GetAllAdditionalAccount(int? customerId)
        {
            if (customerId == null)
            {
                return BadRequest("CustomerId is required.");
            }

            var accounts = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true)
                .ToListAsync();

            var result = new
            {
                AddAccountCode1 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode1")?.AccountId,
                AddAccountCode2 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode2")?.AccountId,
                AddAccountCode3 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode3")?.AccountId,
                AddAccountCode4 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode4")?.AccountId,
                AddAccountCode5 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode5")?.AccountId,
                AddAccountCode6 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode6")?.AccountId,
                AddAccountCode7 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode7")?.AccountId,
                AddAccountCode8 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode8")?.AccountId,
                AddAccountCode9 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode9")?.AccountId,
                AddAccountCode10 = accounts.FirstOrDefault(c => c.AccountDescription == "AddAccountCode10")?.AccountId
            };

            return Ok(result);
        }


        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(msCustomerDto dto)
        {
            var trans = await _db.Database.BeginTransactionAsync();
            var responseDto = new ResponseDto();
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


                    var accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AccountId);

                    var Account = new CalCustAccount()
                    {
                        AccountNameA = accountChart.AccountNameA + "-" + newCustomer.CustomerDescA,
                        AccountNameE = accountChart.AccountNameE + "-" + newCustomer.CustomerDescE,
                        AccountDescription = "BasicAccCode",
                        CustomerId = newCustomer.CustomerId,
                        AccountId = dto.AccountId,
                        AccountCode = newCustomer.CustomerCode + "-" + accountChart.AccountCode,
                        IsInUse = true,
                        IsPrimeAccount = true,
                    };

                    await _db.CalCustAccounts.AddAsync(Account);
                    await _db.SaveChangesAsync();


                    if (dto.AddAccount1 != null)
                    {
                        var accountChart1 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount1);


                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart1.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if(getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart1.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart1.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        var AddCustAccount1 = new CalCustAccount()
                        {
                            AccountNameA = accountChart1.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart1.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode1",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount1,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart1.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount1);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount2 != null)
                    {
                        var accountChart2 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount2);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart2.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart2.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart2.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount2 = new CalCustAccount()
                        {
                            AccountNameA = accountChart2.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart2.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode2",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount2,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart2.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount2);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount3 != null)
                    {
                        var accountChart3 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount3);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart3.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart3.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart3.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount3 = new CalCustAccount()
                        {
                            AccountNameA = accountChart3.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart3.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode3",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount3,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart3.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount3);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount4 != null)
                    {
                        var accountChart4 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount4);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart4.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart4.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart4.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount4 = new CalCustAccount()
                        {
                            AccountNameA = accountChart4.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart4.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode4",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount4,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart4.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount4);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount5 != null)
                    {
                        var accountChart5 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount5);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart5.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart5.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart5.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        var AddCustAccount5 = new CalCustAccount()
                        {
                            AccountNameA = accountChart5.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart5.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode5",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount5,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart5.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount5);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount6 != null)
                    {
                        var accountChart6 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount6);
                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart6.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart6.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart6.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount6 = new CalCustAccount()
                        {
                            AccountNameA = accountChart6.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart6.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode6",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount6,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart6.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount6);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount7 != null)
                    {
                        var accountChart7 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount7);
                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart7.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart7.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart7.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount7 = new CalCustAccount()
                        {
                            AccountNameA = accountChart7.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart7.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode7",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount7,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart7.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount7);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount8 != null)
                    {
                        var accountChart8 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount8);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart8.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart8.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart8.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount8 = new CalCustAccount()
                        {
                            AccountNameA = accountChart8.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart8.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode8",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount8,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart8.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount8);
                        await _db.SaveChangesAsync();

                    }

                    if (dto.AddAccount9 != null)
                    {
                        var accountChart9 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount9);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart9.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart9.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart9.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount9 = new CalCustAccount()
                        {
                            AccountNameA = accountChart9.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart9.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode9",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount9,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart9.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount9);
                        await _db.SaveChangesAsync();

                    }


                    if (dto.AddAccount10 != null)
                    {
                        var accountChart10 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount10);

                        var existAccountCode = newCustomer.CustomerCode + "-" + accountChart10.AccountCode;
                        CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getCalCustRecord is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart10.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart10.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }


                        var AddCustAccount10 = new CalCustAccount()
                        {
                            AccountNameA = accountChart10.AccountNameA + "-" + newCustomer.CustomerDescA,
                            AccountNameE = accountChart10.AccountNameE + "-" + newCustomer.CustomerDescE,
                            AccountDescription = "AddAccountCode10",
                            CustomerId = newCustomer.CustomerId,
                            AccountId = dto.AddAccount10,
                            AccountCode = newCustomer.CustomerCode + "-" + accountChart10.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalCustAccounts.AddAsync(AddCustAccount10);
                        await _db.SaveChangesAsync();
                    }

                    await trans.CommitAsync();

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

                    var customerCategory = _db.MsCustomerCategories.SingleOrDefault(sal => sal.CustomerCatId == dto.CustomerCatId);
                    if (customerCategory is not null) getCustomer.SalPrice = customerCategory?.SalPrice;

                    if(dto.IsPrimaryAccountChangedForm == true)
                    {
                        CalCustAccount getCalCustAccountPrimary = await _db.CalCustAccounts
                        .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "BasicAccCode" && c.IsInUse == true);

                        getCalCustAccountPrimary.IsInUse = false;

                        var accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AccountId);

                        var existPrimaryAccountCode = getCustomer.CustomerCode + "-" + accountChart.AccountCode;

                        CalCustAccount getPrimaryCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existPrimaryAccountCode);

                        if (getPrimaryCalCustRecord is not null)
                        {
                            getPrimaryCalCustRecord.IsInUse = true;
                        }
                        else
                        {

                            var AddCustAccount = new CalCustAccount()
                            {
                                AccountNameA = accountChart.AccountNameA + "-" + getCustomer.CustomerDescA,
                                AccountNameE = accountChart.AccountNameE + "-" + getCustomer.CustomerDescE,
                                AccountDescription = "BasicAccCode",
                                CustomerId = getCustomer.CustomerId,
                                AccountId = dto.AccountId,
                                AccountCode = getCustomer.CustomerCode + "-" + accountChart.AccountCode,
                                IsInUse = true,
                                IsPrimeAccount = true,
                            };

                            await _db.CalCustAccounts.AddAsync(AddCustAccount);
                        }


                    }

                    if (dto.IsAddAccount1ChangedForm == true)
                    {
                        if (dto.AddAccount1 is not null)
                        {

                            CalCustAccount getCalCustAccount1 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode1" && c.IsInUse == true);

                            if (getCalCustAccount1 is not null) getCalCustAccount1.IsInUse = false;

                            var accountChart1 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount1);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart1.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if(getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount1 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart1.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart1.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode1",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount1,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart1.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount1);
                            }

                        }

                        if (dto.AddAccount1 is null)
                        {
                            CalCustAccount getCalCustAccount1 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode1" && c.IsInUse == true);

                            if (getCalCustAccount1 is not null) getCalCustAccount1.IsInUse = false;
                        }


                    }



                    if (dto.IsAddAccount2ChangedForm == true)
                    {
                        if (dto.AddAccount2 is not null)
                        {

                            CalCustAccount getCalCustAccount2 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode2" && c.IsInUse == true);

                            if (getCalCustAccount2 is not null) getCalCustAccount2.IsInUse = false;

                            var accountChart2= _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount2);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart2.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode &&  c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount2 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart2.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart2.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode2",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount2,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart2.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount2);
                            }

                        }

                        if (dto.AddAccount2 is null)
                        {
                            CalCustAccount getCalCustAccount2 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode2" && c.IsInUse == true);

                            if (getCalCustAccount2 is not null) getCalCustAccount2.IsInUse = false;
                        }


                    }

                    if (dto.IsAddAccount3ChangedForm == true)
                    {
                        if (dto.AddAccount3 is not null)
                        {

                            CalCustAccount getCalCustAccount3 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode3" && c.IsInUse == true);

                            if (getCalCustAccount3 is not null) getCalCustAccount3.IsInUse = false;

                            var accountChart3 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount3);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart3.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount3 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart3.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart3.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode3",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount3,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart3.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount3);
                            }

                        }

                        if (dto.AddAccount3 is null)
                        {
                            CalCustAccount getCalCustAccount1 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode3" && c.IsInUse == true);

                            if (getCalCustAccount1 is not null) getCalCustAccount1.IsInUse = false;
                        }


                    }

                    if (dto.IsAddAccount4ChangedForm == true)
                    {
                        if (dto.AddAccount4 is not null)
                        {

                            CalCustAccount getCalCustAccount4 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode4" && c.IsInUse == true);

                            if (getCalCustAccount4 is not null) getCalCustAccount4.IsInUse = false;

                            var accountChart4 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount4);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart4.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount4 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart4.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart4.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode4",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount4,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart4.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount4);
                            }

                        }

                        if (dto.AddAccount4 is null)
                        {
                            CalCustAccount getCalCustAccount4 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode4" && c.IsInUse == true);

                            if (getCalCustAccount4 is not null) getCalCustAccount4.IsInUse = false;
                        }


                    }


                    if (dto.IsAddAccount5ChangedForm == true)
                    {
                        if (dto.AddAccount5 is not null)
                        {

                            CalCustAccount getCalCustAccount5 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode5" && c.IsInUse == true);

                            if (getCalCustAccount5 is not null) getCalCustAccount5.IsInUse = false;

                            var accountChart5 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount5);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart5.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount5 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart5.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart5.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode5",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount5,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart5.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount5);
                            }

                        }

                        if (dto.AddAccount5 is null)
                        {
                            CalCustAccount getCalCustAccount5 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode5" && c.IsInUse == true);

                            if (getCalCustAccount5 is not null) getCalCustAccount5.IsInUse = false;
                        }


                    }

                    if (dto.IsAddAccount6ChangedForm == true)
                    {
                        if (dto.AddAccount6 is not null)
                        {

                            CalCustAccount getCalCustAccount6 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode6" && c.IsInUse == true);

                            if (getCalCustAccount6 is not null) getCalCustAccount6.IsInUse = false;

                            var accountChart6 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount6);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart6.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount6 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart6.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart6.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode6",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount6,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart6.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount6);
                            }

                        }

                        if (dto.AddAccount6 is null)
                        {
                            CalCustAccount getCalCustAccount6 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode6" && c.IsInUse == true);

                            if (getCalCustAccount6 is not null) getCalCustAccount6.IsInUse = false;
                        }


                    }


                    if (dto.IsAddAccount7ChangedForm == true)
                    {
                        if (dto.AddAccount7 is not null)
                        {

                            CalCustAccount getCalCustAccount7 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode7" && c.IsInUse == true);

                            if (getCalCustAccount7 is not null) getCalCustAccount7.IsInUse = false;

                            var accountChart7 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount7);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart7.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount7 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart7.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart7.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode7",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount7,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart7.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount7);
                            }

                        }

                        if (dto.AddAccount7 is null)
                        {
                            CalCustAccount getCalCustAccount6 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode7" && c.IsInUse == true);

                            if (getCalCustAccount6 is not null) getCalCustAccount6.IsInUse = false;
                        }


                    }


                    if (dto.IsAddAccount8ChangedForm == true)
                    {
                        if (dto.AddAccount8 is not null)
                        {

                            CalCustAccount getCalCustAccount8 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode8" && c.IsInUse == true);

                            if (getCalCustAccount8 is not null) getCalCustAccount8.IsInUse = false;

                            var accountChart8 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount8);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart8.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount8 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart8.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart8.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode8",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount8,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart8.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount8);
                            }

                        }

                        if (dto.AddAccount8 is null)
                        {
                            CalCustAccount getCalCustAccount8 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode8" && c.IsInUse == true);

                            if (getCalCustAccount8 is not null) getCalCustAccount8.IsInUse = false;
                        }


                    }



                    if (dto.IsAddAccount9ChangedForm == true)
                    {
                        if (dto.AddAccount9 is not null)
                        {

                            CalCustAccount getCalCustAccount9 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode9" && c.IsInUse == true);

                            if (getCalCustAccount9 is not null) getCalCustAccount9.IsInUse = false;

                            var accountChart9 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount9);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart9.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount9 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart9.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart9.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode9",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount9,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart9.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount9);
                            }

                        }

                        if (dto.AddAccount9 is null)
                        {
                            CalCustAccount getCalCustAccount9 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode9" && c.IsInUse == true);

                            if (getCalCustAccount9 is not null) getCalCustAccount9.IsInUse = false;
                        }

                    }



                    if (dto.IsAddAccount10ChangedForm == true)
                    {
                        if (dto.AddAccount10 is not null)
                        {

                            CalCustAccount getCalCustAccount10 = await _db.CalCustAccounts
                                .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode10" && c.IsInUse == true);

                            if (getCalCustAccount10 is not null) getCalCustAccount10.IsInUse = false;

                            var accountChart10 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount10);

                            var existAccountCode = getCustomer.CustomerCode + "-" + accountChart10.AccountCode;

                            CalCustAccount getCalCustRecord = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalCustAccount getCalCustRecordFalse = _db.CalCustAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalCustRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalCustRecordFalse is not null)
                            {
                                getCalCustRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var AddCustAccount10 = new CalCustAccount()
                                {
                                    AccountNameA = accountChart10.AccountNameA + "-" + getCustomer.CustomerDescA,
                                    AccountNameE = accountChart10.AccountNameE + "-" + getCustomer.CustomerDescE,
                                    AccountDescription = "AddAccountCode10",
                                    CustomerId = getCustomer.CustomerId,
                                    AccountId = dto.AddAccount10,
                                    AccountCode = getCustomer.CustomerCode + "-" + accountChart10.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalCustAccounts.AddAsync(AddCustAccount10);
                            }

                        }

                        if (dto.AddAccount10 is null)
                        {
                            CalCustAccount getCalCustAccount10 = await _db.CalCustAccounts
                               .FirstOrDefaultAsync(c => c.CustomerId == getCustomer.CustomerId && c.AccountDescription == "AddAccountCode10" && c.IsInUse == true);

                            if (getCalCustAccount10 is not null) getCalCustAccount10.IsInUse = false;
                        }

                    }


                    _db.SaveChanges();
                    await trans.CommitAsync();


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
                await trans.RollbackAsync();

                if(responseDto.status != null)
                {
                    return Ok(responseDto);
                }
                else
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



        [HttpGet("GetAllCustomerContact")]
        public async Task<IActionResult> GetAllCustomerContact(int? customerId)
        {
            if (customerId == 0) return BadRequest();
            return Ok(await _db.MsCustomerContacts.Where(c => c.CustomerId == customerId).OrderByDescending(c => c.CustContactId).ToListAsync());
        }


        [HttpPost("AddCustomerContact")]
        public async Task<IActionResult> AddCustomerContact(MsCustomerContactDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsCustomerContact getcustomerContact = await _db.MsCustomerContacts.FindAsync(dto.CustContactId);

                if (getcustomerContact == null)
                {
                    MsCustomerContact existingContactCode = await _db.MsCustomerContacts.Where(c => c.ContactCode == dto.ContactCode).FirstOrDefaultAsync();
                    if (existingContactCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.ContactCode}",
                            messageEn = $"This customer contact code already exists {dto.ContactCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    MsCustomerContact newCustomerContact = new MsCustomerContact
                    {
                        ContactCode = dto.ContactCode,
                        CustomerId = dto.CustomerId,
                        ContactName1 = dto.ContactName1,
                        ContactName2 = dto.ContactName2,
                        ContactPhone1 = dto.ContactPhone1,
                        ContactPhone2 = dto.ContactPhone2,
                        ContactPhone3 = dto.ContactPhone3,
                        ContactPhone4 = dto.ContactPhone4,
                        ContactPhone5 = dto.ContactPhone5,
                        ContactAddress1 = dto.ContactAddress1,
                        ContactAddress2 = dto.ContactAddress2,
                        ContactAddress3 = dto.ContactAddress3,
                        ContactEmail1 = dto.ContactEmail1,
                        ContactEmail2 = dto.ContactEmail2,
                        ContactEmail3 = dto.ContactEmail3,
                        Idno = dto.Idno,
                        PassPortNo = dto.PassPortNo,
                        Bank1 = dto.Bank1,
                        Bank2 = dto.Bank2,
                        Bank3 = dto.Bank3,
                        BankAccNo1 = dto.BankAccNo1,
                        BankAccNo2 = dto.BankAccNo2,
                        BankAccNo3 = dto.BankAccNo3,
                        Remark1 = dto.Remark1,
                        Remark2 = dto.Remark2,
                        Isprimary = dto.Isprimary
                    };

                    _db.MsCustomerContacts.Add(newCustomerContact);
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
                    getcustomerContact.ContactName1 = dto.ContactName1;
                    getcustomerContact.ContactName2 = dto.ContactName2;
                    getcustomerContact.ContactPhone1 = dto.ContactPhone1;
                    getcustomerContact.ContactPhone2 = dto.ContactPhone2;
                    getcustomerContact.ContactPhone3 = dto.ContactPhone3;
                    getcustomerContact.ContactPhone4 = dto.ContactPhone4;
                    getcustomerContact.ContactPhone5 = dto.ContactPhone5;
                    getcustomerContact.ContactAddress1 = dto.ContactAddress1;
                    getcustomerContact.ContactAddress2 = dto.ContactAddress2;
                    getcustomerContact.ContactAddress3 = dto.ContactAddress3;
                    getcustomerContact.ContactEmail1 = dto.ContactEmail1;
                    getcustomerContact.ContactEmail2 = dto.ContactEmail2;
                    getcustomerContact.ContactEmail3 = dto.ContactEmail3;
                    getcustomerContact.Idno = dto.Idno;
                    getcustomerContact.PassPortNo = dto.PassPortNo;
                    getcustomerContact.Bank1 = dto.Bank1;
                    getcustomerContact.Bank2 = dto.Bank2;
                    getcustomerContact.Bank3 = dto.Bank3;
                    getcustomerContact.BankAccNo1 = dto.BankAccNo1;
                    getcustomerContact.BankAccNo2 = dto.BankAccNo2;
                    getcustomerContact.BankAccNo3 = dto.BankAccNo3;
                    getcustomerContact.Remark1 = dto.Remark1;
                    getcustomerContact.Remark2 = dto.Remark2;
                    getcustomerContact.Isprimary = dto.Isprimary;
                    
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Customer Contact has been modified successfully",
                        id = getcustomerContact.CustomerId,

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


        [HttpDelete("DeleteCustomerContact")]
        public async Task<IActionResult> DeleteCustomerContact(int? custContactId)
        {
            try
            {
                MsCustomerContact getCustomerContact = await _db.MsCustomerContacts.FindAsync(custContactId);
                if (getCustomerContact is null) return NotFound();

                _db.MsCustomerContacts.Remove(getCustomerContact);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "customer Contact deleted successfully",
                    id = getCustomerContact.CustomerId,
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

        [HttpGet("GetUserMainAccount")]
        public async Task<IActionResult> GetUserMainAccount(int customerId)
        {
            CalCustAccount GetMainAccount = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "BasicAccCode" && c.IsPrimeAccount == true).FirstOrDefaultAsync();
            return Ok(GetMainAccount);
        }

        [HttpGet("GetAdditionalaccount1")]
        public async Task<IActionResult> GetAdditionalaccount1(int customerId)
        {
            CalCustAccount GetAdditionalaccount1 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode1" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount1);
        }

        [HttpGet("GetAdditionalaccount2")]
        public async Task<IActionResult> GetAdditionalaccount2(int customerId)
        {
            CalCustAccount GetAdditionalaccount2 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode2" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount2);
        }

        [HttpGet("GetAdditionalaccount3")]
        public async Task<IActionResult> GetAdditionalaccount3(int customerId)
        {
            CalCustAccount GetAdditionalaccount3 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode3" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount3);
        }

        [HttpGet("GetAdditionalaccount4")]
        public async Task<IActionResult> GetAdditionalaccount4(int customerId)
        {
            CalCustAccount GetAdditionalaccount4 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode4" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount4);
        }

        [HttpGet("GetAdditionalaccount5")]
        public async Task<IActionResult> GetAdditionalaccount5(int customerId)
        {
            CalCustAccount GetAdditionalaccount5 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode5" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount5);
        }

        [HttpGet("GetAdditionalaccount6")]
        public async Task<IActionResult> GetAdditionalaccount6(int customerId)
        {
            CalCustAccount GetAdditionalaccount6 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode6" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount6);
        }


        [HttpGet("GetAdditionalaccount7")]
        public async Task<IActionResult> GetAdditionalaccount7(int customerId)
        {
            CalCustAccount GetAdditionalaccount7 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode7" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount7);
        }

        [HttpGet("GetAdditionalaccount8")]
        public async Task<IActionResult> GetAdditionalaccount8(int customerId)
        {
            CalCustAccount GetAdditionalaccount8 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode8" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount8);
        }

        [HttpGet("GetAdditionalaccount9")]
        public async Task<IActionResult> GetAdditionalaccount9(int customerId)
        {
            CalCustAccount GetAdditionalaccount9 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode9" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount9);
        }

        [HttpGet("GetAdditionalaccount10")]
        public async Task<IActionResult> GetAdditionalaccount10(int customerId)
        {
            CalCustAccount GetAdditionalaccount10 = await _db.CalCustAccounts
                .Where(c => c.CustomerId == customerId && c.IsInUse == true && c.AccountDescription == "AddAccountCode10" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount10);
        }



    }
}
