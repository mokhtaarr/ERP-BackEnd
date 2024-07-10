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
    public class ColCostCenterController : ControllerBase
    {

        private readonly ERPContext _db;
        private readonly IMapper _mapper;
        public ColCostCenterController(ERPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

      

        [HttpGet("GetAllCostCenter")]
        public async Task<IActionResult> GetAllCostCenter()
        {
            var query = await (from calCostCenter in _db.CalCostCenters
                               where calCostCenter.DeletedAt == null && calCostCenter.MainCostCenterId == null
                               select new
                               {
                                   costCenterId = calCostCenter.CostCenterId,
                                   costCenterCode = calCostCenter.CostCenterCode,
                                   costCenterNameA = calCostCenter.CostCenterNameA,
                                   costCenterNameE = calCostCenter.CostCenterNameE,
                                   mainCostCenterId = calCostCenter.MainCostCenterId,
                                   costCenterLevel = calCostCenter.CostCenterLevel,
                                   centerCategory = calCostCenter.CenterCategory,
                                   costType= calCostCenter.CostType,
                                   cashFlowList = calCostCenter.CashFlowList,
                                   rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calCostCenter.CurrencyId).Rate,
                                   currencyId = calCostCenter.CurrencyId,
                                   remarksA = calCostCenter.RemarksA,
                                   accCostCenterId = calCostCenter.AccCostCenterId,
                                   openningBalanceDepit = calCostCenter.OpenningBalanceDepit,
                                   openningBalanceCredit = calCostCenter.OpenningBalanceCredit,
                                   costCenterCurrTrancDepit = calCostCenter.CostCenterCurrTrancDepit,
                                   costCenterCurrTrancCredit = calCostCenter.CostCenterCurrTrancCredit,
                                   costCenterTotalDebit = calCostCenter.CostCenterTotalDebit,
                                   costCenterTotaCredit = calCostCenter.CostCenterTotaCredit,
                                   balanceDebitLocal = calCostCenter.BalanceDebitLocal,
                                   balanceCreditLocal = calCostCenter.BalanceCreditLocal,
                                   openningBalanceDepitCurncy = calCostCenter.OpenningBalanceDepitCurncy,
                                   openningBalanceCreditCurncy = calCostCenter.OpenningBalanceCreditCurncy,
                                   costCenterCurrTrancDepitCurncy = calCostCenter.CostCenterCurrTrancDepitCurncy,
                                   costCenterCurrTrancCreditCurncy = calCostCenter.CostCenterCurrTrancCreditCurncy,
                                   costCenterTotalDebitCurncy = calCostCenter.CostCenterTotalDebitCurncy,
                                   costCenterTotaCreditCurncy = calCostCenter.CostCenterTotaCreditCurncy,
                                   balanceDebitCurncy = calCostCenter.BalanceDebitCurncy,
                                   balanceCreditCurncy = calCostCenter.BalanceCreditCurncy,
                                   jopDesc = calCostCenter.JopDesc,
                                   aid = calCostCenter.Aid,
                                   children = _db.CalCostCenters.Where(d => d.DeletedAt == null && d.MainCostCenterId == calCostCenter.CostCenterId)
                                                     .Select(calCostCenter => new
                                                     {
                                                         costCenterId = calCostCenter.CostCenterId,
                                                         costCenterCode = calCostCenter.CostCenterCode,
                                                         costCenterNameA = calCostCenter.CostCenterNameA,
                                                         costCenterNameE = calCostCenter.CostCenterNameE,
                                                         mainCostCenterId = calCostCenter.MainCostCenterId,
                                                         costCenterLevel = calCostCenter.CostCenterLevel,
                                                         centerCategory = calCostCenter.CenterCategory,
                                                         costType = calCostCenter.CostType,
                                                         cashFlowList = calCostCenter.CashFlowList,
                                                         rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calCostCenter.CurrencyId).Rate,
                                                         currencyId = calCostCenter.CurrencyId,
                                                         remarksA = calCostCenter.RemarksA,
                                                         accCostCenterId = calCostCenter.AccCostCenterId,
                                                         openningBalanceDepit = calCostCenter.OpenningBalanceDepit,
                                                         openningBalanceCredit = calCostCenter.OpenningBalanceCredit,
                                                         costCenterCurrTrancDepit = calCostCenter.CostCenterCurrTrancDepit,
                                                         costCenterCurrTrancCredit = calCostCenter.CostCenterCurrTrancCredit,
                                                         costCenterTotalDebit = calCostCenter.CostCenterTotalDebit,
                                                         costCenterTotaCredit = calCostCenter.CostCenterTotaCredit,
                                                         balanceDebitLocal = calCostCenter.BalanceDebitLocal,
                                                         balanceCreditLocal = calCostCenter.BalanceCreditLocal,
                                                         openningBalanceDepitCurncy = calCostCenter.OpenningBalanceDepitCurncy,
                                                         openningBalanceCreditCurncy = calCostCenter.OpenningBalanceCreditCurncy,
                                                         costCenterCurrTrancDepitCurncy = calCostCenter.CostCenterCurrTrancDepitCurncy,
                                                         costCenterCurrTrancCreditCurncy = calCostCenter.CostCenterCurrTrancCreditCurncy,
                                                         costCenterTotalDebitCurncy = calCostCenter.CostCenterTotalDebitCurncy,
                                                         costCenterTotaCreditCurncy = calCostCenter.CostCenterTotaCreditCurncy,
                                                         balanceDebitCurncy = calCostCenter.BalanceDebitCurncy,
                                                         balanceCreditCurncy = calCostCenter.BalanceCreditCurncy,
                                                         jopDesc = calCostCenter.JopDesc,
                                                         aid = calCostCenter.Aid,
                                                         children = _db.CalCostCenters.Where(d => d.DeletedAt == null && d.MainCostCenterId == calCostCenter.CostCenterId)
                                                                          .Select(calCostCenter => new
                                                                          {
                                                                              costCenterId = calCostCenter.CostCenterId,
                                                                              costCenterCode = calCostCenter.CostCenterCode,
                                                                              costCenterNameA = calCostCenter.CostCenterNameA,
                                                                              costCenterNameE = calCostCenter.CostCenterNameE,
                                                                              mainCostCenterId = calCostCenter.MainCostCenterId,
                                                                              costCenterLevel = calCostCenter.CostCenterLevel,
                                                                              centerCategory = calCostCenter.CenterCategory,
                                                                              costType = calCostCenter.CostType,
                                                                              cashFlowList = calCostCenter.CashFlowList,
                                                                              rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calCostCenter.CurrencyId).Rate,
                                                                              currencyId = calCostCenter.CurrencyId,
                                                                              remarksA = calCostCenter.RemarksA,
                                                                              accCostCenterId = calCostCenter.AccCostCenterId,
                                                                              openningBalanceDepit = calCostCenter.OpenningBalanceDepit,
                                                                              openningBalanceCredit = calCostCenter.OpenningBalanceCredit,
                                                                              costCenterCurrTrancDepit = calCostCenter.CostCenterCurrTrancDepit,
                                                                              costCenterCurrTrancCredit = calCostCenter.CostCenterCurrTrancCredit,
                                                                              costCenterTotalDebit = calCostCenter.CostCenterTotalDebit,
                                                                              costCenterTotaCredit = calCostCenter.CostCenterTotaCredit,
                                                                              balanceDebitLocal = calCostCenter.BalanceDebitLocal,
                                                                              balanceCreditLocal = calCostCenter.BalanceCreditLocal,
                                                                              openningBalanceDepitCurncy = calCostCenter.OpenningBalanceDepitCurncy,
                                                                              openningBalanceCreditCurncy = calCostCenter.OpenningBalanceCreditCurncy,
                                                                              costCenterCurrTrancDepitCurncy = calCostCenter.CostCenterCurrTrancDepitCurncy,
                                                                              costCenterCurrTrancCreditCurncy = calCostCenter.CostCenterCurrTrancCreditCurncy,
                                                                              costCenterTotalDebitCurncy = calCostCenter.CostCenterTotalDebitCurncy,
                                                                              costCenterTotaCreditCurncy = calCostCenter.CostCenterTotaCreditCurncy,
                                                                              balanceDebitCurncy = calCostCenter.BalanceDebitCurncy,
                                                                              balanceCreditCurncy = calCostCenter.BalanceCreditCurncy,
                                                                              jopDesc = calCostCenter.JopDesc,
                                                                              aid = calCostCenter.Aid,
                                                                              children = _db.CalCostCenters.Where(d => d.DeletedAt == null && d.MainCostCenterId == calCostCenter.CostCenterId)
                                                                                         .Select(calCostCenter => new
                                                                                         {
                                                                                             costCenterId = calCostCenter.CostCenterId,
                                                                                             costCenterCode = calCostCenter.CostCenterCode,
                                                                                             costCenterNameA = calCostCenter.CostCenterNameA,
                                                                                             costCenterNameE = calCostCenter.CostCenterNameE,
                                                                                             mainCostCenterId = calCostCenter.MainCostCenterId,
                                                                                             costCenterLevel = calCostCenter.CostCenterLevel,
                                                                                             centerCategory = calCostCenter.CenterCategory,
                                                                                             costType = calCostCenter.CostType,
                                                                                             cashFlowList = calCostCenter.CashFlowList,
                                                                                             rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calCostCenter.CurrencyId).Rate,
                                                                                             currencyId = calCostCenter.CurrencyId,
                                                                                             remarksA = calCostCenter.RemarksA,
                                                                                             accCostCenterId = calCostCenter.AccCostCenterId,
                                                                                             openningBalanceDepit = calCostCenter.OpenningBalanceDepit,
                                                                                             openningBalanceCredit = calCostCenter.OpenningBalanceCredit,
                                                                                             costCenterCurrTrancDepit = calCostCenter.CostCenterCurrTrancDepit,
                                                                                             costCenterCurrTrancCredit = calCostCenter.CostCenterCurrTrancCredit,
                                                                                             costCenterTotalDebit = calCostCenter.CostCenterTotalDebit,
                                                                                             costCenterTotaCredit = calCostCenter.CostCenterTotaCredit,
                                                                                             balanceDebitLocal = calCostCenter.BalanceDebitLocal,
                                                                                             balanceCreditLocal = calCostCenter.BalanceCreditLocal,
                                                                                             openningBalanceDepitCurncy = calCostCenter.OpenningBalanceDepitCurncy,
                                                                                             openningBalanceCreditCurncy = calCostCenter.OpenningBalanceCreditCurncy,
                                                                                             costCenterCurrTrancDepitCurncy = calCostCenter.CostCenterCurrTrancDepitCurncy,
                                                                                             costCenterCurrTrancCreditCurncy = calCostCenter.CostCenterCurrTrancCreditCurncy,
                                                                                             costCenterTotalDebitCurncy = calCostCenter.CostCenterTotalDebitCurncy,
                                                                                             costCenterTotaCreditCurncy = calCostCenter.CostCenterTotaCreditCurncy,
                                                                                             balanceDebitCurncy = calCostCenter.BalanceDebitCurncy,
                                                                                             balanceCreditCurncy = calCostCenter.BalanceCreditCurncy,
                                                                                             jopDesc = calCostCenter.JopDesc,
                                                                                             aid = calCostCenter.Aid,
                                                                                             children = _db.CalCostCenters.Where(d => d.DeletedAt == null && d.MainCostCenterId == calCostCenter.CostCenterId)
                                                                                                 .Select(calCostCenter => new
                                                                                                 {
                                                                                                     costCenterId = calCostCenter.CostCenterId,
                                                                                                     costCenterCode = calCostCenter.CostCenterCode,
                                                                                                     costCenterNameA = calCostCenter.CostCenterNameA,
                                                                                                     costCenterNameE = calCostCenter.CostCenterNameE,
                                                                                                     mainCostCenterId = calCostCenter.MainCostCenterId,
                                                                                                     costCenterLevel = calCostCenter.CostCenterLevel,
                                                                                                     centerCategory = calCostCenter.CenterCategory,
                                                                                                     costType = calCostCenter.CostType,
                                                                                                     cashFlowList = calCostCenter.CashFlowList,
                                                                                                     rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calCostCenter.CurrencyId).Rate,
                                                                                                     currencyId = calCostCenter.CurrencyId,
                                                                                                     remarksA = calCostCenter.RemarksA,
                                                                                                     accCostCenterId = calCostCenter.AccCostCenterId,
                                                                                                     openningBalanceDepit = calCostCenter.OpenningBalanceDepit,
                                                                                                     openningBalanceCredit = calCostCenter.OpenningBalanceCredit,
                                                                                                     costCenterCurrTrancDepit = calCostCenter.CostCenterCurrTrancDepit,
                                                                                                     costCenterCurrTrancCredit = calCostCenter.CostCenterCurrTrancCredit,
                                                                                                     costCenterTotalDebit = calCostCenter.CostCenterTotalDebit,
                                                                                                     costCenterTotaCredit = calCostCenter.CostCenterTotaCredit,
                                                                                                     balanceDebitLocal = calCostCenter.BalanceDebitLocal,
                                                                                                     balanceCreditLocal = calCostCenter.BalanceCreditLocal,
                                                                                                     openningBalanceDepitCurncy = calCostCenter.OpenningBalanceDepitCurncy,
                                                                                                     openningBalanceCreditCurncy = calCostCenter.OpenningBalanceCreditCurncy,
                                                                                                     costCenterCurrTrancDepitCurncy = calCostCenter.CostCenterCurrTrancDepitCurncy,
                                                                                                     costCenterCurrTrancCreditCurncy = calCostCenter.CostCenterCurrTrancCreditCurncy,
                                                                                                     costCenterTotalDebitCurncy = calCostCenter.CostCenterTotalDebitCurncy,
                                                                                                     costCenterTotaCreditCurncy = calCostCenter.CostCenterTotaCreditCurncy,
                                                                                                     balanceDebitCurncy = calCostCenter.BalanceDebitCurncy,
                                                                                                     balanceCreditCurncy = calCostCenter.BalanceCreditCurncy,
                                                                                                     jopDesc = calCostCenter.JopDesc,
                                                                                                     aid = calCostCenter.Aid,
                                                                                                 }).ToList()
                                                                                         }).ToList()
                                                                          }).ToList()
                                                     }).ToList()
                               }).ToListAsync();

            return Ok(query);
        }


        [HttpGet("GetAllCostCenterForSelect")]
        public async Task<IActionResult> GetAllCostCenterForSelect()
        {
            return Ok(await _db.CalCostCenters.Where(j => j.DeletedAt == null)
                .Select(j => new { j.CostCenterId, j.CostCenterCode, j.CostCenterNameA, j.CostCenterNameE})
                .OrderByDescending(j => j.CostCenterId).ToListAsync());
        }

        [HttpGet("GetAllSys_AnalyticalCodes")]
        public async Task<IActionResult> GetAllSys_AnalyticalCodes()
        {
            return Ok(await _db.SysAnalyticalCodes.Where(s => s.DeletedAt == null && s.CodeLevelType == 1 )
                .Select(s=> new {s.Aid,s.Code,s.DescA,s.DescE,}).ToListAsync());
        }

        [HttpPost("AddCalCostCenter")]
        public async Task<IActionResult> AddCalCostCenter(CalCostCenterDto dto)
        {
            ResponseDto res = new ResponseDto();

            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                CalCostCenter getCostCenter = await _db.CalCostCenters.FindAsync(dto.CostCenterId);

                if (getCostCenter == null)
                {


                    CalCostCenter existingCode = await _db.CalCostCenters.Where(c => c.CostCenterCode == dto.CostCenterCode).FirstOrDefaultAsync();
                    if (existingCode is not null)
                    {
                        res.status = false;
                        res.message = $" هذا الكود موجود من قبل {dto.CostCenterCode}  ";
                        res.messageEn = $"This Cost Center code already exists {dto.CostCenterCode}, please change it";
                        return Ok(res);
                    }

                   if(dto.MainCostCenterId != null)
                    {
                        if(dto.CostType == 1)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المركز  : رئيسى و ذلك لانه تم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make the center type main because a main center type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    if (dto.MainCostCenterId == null)
                    {
                        if (dto.CostType == 2)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المركز : فرعي و ذلك لانه لم يتم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make the center type sub because no main center type has been chosen for it";
                            return Ok(res);
                        }
                    }


                    CalCostCenter NewCostCenter = _mapper.Map<CalCostCenterDto, CalCostCenter>(dto);
                    _db.CalCostCenters.Add(NewCostCenter);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        Id = NewCostCenter.CostCenterId,
                    };

                    return Ok(response);
                }
                else
                {
                    if (dto.MainCostCenterId != null)
                    {
                        if (dto.CostType == 1)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المركز  : رئيسى و ذلك لانه تم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make the center type main because a main center type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    if (dto.MainCostCenterId == null)
                    {
                        if (dto.CostType == 2)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المركز : فرعي و ذلك لانه لم يتم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make the center type sub because no main center type has been chosen for it";
                            return Ok(res);
                        }
                    }


                    _mapper.Map(dto, getCostCenter);


                    await _db.SaveChangesAsync();


                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "calCostCenter has been modified successfully";
                    res.id = getCostCenter.CostCenterId;


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


        [HttpDelete("DeleteCostCenter")]
        public async Task<IActionResult> DeleteCostCenter(int costCenterId)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (costCenterId == 0) return BadRequest("costCenterId  is equal zero");

                CalCostCenter getCostCenter = await _db.CalCostCenters.FindAsync(costCenterId);


                if (getCostCenter == null) return NotFound("CostCenter is not found");

                if (getCostCenter.OpenningBalanceDepit > 0 || getCostCenter.OpenningBalanceCredit > 0 || getCostCenter.CostCenterCurrTrancDepit > 0 ||
                  getCostCenter.CostCenterCurrTrancCredit > 0 || getCostCenter.CostCenterTotalDebit > 0 || getCostCenter.CostCenterTotaCredit > 0 ||
                  getCostCenter.BalanceDebitLocal > 0 || getCostCenter.BalanceCreditLocal > 0 || getCostCenter.OpenningBalanceDepitCurncy > 0 ||
                  getCostCenter.OpenningBalanceCreditCurncy > 0 || getCostCenter.CostCenterCurrTrancDepitCurncy > 0 ||
                  getCostCenter.CostCenterCurrTrancCreditCurncy > 0 || getCostCenter.CostCenterTotalDebitCurncy > 0 || getCostCenter.CostCenterTotaCreditCurncy > 0
                  || getCostCenter.BalanceDebitCurncy > 0 || getCostCenter.BalanceCreditCurncy > 0)
                {
                    res.status = false;
                    res.message = $"لا يمكن مسح  مركز التكلفة هذا لانه يوجد به أرصده";
                    res.messageEn = $"this cost center cannot be deleted because it has balances";
                    throw new Exception("لا يمكن مسح  مركز التكلفة هذا لانه يوجد به أرصده");
                }

                CalCostCenter getCostCenterChildrens = await _db.CalCostCenters.FirstOrDefaultAsync(c => c.MainCostCenterId == costCenterId);
                if (getCostCenterChildrens is not null)
                {
                    res.status = false;
                    res.message = "لا يمكن مسح مركز التكلفة لانه يوجد مراكز فرعيه أخرى مرتبطه به";
                    res.messageEn = "this cost center cannot be deleted because there are subaccounts associated with it";
                    throw new Exception("لا يمكن مسح مركز التكلفة لانه يوجد مراكز فرعيه أخرى مرتبطه به");
                }

               

                _db.CalCostCenters.Remove(getCostCenter);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "cost center deleted successfully",
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
