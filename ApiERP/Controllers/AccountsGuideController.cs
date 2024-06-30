using AutoMapper;
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
    public class AccountsGuideController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IMapper _mapper;

        public AccountsGuideController(ERPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet("GetAllAccounts")]
        public async Task<IActionResult> GetAllAccounts()
        {
            var query = await (from account in _db.CalAccountCharts
                               where account.DeletedAt == null && account.MainAccountId == null
                               select new
                               {
                                   Type = "parent",
                                   AccountId = account.AccountId,
                                   AccountCode = account.AccountCode,
                                   AccountNameA = account.AccountNameA,
                                   AccountNameE = account.AccountNameE,
                                   MainAccountId = account.MainAccountId,
                                   AccountLevel = account.AccountLevel,
                                   AccountType = account.AccountType,
                                   AccountNature = account.AccountNature,
                                   AccountGroup = account.AccountGroup,
                                   AccCashFlow = account.AccCashFlow,
                                   CalcMethod = account.CalcMethod,
                                   CurrencyId = account.CurrencyId,
                                   Rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == account.CurrencyId).Rate,
                                   Aid = account.Aid,
                                   AccBulkAccount = account.AccBulkAccount,
                                   AccountCategory = account.AccountCategory,
                                   CostCentersDistribute = account.CostCentersDistribute,
                                   CurrencyReevaluation = account.CurrencyReevaluation,
                                   AccountStopped = account.AccountStopped,
                                   RemarksA = account.RemarksA,
                                   RemarksE = account.RemarksE,
                                   OpenningBalanceDepit = account.OpenningBalanceDepit,
                                   OpenningBalanceCredit = account.OpenningBalanceCredit,
                                   AccCurrTrancCredit = account.AccCurrTrancCredit,
                                   AccCurrTrancDepit = account.AccCurrTrancDepit,
                                   AccTotaCredit = account.AccTotaCredit,
                                   AccTotalDebit = account.AccTotalDebit,
                                   BalanceDebitLocal = account.BalanceDebitLocal,
                                   BalanceCreditLocal = account.BalanceCreditLocal,
                                   OpenningBalanceCreditCurncy = account.OpenningBalanceCreditCurncy,
                                   OpenningBalanceDepitCurncy = account.OpenningBalanceDepitCurncy,
                                   AccCurrTrancCreditCurncy = account.AccCurrTrancCreditCurncy,
                                   AccCurrTrancDepitCurncy = account.AccCurrTrancDepitCurncy,
                                   AccTotaCreditCurncy = account.AccTotaCreditCurncy,
                                   AccTotalDebitCurncy = account.AccTotalDebitCurncy,
                                   BalanceCreditCurncy = account.BalanceCreditCurncy,
                                   BalanceDebitCurncy = account.BalanceDebitCurncy,
                                   AccApproxim = account.AccApproxim,
                                   CreatedAt = account.CreatedAt,
                                   children = _db.CalAccountCharts.Where(d => d.DeletedAt == null && d.MainAccountId == account.AccountId)
                                   .Select(account => new
                                   {
                                       Type = "children1",
                                       AccountId = account.AccountId,
                                       AccountCode = account.AccountCode,
                                       AccountNameA = account.AccountNameA,
                                       AccountNameE = account.AccountNameE,
                                       MainAccountId = account.MainAccountId,
                                       AccountLevel = account.AccountLevel,
                                       AccountType = account.AccountType,
                                       AccountNature = account.AccountNature,
                                       AccountGroup = account.AccountGroup,
                                       AccCashFlow = account.AccCashFlow,
                                       CalcMethod = account.CalcMethod,
                                       CurrencyId = account.CurrencyId,
                                       Rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == account.CurrencyId).Rate,
                                       Aid = account.Aid,
                                       AccBulkAccount = account.AccBulkAccount,
                                       AccountCategory = account.AccountCategory,
                                       CostCentersDistribute = account.CostCentersDistribute,
                                       CurrencyReevaluation = account.CurrencyReevaluation,
                                       AccountStopped = account.AccountStopped,
                                       RemarksA = account.RemarksA,
                                       RemarksE = account.RemarksE,
                                       OpenningBalanceDepit = account.OpenningBalanceDepit,
                                       OpenningBalanceCredit = account.OpenningBalanceCredit,
                                       AccCurrTrancCredit = account.AccCurrTrancCredit,
                                       AccCurrTrancDepit = account.AccCurrTrancDepit,
                                       AccTotaCredit = account.AccTotaCredit,
                                       AccTotalDebit = account.AccTotalDebit,
                                       BalanceDebitLocal = account.BalanceDebitLocal,
                                       BalanceCreditLocal = account.BalanceCreditLocal,
                                       OpenningBalanceCreditCurncy = account.OpenningBalanceCreditCurncy,
                                       OpenningBalanceDepitCurncy = account.OpenningBalanceDepitCurncy,
                                       AccCurrTrancCreditCurncy = account.AccCurrTrancCreditCurncy,
                                       AccCurrTrancDepitCurncy = account.AccCurrTrancDepitCurncy,
                                       AccTotaCreditCurncy = account.AccTotaCreditCurncy,
                                       AccTotalDebitCurncy = account.AccTotalDebitCurncy,
                                       BalanceCreditCurncy = account.BalanceCreditCurncy,
                                       BalanceDebitCurncy = account.BalanceDebitCurncy,
                                       AccApproxim = account.AccApproxim,
                                       CreatedAt = account.CreatedAt,
                                       children = _db.CalAccountCharts.Where(d => d.DeletedAt == null && d.MainAccountId == account.AccountId)
                                                     .Select(account => new
                                                     {
                                                         Type = "children2",
                                                         AccountId = account.AccountId,
                                                         AccountCode = account.AccountCode,
                                                         AccountNameA = account.AccountNameA,
                                                         AccountNameE = account.AccountNameE,
                                                         MainAccountId = account.MainAccountId,
                                                         AccountLevel = account.AccountLevel,
                                                         AccountType = account.AccountType,
                                                         AccountNature = account.AccountNature,
                                                         AccountGroup = account.AccountGroup,
                                                         AccCashFlow = account.AccCashFlow,
                                                         CalcMethod = account.CalcMethod,
                                                         CurrencyId = account.CurrencyId,
                                                         Rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == account.CurrencyId).Rate,
                                                         Aid = account.Aid,
                                                         AccBulkAccount = account.AccBulkAccount,
                                                         AccountCategory = account.AccountCategory,
                                                         CostCentersDistribute = account.CostCentersDistribute,
                                                         CurrencyReevaluation = account.CurrencyReevaluation,
                                                         AccountStopped = account.AccountStopped,
                                                         RemarksA = account.RemarksA,
                                                         RemarksE = account.RemarksE,
                                                         OpenningBalanceDepit = account.OpenningBalanceDepit,
                                                         OpenningBalanceCredit = account.OpenningBalanceCredit,
                                                         AccCurrTrancCredit = account.AccCurrTrancCredit,
                                                         AccCurrTrancDepit = account.AccCurrTrancDepit,
                                                         AccTotaCredit = account.AccTotaCredit,
                                                         AccTotalDebit = account.AccTotalDebit,
                                                         BalanceDebitLocal = account.BalanceDebitLocal,
                                                         BalanceCreditLocal = account.BalanceCreditLocal,
                                                         OpenningBalanceCreditCurncy = account.OpenningBalanceCreditCurncy,
                                                         OpenningBalanceDepitCurncy = account.OpenningBalanceDepitCurncy,
                                                         AccCurrTrancCreditCurncy = account.AccCurrTrancCreditCurncy,
                                                         AccCurrTrancDepitCurncy = account.AccCurrTrancDepitCurncy,
                                                         AccTotaCreditCurncy = account.AccTotaCreditCurncy,
                                                         AccTotalDebitCurncy = account.AccTotalDebitCurncy,
                                                         BalanceCreditCurncy = account.BalanceCreditCurncy,
                                                         BalanceDebitCurncy = account.BalanceDebitCurncy,
                                                         AccApproxim = account.AccApproxim,
                                                         CreatedAt = account.CreatedAt,
                                                         children = _db.CalAccountCharts.Where(d => d.DeletedAt == null && d.MainAccountId == account.AccountId)
                                                             .Select(account => new
                                                             {
                                                                 Type = "children3",
                                                                 AccountId = account.AccountId,
                                                                 AccountCode = account.AccountCode,
                                                                 AccountNameA = account.AccountNameA,
                                                                 AccountNameE = account.AccountNameE,
                                                                 MainAccountId = account.MainAccountId,
                                                                 AccountLevel = account.AccountLevel,
                                                                 AccountType = account.AccountType,
                                                                 AccountNature = account.AccountNature,
                                                                 AccountGroup = account.AccountGroup,
                                                                 AccCashFlow = account.AccCashFlow,
                                                                 CalcMethod = account.CalcMethod,
                                                                 CurrencyId = account.CurrencyId,
                                                                 Rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == account.CurrencyId).Rate,
                                                                 Aid = account.Aid,
                                                                 AccBulkAccount = account.AccBulkAccount,
                                                                 AccountCategory = account.AccountCategory,
                                                                 CostCentersDistribute = account.CostCentersDistribute,
                                                                 CurrencyReevaluation = account.CurrencyReevaluation,
                                                                 AccountStopped = account.AccountStopped,
                                                                 RemarksA = account.RemarksA,
                                                                 RemarksE = account.RemarksE,
                                                                 OpenningBalanceDepit = account.OpenningBalanceDepit,
                                                                 OpenningBalanceCredit = account.OpenningBalanceCredit,
                                                                 AccCurrTrancCredit = account.AccCurrTrancCredit,
                                                                 AccCurrTrancDepit = account.AccCurrTrancDepit,
                                                                 AccTotaCredit = account.AccTotaCredit,
                                                                 AccTotalDebit = account.AccTotalDebit,
                                                                 BalanceDebitLocal = account.BalanceDebitLocal,
                                                                 BalanceCreditLocal = account.BalanceCreditLocal,
                                                                 OpenningBalanceCreditCurncy = account.OpenningBalanceCreditCurncy,
                                                                 OpenningBalanceDepitCurncy = account.OpenningBalanceDepitCurncy,
                                                                 AccCurrTrancCreditCurncy = account.AccCurrTrancCreditCurncy,
                                                                 AccCurrTrancDepitCurncy = account.AccCurrTrancDepitCurncy,
                                                                 AccTotaCreditCurncy = account.AccTotaCreditCurncy,
                                                                 AccTotalDebitCurncy = account.AccTotalDebitCurncy,
                                                                 BalanceCreditCurncy = account.BalanceCreditCurncy,
                                                                 BalanceDebitCurncy = account.BalanceDebitCurncy,
                                                                 AccApproxim = account.AccApproxim,
                                                                 CreatedAt = account.CreatedAt,
                                                                 children = _db.CalAccountCharts.Where(d => d.DeletedAt == null && d.MainAccountId == account.AccountId)
                                                                           .Select(account => new
                                                                           {
                                                                               Type = "children4",
                                                                               AccountId = account.AccountId,
                                                                               AccountCode = account.AccountCode,
                                                                               AccountNameA = account.AccountNameA,
                                                                               AccountNameE = account.AccountNameE,
                                                                               MainAccountId = account.MainAccountId,
                                                                               AccountLevel = account.AccountLevel,
                                                                               AccountType = account.AccountType,
                                                                               AccountNature = account.AccountNature,
                                                                               AccountGroup = account.AccountGroup,
                                                                               AccCashFlow = account.AccCashFlow,
                                                                               CalcMethod = account.CalcMethod,
                                                                               CurrencyId = account.CurrencyId,
                                                                               Rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == account.CurrencyId).Rate,
                                                                               Aid = account.Aid,
                                                                               AccBulkAccount = account.AccBulkAccount,
                                                                               AccountCategory = account.AccountCategory,
                                                                               CostCentersDistribute = account.CostCentersDistribute,
                                                                               CurrencyReevaluation = account.CurrencyReevaluation,
                                                                               AccountStopped = account.AccountStopped,
                                                                               RemarksA = account.RemarksA,
                                                                               RemarksE = account.RemarksE,
                                                                               OpenningBalanceDepit = account.OpenningBalanceDepit,
                                                                               OpenningBalanceCredit = account.OpenningBalanceCredit,
                                                                               AccCurrTrancCredit = account.AccCurrTrancCredit,
                                                                               AccCurrTrancDepit = account.AccCurrTrancDepit,
                                                                               AccTotaCredit = account.AccTotaCredit,
                                                                               AccTotalDebit = account.AccTotalDebit,
                                                                               BalanceDebitLocal = account.BalanceDebitLocal,
                                                                               BalanceCreditLocal = account.BalanceCreditLocal,
                                                                               OpenningBalanceCreditCurncy = account.OpenningBalanceCreditCurncy,
                                                                               OpenningBalanceDepitCurncy = account.OpenningBalanceDepitCurncy,
                                                                               AccCurrTrancCreditCurncy = account.AccCurrTrancCreditCurncy,
                                                                               AccCurrTrancDepitCurncy = account.AccCurrTrancDepitCurncy,
                                                                               AccTotaCreditCurncy = account.AccTotaCreditCurncy,
                                                                               AccTotalDebitCurncy = account.AccTotalDebitCurncy,
                                                                               BalanceCreditCurncy = account.BalanceCreditCurncy,
                                                                               BalanceDebitCurncy = account.BalanceDebitCurncy,
                                                                               AccApproxim = account.AccApproxim,
                                                                               CreatedAt = account.CreatedAt,
                                                                           
                                                                           }).ToList()
                                                             }).ToList()
                                                     }).ToList()
                                   }).ToList()


                               }).ToListAsync();



            return Ok(query);
        }

        [HttpGet("GetAllAccountsForSelect")]
        public async Task<IActionResult> GetAllAccountsForSelect()
        {
            return Ok(await _db.CalAccountCharts.Where(j => j.DeletedAt == null && j.AccountType == 4 || j.AccountType == 1 )
                .Select(j => new { j.AccountId, j.AccountCode,j.AccountNameA, j.AccountNameE,j.CreatedAt,j.CalcMethod,j.AccountType })
                .OrderByDescending(j => j.CreatedAt).ToListAsync());
        }

        [HttpPost("AddCalAccountChart")]
        public async Task<IActionResult> AddCalAccountChart(CalAccountChartDto dto)
        {
            ResponseDto res = new ResponseDto();

            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                CalAccountChart getAccount = await _db.CalAccountCharts.FindAsync(dto.AccountId);

                if (getAccount == null)
                {


                    CalAccountChart existingCode = await _db.CalAccountCharts.Where(c => c.AccountCode == dto.AccountCode).FirstOrDefaultAsync();
                    if (existingCode is not null)
                    {
                        res.status = false;
                        res.message = $" هذا الكود موجود من قبل {dto.AccountCode}  ";
                        res.messageEn = $"This Account code already exists {dto.AccountCode}, please change it";
                        return Ok(res);
                    }

                    if(dto.MainAccountId is not null)
                    {
                        CalAccountChart getMainAccountCalcMethod = await _db.CalAccountCharts.FindAsync(dto.MainAccountId);
                        if (getMainAccountCalcMethod.CalcMethod != dto.CalcMethod)
                        {

                            res.status = false;
                            res.message = $"طبيعه الحساب الفرعى غير متناسبه مع طبيعه الحساب الرئيسى برجاء تغييرها";
                            res.messageEn = $"The nature of the sub-account is not compatible with the nature of the main account. Please change it";
                            throw new Exception("النوع الخاص بالاكونت الفرعى مختلف عن نوع الإب الخاص به");

                        }
                    }

                    var NewCalAccountChart = _mapper.Map<CalAccountChartDto, CalAccountChart>(dto);
                    _db.CalAccountCharts.Add(NewCalAccountChart);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        Id = NewCalAccountChart.AccountId,
                    };

                    return Ok(response);
                }
                else
                {
                    if (dto.MainAccountId is not null)
                    {
                        var getMainAccountCalcMethod = await _db.CalAccountCharts.SingleOrDefaultAsync(c => c.MainAccountId == dto.MainAccountId);
                        if (getMainAccountCalcMethod.CalcMethod != dto.CalcMethod)
                        {
                            res.status = false;
                            res.message = $"طبيعه الحساب الفرعى غير متناسبه مع طبيعه الحساب الرئيسى برجاء تغييرها";
                            res.messageEn = $"The nature of the sub-account is not compatible with the nature of the main account. Please change it";
                            throw new Exception("النوع الخاص بالاكونت الفرعى مختلف عن نوع الإب الخاص به");

                        }
                    }

                    if(getAccount.CalcMethod != dto.CalcMethod)
                    {
                        CalAccountChart getAccountChildren = await _db.CalAccountCharts.SingleOrDefaultAsync(a => a.MainAccountId == dto.AccountId);
                        if(getAccountChildren is not null)
                        {
                            if (getAccountChildren.CalcMethod != dto.CalcMethod)
                            {
                                res.status = false;
                                res.message = $"طبيعه الحساب الرئيسى مختلفه عن طبيعه الحسابات الفرعيه الخاصه به برجاء تغييرها ";
                                res.messageEn = $"The nature of the sub-account is not compatible with the nature of the main account. Please change it";
                                throw new Exception("النوع الخاص بالاكونت الفرعى مختلف عن نوع الإب الخاص به");

                            }
                        }
                    }

                    _mapper.Map(dto, getAccount);


                    await _db.SaveChangesAsync();

                    
                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "CalAccountChart has been modified successfully";
                    res.id = getAccount.AccountId;
                    

                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                if (res.status != null)
                {
                    return Ok(res);
                }
                else
                {
                    res.status = false;
                    res.message = $" {ex.Message} حدث خطا";
                    res.messageEn = $"something went wrong {ex.Message}";
                    return Ok(res);
                }
            }
        }

        [HttpDelete("DeleteAccountChart")]
        public async Task<IActionResult> DeleteAccountChart(int accountId)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (accountId == 0) return BadRequest("accountId  is equal zero");

                CalAccountChart getAccountChart = await _db.CalAccountCharts.FindAsync(accountId);


                if (getAccountChart == null) return NotFound("AccountChart is not found");

                if(getAccountChart.OpenningBalanceDepit > 0 || getAccountChart.OpenningBalanceCredit > 0 || getAccountChart.AccCurrTrancDepit > 0 ||
                  getAccountChart.AccCurrTrancCredit > 0 || getAccountChart.AccTotalDebit > 0 || getAccountChart.AccTotaCredit > 0 ||
                  getAccountChart.BalanceDebitLocal > 0 || getAccountChart.BalanceCreditLocal > 0 || getAccountChart.OpenningBalanceDepitCurncy > 0 ||
                  getAccountChart.OpenningBalanceCreditCurncy > 0 || getAccountChart.AccCurrTrancDepitCurncy > 0 || 
                  getAccountChart.AccCurrTrancCreditCurncy > 0 || getAccountChart.AccTotalDebitCurncy > 0 || getAccountChart.AccTotaCreditCurncy > 0
                  || getAccountChart.BalanceDebitCurncy > 0 || getAccountChart.BalanceCreditCurncy > 0)
                {
                    res.status = false;
                    res.message = $"لا يمكن مسح هذا الحساب لانه يوجد به أرصده";
                    res.messageEn = $"this account cannot be deleted because it has balances";
                    throw new Exception("لا يمكن مسح هذا الحساب لانه يوجد به أرصده");
                }

                CalAccountChart getAccountChartChildren = await _db.CalAccountCharts.FirstOrDefaultAsync(c=>c.MainAccountId == accountId);
                if(getAccountChartChildren is not null)
                {
                    res.status = false;
                    res.message = $"لا يمكن مسح هذا الحساب لانه يوجد حسابات فرعيه مرتبطه به";
                    res.messageEn = $"this account cannot be deleted because there are subaccounts associated with it";
                    throw new Exception("لا يمكن مسح هذا الحساب لانه يوجد حسابات فرعيه مرتبطه به");
                }

                CalEmpAccount calEmpAccount = await _db.CalEmpAccounts.FirstOrDefaultAsync(e => e.AccountId == accountId);
                if(calEmpAccount is not null)
                {
                    res.status = false;
                    res.message = $"لا يمكن مسح هذا الحساب لانه مرتبط بهذا الحساب ( {calEmpAccount.AccountNameA} )";
                    res.messageEn = $"this account cannot be deleted because it related with this account ( {calEmpAccount.AccountNameE} )";
                    throw new Exception("لا يمكن مسح هذا الحساب لانه مرتبط بحساب اخر");
                }

                _db.CalAccountCharts.Remove(getAccountChart);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Account deleted successfully",
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                if (res.status != null)
                {
                    return Ok(res);
                }
                else
                {
                    res.status = false;
                    res.message = $" {ex.Message} حدث خطا";
                    res.messageEn = $"something went wrong {ex.Message}";
                    return Ok(res);
                } 
            }
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _db.GUsers.Where(u => u.DeletedAt == null).Select(s => new {s.UserId,s.UserName,s.UserCode,s.FirstName,s.LastName}).ToListAsync());
        }

        [HttpPost("AddCalAccountChartUser")]
        public async Task<IActionResult> AddCalAccountChartUser(CalAccountUsersDto dto)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                if(dto.AccountId is null)
                {
                    res.status = false;
                    res.message = "يرجى أختيار حساب";
                    res.messageEn = "please choose account";
                    return Ok(res);
                }

                CalAccountUser getAccountUser = await _db.CalAccountUsers.FindAsync(dto.AccUserId);
                if(getAccountUser == null)
                {
                    CalAccountUser existingAccount = await _db.CalAccountUsers.Where(c => c.UserId == dto.UserId && c.AccountId == dto.AccountId).FirstOrDefaultAsync();
                    if (existingAccount is not null)
                    {
                        res.status = false;
                        res.message = $" هذا الحساب موجود من قبل لهذا المستخدم";
                        res.messageEn = $"This Account  already exists for the same user, please change it";
                        return Ok(res);
                    }

                    CalAccountUser newAccountUser = new CalAccountUser
                    {
                        AccountId = dto.AccountId,
                        UserId = dto.UserId,
                        ApprovedBy = dto.ApprovedBy,
                        Remarks1 = dto.Remarks1,
                        Remarks2 = dto.Remarks2,
                    };

                    _db.CalAccountUsers.Add(newAccountUser);
                    await _db.SaveChangesAsync();

                    res.status = true;
                    res.message = "تم الإضافة بنجاح";
                    res.messageEn = "added successfully";
                    res.id = newAccountUser.AccUserId;
                  
                    return Ok(res);

                }
                else
                {
                    CalAccountUser existingAccount = await _db.CalAccountUsers.Where(c => c.UserId == dto.UserId && c.AccountId == dto.AccountId).FirstOrDefaultAsync();
                    if (existingAccount is not null)
                    {
                        res.status = false;
                        res.message = $" هذا الحساب موجود من قبل لهذا المستخدم";
                        res.messageEn = $"This Account  already exists for the same user, please change it";
                        return Ok(res);
                    }

                    if (dto.AccountId is null)
                    {
                        res.status = false;
                        res.message = "يرجى أختيار حساب";
                        res.messageEn = "please choose account";
                        return Ok(res);
                    }

                    getAccountUser.AccountId = dto.AccountId;
                    getAccountUser.UserId = dto.UserId;
                    getAccountUser.ApprovedBy = dto.ApprovedBy;
                    getAccountUser.Remarks1 = dto.Remarks1;
                    getAccountUser.Remarks2 = dto.Remarks2;

                    await _db.SaveChangesAsync();


                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "CalAccountUsers has been modified successfully";
                    res.id = getAccountUser.AccUserId;


                    return Ok(res);

                }
            }
            catch(Exception ex)
            {
                if (res.status != null)
                {
                    return Ok(res);
                }
                else
                {
                    res.status = false;
                    res.message = $" {ex.Message} حدث خطا";
                    res.messageEn = $"something went wrong {ex.Message}";
                    return Ok(res);
                }
            }
        }

        [HttpGet("GetAllCalAccountUsers")]
        public async Task<IActionResult> GetAllCalAccountUsers()
        {
            var query = await (from calAccountUser in _db.CalAccountUsers
                               select new
                               {
                                   AccUserId = calAccountUser.AccUserId,
                                   AccountId = calAccountUser.AccountId,
                                   AccountCode = _db.CalAccountCharts.Where(c => c.DeletedAt == null).FirstOrDefault(a => a.AccountId == calAccountUser.AccountId).AccountCode,
                                   AccountName =  _db.CalAccountCharts.Where(c=>c.DeletedAt == null).FirstOrDefault(a=>a.AccountId == calAccountUser.AccountId).AccountNameA,
                                   UserId = calAccountUser.UserId,
                                   UserName =  _db.GUsers.Where(c => c.DeletedAt == null).FirstOrDefault(a => a.UserId == calAccountUser.UserId).UserName,
                                   ApprovedBy = calAccountUser.ApprovedBy,
                                   ApprovedByName =  _db.GUsers.Where(c => c.DeletedAt == null).FirstOrDefault(a => a.UserId == calAccountUser.ApprovedBy).UserName,
                                   Remarks1 = calAccountUser.Remarks1

                               }).OrderByDescending(a=>a.AccUserId).ToListAsync();

            return Ok(query);
        }


        [HttpDelete("DeleteAccountUser")]
        public async Task<IActionResult> DeleteAccountUser(int accUserId)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (accUserId == 0) return BadRequest("accUserId  is equal zero");

                CalAccountUser getAccountUser = await _db.CalAccountUsers.FindAsync(accUserId);


                if (getAccountUser == null) return NotFound("AccountUser is not found");

                _db.CalAccountUsers.Remove(getAccountUser);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Account user deleted successfully",
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                if (res.status != null)
                {
                    return Ok(res);
                }
                else
                {
                    res.status = false;
                    res.message = $" {ex.Message} حدث خطا";
                    res.messageEn = $"something went wrong {ex.Message}";
                    return Ok(res);
                }
            }
        }


    }
}
