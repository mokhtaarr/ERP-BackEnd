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
    public class SuppliersController : ControllerBase
    {
        private readonly ERPContext _db;
        public SuppliersController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllSuppliers")]
        public async Task<IActionResult> GetAllSuppliers()
        {
            return Ok(await _db.MsVendors.Where(c => c.DeletedAt == null).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllVendorTypes")]
        public async Task<IActionResult> GetAllVendorTypes()
        {
            return Ok(await _db.MsVendorTypes.Where(c => c.DeletedAt == null)
                .Select(t => new { t.VendorTypeId, t.VendorTypeCode, t.VendorTypeDescA,t.VendorTypeDescE, t.CreatedAt }).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllVendorsCategories")]
        public async Task<IActionResult> GetAllVendorsCategories()
        {
            return Ok(await _db.MsVendorCategories.Where(c => c.DeletedAt == null)
                .Select(c => new { c.VendorCatId, c.CatCode, c.CatDescA, c.CatDescE, c.CreatedAt }).OrderByDescending(c => c.CreatedAt).ToListAsync());
        }


        [HttpPost("AddVendor")]
        public async Task<IActionResult> AddVendor(VendorDto dto)
        {
            var trans = await _db.Database.BeginTransactionAsync();
            var responseDto = new ResponseDto();
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsVendor getVendor = await _db.MsVendors.FindAsync(dto.VendorId);

                if (getVendor == null)
                {

                    MsVendor existingVendorCode = await _db.MsVendors.Where(c => c.VendorCode == dto.VendorCode).FirstOrDefaultAsync();
                    if (existingVendorCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.VendorCode}  ",
                            messageEn = $"This vendor code already exists {dto.VendorCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsVendor newVendor = new MsVendor
                    {
                        VendorCode = dto.VendorCode,
                        VendorDescA = dto.VendorDescA,
                        VendorDescE = dto.VendorDescE,
                        VendorCatId = dto.VendorCatId,
                        VendorTypeId = dto.VendorTypeId,
                        CurrencyId = dto.CurrencyId,
                        CostCenterId = dto.CostCenterId,
                        CityId = dto.CityId,
                        EmpId = dto.EmpId,
                        AddField1 = dto.AddField1,
                        AddField2 = dto.AddField2,
                        AddField3 = dto.AddField3,
                        AddField4 = dto.AddField4,
                        AddField5 = dto.AddField5,
                        Email = dto.Email,
                        Email2 = dto.Email2,
                        Email3 = dto.Email3,
                        CreditPeriod = dto.CreditPeriod,
                        CreditLimit = dto.CreditLimit,
                        Tel = dto.Tel,
                        Tel2 = dto.Tel2,
                        Tel3 = dto.Tel3,
                        Tel4 = dto.Tel4,
                        Tel5 = dto.Tel5,
                        Fax = dto.Fax,
                        Address = dto.Address,
                        Address2 = dto.Address2,
                        IsActive = dto.IsActive,
                        ForAdjustOnly = dto.ForAdjustOnly,
                        CreatedAt = DateTime.Now
                    };

                    

                    _db.MsVendors.Add(newVendor);
                    await _db.SaveChangesAsync();


                    var accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AccountId);

                    var VendorAccount = new CalVendAccount()
                    {
                        AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                        AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                        AccountDescription = "BasicAccCode",
                        VendorId = newVendor.VendorId,
                        AccountId = dto.AccountId,
                        AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                        IsInUse = true,
                        IsPrimeAccount = true,
                    };

                    await _db.CalVendAccounts.AddAsync(VendorAccount);
                    await _db.SaveChangesAsync();


                    if (dto.AddAccount1 != null)
                    {
                        var accountChart1 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount1);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart1.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart1.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart1.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        var VendorAccount1 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode1",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount1,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(VendorAccount1);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount2 != null)
                    {
                        var accountChart2 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount2);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart2.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart2.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart2.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        var VendorAccount2 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode2",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount2,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(VendorAccount2);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount3 != null)
                    {
                        var accountChart3 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount3);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart3.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart3.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart3.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount3 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode3",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount3,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount3);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount4 != null)
                    {
                        var accountChart4 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount4);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart4.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart4.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart4.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount4 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode4",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount4,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount4);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount5 != null)
                    {
                        var accountChart5 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount5);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart5.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart5.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart5.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount5 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode5",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount5,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount5);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount6 != null)
                    {
                        var accountChart6 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount6);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart6.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart6.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart6.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount6 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode6",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount6,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount6);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount7 != null)
                    {
                        var accountChart7 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount7);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart7.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart7.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart7.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount7 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode7",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount7,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount7);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount8 != null)
                    {
                        var accountChart8 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount8);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart8.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart8.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart8.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount8 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode8",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount8,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount8);
                        await _db.SaveChangesAsync();
                    }

                    if (dto.AddAccount9 != null)
                    {
                        var accountChart9 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount9);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart9.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart9.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart9.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount9 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode9",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount9,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount9);
                        await _db.SaveChangesAsync();
                    }


                    if (dto.AddAccount10 != null)
                    {
                        var accountChart10 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount10);


                        var existAccountCode = newVendor.VendorCode + "-" + accountChart10.AccountCode;
                        CalVendAccount getVendAccount = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                        if (getVendAccount is not null)
                        {
                            responseDto.status = false;
                            responseDto.message = $"{accountChart10.AccountNameA} هذا الحساب تم اضافته مرتين";
                            responseDto.messageEn = $"This account has been added twice {accountChart10.AccountNameE}";

                            throw new Exception("This account has been added twice");
                        }

                        CalVendAccount AddVendorAccount10 = new CalVendAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + newVendor.VendorDescA,
                            AccountNameE = accountChart.AccountNameE + "-" + newVendor.VendorDescE,
                            AccountDescription = "AddAccountCode10",
                            VendorId = newVendor.VendorId,
                            AccountId = dto.AddAccount10,
                            AccountCode = newVendor.VendorCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = false,
                        };

                        await _db.CalVendAccounts.AddAsync(AddVendorAccount10);
                        await _db.SaveChangesAsync();
                    }

                    await trans.CommitAsync();

                    var responseSuccess = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newVendor.VendorId
                    };

                    return Ok(responseSuccess);
                }
                else
                {
                    getVendor.VendorCode = dto.VendorCode;
                    getVendor.VendorDescA = dto.VendorDescA;
                    getVendor.VendorDescE = dto.VendorDescE;
                    getVendor.VendorCatId = dto.VendorCatId;
                    getVendor.VendorTypeId = dto.VendorTypeId;
                    getVendor.CurrencyId = dto.CurrencyId;
                    getVendor.CostCenterId = dto.CostCenterId;
                    getVendor.CityId = dto.CityId;
                    getVendor.EmpId = dto.EmpId;
                    getVendor.AddField1 = dto.AddField1;
                    getVendor.AddField2 = dto.AddField2;
                    getVendor.AddField3 = dto.AddField3;
                    getVendor.AddField4 = dto.AddField4;
                    getVendor.AddField5 = dto.AddField5;
                    getVendor.Email = dto.Email;
                    getVendor.Email2 = dto.Email2;
                    getVendor.Email3 = dto.Email3;
                    getVendor.CreditPeriod = dto.CreditPeriod;
                    getVendor.CreditLimit = dto.CreditLimit;
                    getVendor.Tel = dto.Tel;
                    getVendor.Tel2 = dto.Tel2;
                    getVendor.Tel3 = dto.Tel3;
                    getVendor.Tel4 = dto.Tel4;
                    getVendor.Tel5 = dto.Tel5;
                    getVendor.Fax = dto.Fax;
                    getVendor.Address = dto.Address;
                    getVendor.Address2 = dto.Address2;
                    getVendor.IsActive = dto.IsActive;
                    getVendor.ForAdjustOnly = dto.ForAdjustOnly;
                        

                    if(dto.IsPrimaryAccountChangedForm == true)
                    {
                        CalVendAccount getVendAccountPrimary = await _db.CalVendAccounts
                        .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "BasicAccCode" && c.IsInUse == true);

                        getVendAccountPrimary.IsInUse = false;

                        CalAccountChart accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AccountId);

                        var existPrimaryAccountCode = getVendor.VendorCode + "-" + accountChart.AccountCode;

                        CalVendAccount getPrimaryVendorAccount = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existPrimaryAccountCode && c.VendorId == getVendor.VendorId && c.IsInUse == false);

                        if (getPrimaryVendorAccount is not null)
                        {
                            getPrimaryVendorAccount.IsInUse = true;
                        }
                        else
                        {

                            var VendorAccount = new CalVendAccount()
                            {
                                AccountNameA = accountChart.AccountNameA + "-" + getVendor.VendorDescA,
                                AccountNameE = accountChart.AccountNameE + "-" + getVendor.VendorDescE,
                                AccountDescription = "BasicAccCode",
                                VendorId = getVendor.VendorId,
                                AccountId = dto.AccountId,
                                AccountCode = getVendor.VendorCode + "-" + accountChart.AccountCode,
                                IsInUse = true,
                                IsPrimeAccount = true,
                            };

                            await _db.CalVendAccounts.AddAsync(VendorAccount);
                        }


                    }

                    if (dto.IsAddAccount1ChangedForm == true)
                    {
                        if (dto.AddAccount1 is not null)
                        {

                            CalVendAccount getCalVendAccount1 = await _db.CalVendAccounts
                                .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode1" && c.IsInUse == true);

                            if (getCalVendAccount1 is not null) getCalVendAccount1.IsInUse = false;

                            var accountChart1 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount1);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart1.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount1 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart1.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart1.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode1",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount1,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart1.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount1);
                            }

                        }

                        if (dto.AddAccount1 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                               .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode1" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }



                    if (dto.IsAddAccount2ChangedForm == true)
                    {
                        if (dto.AddAccount2 is not null)
                        {

                            CalVendAccount getCalVendAccount2 = await _db.CalVendAccounts
                                .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode2" && c.IsInUse == true);

                            if (getCalVendAccount2 is not null) getCalVendAccount2.IsInUse = false;

                            var accountChart2 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount2);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart2.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount2 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart2.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart2.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode2",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount2,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart2.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount2);
                            }

                        }

                        if (dto.AddAccount2 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                  .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode2" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }

                    if (dto.IsAddAccount3ChangedForm == true)
                    {
                        if (dto.AddAccount3 is not null)
                        {

                            CalVendAccount getCalVendAccount3 = await _db.CalVendAccounts
                                .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode3" && c.IsInUse == true);

                            if (getCalVendAccount3 is not null) getCalVendAccount3.IsInUse = false;

                            var accountChart3 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount3);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart3.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount3 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart3.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart3.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode3",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount3,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart3.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount3);
                            }


                        }

                        if (dto.AddAccount3 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                 .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode3" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }

                    if (dto.IsAddAccount4ChangedForm == true)
                    {
                        if (dto.AddAccount4 is not null)
                        {

                            CalVendAccount getCalVendAccount4 = await _db.CalVendAccounts
                                .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode4" && c.IsInUse == true);

                            if (getCalVendAccount4 is not null) getCalVendAccount4.IsInUse = false;

                            var accountChart4 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount4);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart4.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount4 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart4.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart4.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode4",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount4,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart4.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount4);
                            }
                        }
                          
                    

                        if (dto.AddAccount4 is null)
                        {
                                CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                 .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode4" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }


                    if (dto.IsAddAccount5ChangedForm == true)
                    {
                        if (dto.AddAccount5 is not null)
                        {
                            CalVendAccount getCalVendAccount5 = await _db.CalVendAccounts
                             .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode5" && c.IsInUse == true);

                            if (getCalVendAccount5 is not null) getCalVendAccount5.IsInUse = false;

                            var accountChart5 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount5);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart5.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount5 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart5.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart5.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode5",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount5,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart5.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount5);
                            }


                        }

                        if (dto.AddAccount5 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                 .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode5" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }

                    if (dto.IsAddAccount6ChangedForm == true)
                    {
                        if (dto.AddAccount6 is not null)
                        {
                            CalVendAccount getCalVendAccount6 = await _db.CalVendAccounts
                             .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode6" && c.IsInUse == true);

                            if (getCalVendAccount6 is not null) getCalVendAccount6.IsInUse = false;

                            var accountChart6 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount6);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart6.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount6 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart6.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart6.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode6",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount6,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart6.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount6);
                            }


                        }

                        if (dto.AddAccount6 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode6" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }


                    if (dto.IsAddAccount7ChangedForm == true)
                    {
                        if (dto.AddAccount7 is not null)
                        {
                            CalVendAccount getCalVendAccount7 = await _db.CalVendAccounts
                             .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode7" && c.IsInUse == true);

                            if (getCalVendAccount7 is not null) getCalVendAccount7.IsInUse = false;

                            var accountChart7 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount7);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart7.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount7 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart7.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart7.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode7",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount7,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart7.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount7);
                            }


                        }

                        if (dto.AddAccount7 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode7" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }


                    if (dto.IsAddAccount8ChangedForm == true)
                    {
                        if (dto.AddAccount8 is not null)
                        {
                            CalVendAccount getCalVendAccount8 = await _db.CalVendAccounts
                             .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode8" && c.IsInUse == true);

                            if (getCalVendAccount8 is not null) getCalVendAccount8.IsInUse = false;

                            var accountChart8 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount8);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart8.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount8 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart8.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart8.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode8",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount8,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart8.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount8);
                            }


                        }

                        if (dto.AddAccount8 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                               .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode8" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }


                    }



                    if (dto.IsAddAccount9ChangedForm == true)
                    {
                        if (dto.AddAccount9 is not null)
                        {
                            CalVendAccount getCalVendAccount9 = await _db.CalVendAccounts
                            .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode9" && c.IsInUse == true);

                            if (getCalVendAccount9 is not null) getCalVendAccount9.IsInUse = false;

                            var accountChart9 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount9);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart9.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount9 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart9.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart9.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode9",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount9,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart9.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount9);
                            }

                        }

                        if (dto.AddAccount9 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                 .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode9" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }

                    }



                    if (dto.IsAddAccount10ChangedForm == true)
                    {
                        if (dto.AddAccount10 is not null)
                        {
                            CalVendAccount getCalVendAccount10 = await _db.CalVendAccounts
                              .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode10" && c.IsInUse == true);

                            if (getCalVendAccount10 is not null) getCalVendAccount10.IsInUse = false;

                            var accountChart10 = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == dto.AddAccount10);

                            var existAccountCode = getVendor.VendorCode + "-" + accountChart10.AccountCode;

                            CalVendAccount getCalVendRecord = _db.CalVendAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                            CalVendAccount getCalVendRecordFalse = _db.CalVendAccounts
                            .FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                            if (getCalVendRecord is not null)
                            {

                                var Bad_response = new
                                {
                                    status = false,
                                    message = "هذا الحساب موجود من قبل",
                                    messageEn = "This account already exists",
                                };

                                return Ok(Bad_response);
                            }
                            else if (getCalVendRecordFalse is not null)
                            {
                                getCalVendRecordFalse.IsInUse = true;

                            }
                            else
                            {
                                var addVendAccount10 = new CalVendAccount()
                                {
                                    AccountNameA = accountChart10.AccountNameA + "-" + getVendor.VendorDescA,
                                    AccountNameE = accountChart10.AccountNameE + "-" + getVendor.VendorDescE,
                                    AccountDescription = "AddAccountCode10",
                                    VendorId = getVendor.VendorId,
                                    AccountId = dto.AddAccount10,
                                    AccountCode = getVendor.VendorCode + "-" + accountChart10.AccountCode,
                                    IsInUse = true,
                                    IsPrimeAccount = false,
                                };

                                await _db.CalVendAccounts.AddAsync(addVendAccount10);
                            }

                        }

                        if (dto.AddAccount10 is null)
                        {
                            CalVendAccount getCalVendAccount = await _db.CalVendAccounts
                                 .FirstOrDefaultAsync(c => c.VendorId == getVendor.VendorId && c.AccountDescription == "AddAccountCode10" && c.IsInUse == true);

                            if (getCalVendAccount is not null) getCalVendAccount.IsInUse = false;
                        }

                    }


                    _db.SaveChanges();
                    await trans.CommitAsync();


                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Customer has been modified successfully",
                        id = getVendor.VendorId

                    };

                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();

                if (responseDto.status != null)
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

      

        [HttpGet("GetAllAdditionalAccount")]
        public async Task<IActionResult> GetAllAdditionalAccount(int? vendorId)
        {
            if (vendorId == null)
            {
                return BadRequest("vendorId is required.");
            }

            List<CalVendAccount> accounts = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true)
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


        [HttpGet("GetMainCharAccount")]
        public async Task<IActionResult> GetMainCharAccount(int? vendorId)
        {
            CalVendAccount getVendAccount = await _db.CalVendAccounts
                .FirstOrDefaultAsync(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "BasicAccCode");
            if (getVendAccount == null) return NotFound();

            return Ok(getVendAccount.AccountId);
        }

        [HttpGet("GeVendorMainAccount")]
        public async Task<IActionResult> GeVendorMainAccount(int vendorId)
        {
            CalVendAccount getVendAccount = await _db.CalVendAccounts
                  .FirstOrDefaultAsync(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "BasicAccCode" && c.IsPrimeAccount == true);
            return Ok(getVendAccount);
        }


        [HttpGet("GetAdditionalaccount1")]
        public async Task<IActionResult> GetAdditionalaccount1(int vendorId)
        {
            CalVendAccount GetAdditionalaccount1 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode1" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount1);
        }


        [HttpGet("GetAdditionalaccount2")]
        public async Task<IActionResult> GetAdditionalaccount2(int vendorId)
        {
            CalVendAccount GetAdditionalaccount2 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode2" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount2);
        }

        [HttpGet("GetAdditionalaccount3")]
        public async Task<IActionResult> GetAdditionalaccount3(int vendorId)
        {
            CalVendAccount GetAdditionalaccount3 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode3" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount3);
        }

        [HttpGet("GetAdditionalaccount4")]
        public async Task<IActionResult> GetAdditionalaccount4(int vendorId)
        {
            CalVendAccount GetAdditionalaccount4 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode4" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount4);
        }

        [HttpGet("GetAdditionalaccount5")]
        public async Task<IActionResult> GetAdditionalaccount5(int vendorId)
        {
            CalVendAccount GetAdditionalaccount5 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode5" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount5);
        }

        [HttpGet("GetAdditionalaccount6")]
        public async Task<IActionResult> GetAdditionalaccount6(int vendorId)
        {
            CalVendAccount GetAdditionalaccount6 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode6" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount6);
        }


        [HttpGet("GetAdditionalaccount7")]
        public async Task<IActionResult> GetAdditionalaccount7(int vendorId)
        {
            CalVendAccount GetAdditionalaccount7 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode7" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount7);
        }


        [HttpGet("GetAdditionalaccount8")]
        public async Task<IActionResult> GetAdditionalaccount8(int vendorId)
        {
            CalVendAccount GetAdditionalaccount8 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode8" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount8);
        }


        [HttpGet("GetAdditionalaccount9")]
        public async Task<IActionResult> GetAdditionalaccount9(int vendorId)
        {
            CalVendAccount GetAdditionalaccount9 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode9" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount9);
        }


        [HttpGet("GetAdditionalaccount10")]
        public async Task<IActionResult> GetAdditionalaccount10(int vendorId)
        {
            CalVendAccount GetAdditionalaccount10 = await _db.CalVendAccounts
                .Where(c => c.VendorId == vendorId && c.IsInUse == true && c.AccountDescription == "AddAccountCode10" && c.IsPrimeAccount == false).FirstOrDefaultAsync();
            return Ok(GetAdditionalaccount10);
        }


        [HttpPost("AddVendorBranch")]
        public async Task<IActionResult> AddVendorBranch(MsVendorBranchDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsVendorBranch getVendorBranch = await _db.MsVendorBranches.FindAsync(dto.VendBranchId);

                if (getVendorBranch == null)
                {
                    MsVendorBranch existingVendorBranchCode = await _db.MsVendorBranches.Where(c => c.VendBranchCode == dto.VendBranchCode).FirstOrDefaultAsync();
                    if (existingVendorBranchCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.VendBranchCode}  ",
                            messageEn = $"This vendor branch code already exists {dto.VendBranchCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    MsVendorBranch newVendorBranch = new MsVendorBranch
                    {
                        VendBranchCode = dto.VendBranchCode,
                        VendBranchName1 = dto.VendBranchName1,
                        VendBranchName2 = dto.VendBranchName2,
                        VendorId = dto.VendorId,
                        Remarks = dto.Remarks,
                        Address = dto.Address
                      
                    };

                    _db.MsVendorBranches.Add(newVendorBranch);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = dto.VendorId
                    };

                    return Ok(response);
                }
                else
                {
                    getVendorBranch.VendBranchName1 = dto.VendBranchName1;
                    getVendorBranch.VendBranchName2 = dto.VendBranchName2;
                    getVendorBranch.VendorId = dto.VendorId;
                    getVendorBranch.Remarks = dto.Remarks;
                    getVendorBranch.Address = dto.Address;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "vendor Branch has been modified successfully",
                        id = getVendorBranch.VendorId,

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


        [HttpGet("GetAllVendorBranches")]
        public async Task<IActionResult> GetAllVendorBranches(int? vendorId)
        {
            if (vendorId == 0) return BadRequest();
            return Ok(await _db.MsVendorBranches.Where(c => c.VendorId == vendorId).OrderByDescending(c => c.VendBranchId).ToListAsync());
        }

        [HttpDelete("DeleteVendorBranch")]
        public async Task<IActionResult> DeleteVendorBranch(int? VendBranchId)
        {
            try
            {
                MsVendorBranch getVEndorBranch = await _db.MsVendorBranches.FindAsync(VendBranchId);
                if (getVEndorBranch is null) return NotFound();

                _db.MsVendorBranches.Remove(getVEndorBranch);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "vendor branch deleted successfully",
                    id = getVEndorBranch.VendorId,
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

        [HttpGet("GetAllVendorContacts")]
        public async Task<IActionResult> GetAllVendorContacts(int? vendorId)
        {
            if (vendorId == 0) return BadRequest();
            return Ok(await _db.MsVendorContacts.Where(c => c.VendorId == vendorId).OrderByDescending(c => c.VendContactId).ToListAsync());
        }


        [HttpPost("AddVendorContact")]
        public async Task<IActionResult> AddVendorContact(MsVendotContactDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsVendorContact getVendorContact = await _db.MsVendorContacts.FindAsync(dto.VendContactId);

                if (getVendorContact == null)
                {
                    MsVendorContact existingContactCode = await _db.MsVendorContacts.Where(c => c.ContactCode == dto.ContactCode).FirstOrDefaultAsync();
                    if (existingContactCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.ContactCode}",
                            messageEn = $"This vendor contact code already exists {dto.ContactCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    MsVendorContact NewVendorContact = new MsVendorContact
                    {
                        ContactCode = dto.ContactCode,
                        VendorId = dto.VendorId,
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

                    _db.MsVendorContacts.Add(NewVendorContact);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = dto.VendorId,
                    };

                    return Ok(response);
                }
                else
                {
                    getVendorContact.ContactName1 = dto.ContactName1;
                    getVendorContact.ContactName2 = dto.ContactName2;
                    getVendorContact.ContactPhone1 = dto.ContactPhone1;
                    getVendorContact.ContactPhone2 = dto.ContactPhone2;
                    getVendorContact.ContactPhone3 = dto.ContactPhone3;
                    getVendorContact.ContactPhone4 = dto.ContactPhone4;
                    getVendorContact.ContactPhone5 = dto.ContactPhone5;
                    getVendorContact.ContactAddress1 = dto.ContactAddress1;
                    getVendorContact.ContactAddress2 = dto.ContactAddress2;
                    getVendorContact.ContactAddress3 = dto.ContactAddress3;
                    getVendorContact.ContactEmail1 = dto.ContactEmail1;
                    getVendorContact.ContactEmail2 = dto.ContactEmail2;
                    getVendorContact.ContactEmail3 = dto.ContactEmail3;
                    getVendorContact.Idno = dto.Idno;
                    getVendorContact.PassPortNo = dto.PassPortNo;
                    getVendorContact.Bank1 = dto.Bank1;
                    getVendorContact.Bank2 = dto.Bank2;
                    getVendorContact.Bank3 = dto.Bank3;
                    getVendorContact.BankAccNo1 = dto.BankAccNo1;
                    getVendorContact.BankAccNo2 = dto.BankAccNo2;
                    getVendorContact.BankAccNo3 = dto.BankAccNo3;
                    getVendorContact.Remark1 = dto.Remark1;
                    getVendorContact.Remark2 = dto.Remark2;
                    getVendorContact.Isprimary = dto.Isprimary;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Customer Contact has been modified successfully",
                        id = getVendorContact.VendorId,

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

        [HttpDelete("DeleteVendorContact")]
        public async Task<IActionResult> DeleteVendorContact(int? VendContactId)
        {
            try
            {
                MsVendorContact getVendorContact = await _db.MsVendorContacts.FindAsync(VendContactId);
                if (getVendorContact is null) return NotFound();

                _db.MsVendorContacts.Remove(getVendorContact);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Vendor Contact deleted successfully",
                    id = getVendorContact.VendorId,
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

        [HttpDelete("DeleteVendor")]
        public async Task<IActionResult> DeleteVendor(int VendorId)
        {
            try
            {
                if (VendorId == 0) return BadRequest("VendorId  is equal zero");

                MsVendor getVendor = await _db.MsVendors.FindAsync(VendorId);


                if (getVendor == null) return NotFound("Vendor is not found");

                getVendor.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Vendor deleted successfully",
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
