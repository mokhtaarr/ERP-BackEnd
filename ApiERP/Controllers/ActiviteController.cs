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
    public class ActiviteController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IMapper _mapper;

        public ActiviteController(ERPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        [HttpGet("GetAllActivities")]
        public async Task<IActionResult> GetAllActivities()
        {
            var query = await (from calActivie in _db.Cal_Activities
                               where calActivie.DeletedAt == null && calActivie.mainActiveId == null
                               select new
                               {
                                   activeId = calActivie.ActiveId,
                                   activeCode = calActivie.ActiveCode,
                                   activeNameA = calActivie.ActiveNameA,
                                   activeNameE = calActivie.ActiveNameE,
                                   mainActiveId = calActivie.mainActiveId,
                                   activeLevel = calActivie.ActiveLevel,
                                   activeCategory = calActivie.ActiveCategory,
                                   activeType = calActivie.ActiveType,
                                   cashFlowList = calActivie.CashFlowList,
                                   rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calActivie.CurrencyId).Rate,
                                   currencyId = calActivie.CurrencyId,
                                   remarksA = calActivie.RemarksA,
                                   accActiveId = calActivie.AccActiveId,
                                   openningBalanceDepit = calActivie.OpenningBalanceDepit,
                                   openningBalanceCredit = calActivie.OpenningBalanceCredit,
                                   ActiveCurrTrancDepit = calActivie.ActiveCurrTrancDepit,
                                   ActiveCurrTrancCredit = calActivie.ActiveCurrTrancCredit,
                                   ActiveTotalDebit = calActivie.ActiveTotalDebit,
                                   ActiveTotaCredit = calActivie.ActiveTotaCredit,
                                   balanceDebitLocal = calActivie.BalanceDebitLocal,
                                   balanceCreditLocal = calActivie.BalanceCreditLocal,
                                   openningBalanceDepitCurncy = calActivie.OpenningBalanceDepitCurncy,
                                   openningBalanceCreditCurncy = calActivie.OpenningBalanceCreditCurncy,
                                   ActiveCurrTrancDepitCurncy = calActivie.ActiveCurrTrancDepitCurncy,
                                   ActiveCurrTrancCreditCurncy = calActivie.ActiveCurrTrancCreditCurncy,
                                   ActiveTotalDebitCurncy = calActivie.ActiveTotalDebitCurncy,
                                   ActiveTotaCreditCurncy = calActivie.ActiveTotaCreditCurncy,
                                   balanceDebitCurncy = calActivie.BalanceDebitCurncy,
                                   balanceCreditCurncy = calActivie.BalanceCreditCurncy,
                                   jopDesc = calActivie.JopDesc,
                                   aid = calActivie.Aid,
                                   children = _db.Cal_Activities.Where(d => d.DeletedAt == null && d.mainActiveId == calActivie.ActiveId)
                                                     .Select(calActivie => new
                                                     {
                                                         activeId = calActivie.ActiveId,
                                                         activeCode = calActivie.ActiveCode,
                                                         activeNameA = calActivie.ActiveNameA,
                                                         activeNameE = calActivie.ActiveNameE,
                                                         mainActiveId = calActivie.mainActiveId,
                                                         activeLevel = calActivie.ActiveLevel,
                                                         activeCategory = calActivie.ActiveCategory,
                                                         activeType = calActivie.ActiveType,
                                                         cashFlowList = calActivie.CashFlowList,
                                                         rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calActivie.CurrencyId).Rate,
                                                         currencyId = calActivie.CurrencyId,
                                                         remarksA = calActivie.RemarksA,
                                                         accActiveId = calActivie.AccActiveId,
                                                         openningBalanceDepit = calActivie.OpenningBalanceDepit,
                                                         openningBalanceCredit = calActivie.OpenningBalanceCredit,
                                                         ActiveCurrTrancDepit = calActivie.ActiveCurrTrancDepit,
                                                         ActiveCurrTrancCredit = calActivie.ActiveCurrTrancCredit,
                                                         ActiveTotalDebit = calActivie.ActiveTotalDebit,
                                                         ActiveTotaCredit = calActivie.ActiveTotaCredit,
                                                         balanceDebitLocal = calActivie.BalanceDebitLocal,
                                                         balanceCreditLocal = calActivie.BalanceCreditLocal,
                                                         openningBalanceDepitCurncy = calActivie.OpenningBalanceDepitCurncy,
                                                         openningBalanceCreditCurncy = calActivie.OpenningBalanceCreditCurncy,
                                                         ActiveCurrTrancDepitCurncy = calActivie.ActiveCurrTrancDepitCurncy,
                                                         ActiveCurrTrancCreditCurncy = calActivie.ActiveCurrTrancCreditCurncy,
                                                         ActiveTotalDebitCurncy = calActivie.ActiveTotalDebitCurncy,
                                                         ActiveTotaCreditCurncy = calActivie.ActiveTotaCreditCurncy,
                                                         balanceDebitCurncy = calActivie.BalanceDebitCurncy,
                                                         balanceCreditCurncy = calActivie.BalanceCreditCurncy,
                                                         jopDesc = calActivie.JopDesc,
                                                         aid = calActivie.Aid,
                                                         children = _db.Cal_Activities.Where(d => d.DeletedAt == null && d.mainActiveId == calActivie.ActiveId)
                                                                          .Select(calActivie => new
                                                                          {
                                                                              activeId = calActivie.ActiveId,
                                                                              activeCode = calActivie.ActiveCode,
                                                                              activeNameA = calActivie.ActiveNameA,
                                                                              activeNameE = calActivie.ActiveNameE,
                                                                              mainActiveId = calActivie.mainActiveId,
                                                                              activeLevel = calActivie.ActiveLevel,
                                                                              activeCategory = calActivie.ActiveCategory,
                                                                              activeType = calActivie.ActiveType,
                                                                              cashFlowList = calActivie.CashFlowList,
                                                                              rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calActivie.CurrencyId).Rate,
                                                                              currencyId = calActivie.CurrencyId,
                                                                              remarksA = calActivie.RemarksA,
                                                                              accActiveId = calActivie.AccActiveId,
                                                                              openningBalanceDepit = calActivie.OpenningBalanceDepit,
                                                                              openningBalanceCredit = calActivie.OpenningBalanceCredit,
                                                                              ActiveCurrTrancDepit = calActivie.ActiveCurrTrancDepit,
                                                                              ActiveCurrTrancCredit = calActivie.ActiveCurrTrancCredit,
                                                                              ActiveTotalDebit = calActivie.ActiveTotalDebit,
                                                                              ActiveTotaCredit = calActivie.ActiveTotaCredit,
                                                                              balanceDebitLocal = calActivie.BalanceDebitLocal,
                                                                              balanceCreditLocal = calActivie.BalanceCreditLocal,
                                                                              openningBalanceDepitCurncy = calActivie.OpenningBalanceDepitCurncy,
                                                                              openningBalanceCreditCurncy = calActivie.OpenningBalanceCreditCurncy,
                                                                              ActiveCurrTrancDepitCurncy = calActivie.ActiveCurrTrancDepitCurncy,
                                                                              ActiveCurrTrancCreditCurncy = calActivie.ActiveCurrTrancCreditCurncy,
                                                                              ActiveTotalDebitCurncy = calActivie.ActiveTotalDebitCurncy,
                                                                              ActiveTotaCreditCurncy = calActivie.ActiveTotaCreditCurncy,
                                                                              balanceDebitCurncy = calActivie.BalanceDebitCurncy,
                                                                              balanceCreditCurncy = calActivie.BalanceCreditCurncy,
                                                                              jopDesc = calActivie.JopDesc,
                                                                              aid = calActivie.Aid,
                                                                              children = _db.Cal_Activities.Where(d => d.DeletedAt == null && d.mainActiveId == calActivie.ActiveId)
                                                                                         .Select(calActivie => new
                                                                                         {
                                                                                             activeId = calActivie.ActiveId,
                                                                                             activeCode = calActivie.ActiveCode,
                                                                                             activeNameA = calActivie.ActiveNameA,
                                                                                             activeNameE = calActivie.ActiveNameE,
                                                                                             mainActiveId = calActivie.mainActiveId,
                                                                                             activeLevel = calActivie.ActiveLevel,
                                                                                             activeCategory = calActivie.ActiveCategory,
                                                                                             activeType = calActivie.ActiveType,
                                                                                             cashFlowList = calActivie.CashFlowList,
                                                                                             rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calActivie.CurrencyId).Rate,
                                                                                             currencyId = calActivie.CurrencyId,
                                                                                             remarksA = calActivie.RemarksA,
                                                                                             accActiveId = calActivie.AccActiveId,
                                                                                             openningBalanceDepit = calActivie.OpenningBalanceDepit,
                                                                                             openningBalanceCredit = calActivie.OpenningBalanceCredit,
                                                                                             ActiveCurrTrancDepit = calActivie.ActiveCurrTrancDepit,
                                                                                             ActiveCurrTrancCredit = calActivie.ActiveCurrTrancCredit,
                                                                                             ActiveTotalDebit = calActivie.ActiveTotalDebit,
                                                                                             ActiveTotaCredit = calActivie.ActiveTotaCredit,
                                                                                             balanceDebitLocal = calActivie.BalanceDebitLocal,
                                                                                             balanceCreditLocal = calActivie.BalanceCreditLocal,
                                                                                             openningBalanceDepitCurncy = calActivie.OpenningBalanceDepitCurncy,
                                                                                             openningBalanceCreditCurncy = calActivie.OpenningBalanceCreditCurncy,
                                                                                             ActiveCurrTrancDepitCurncy = calActivie.ActiveCurrTrancDepitCurncy,
                                                                                             ActiveCurrTrancCreditCurncy = calActivie.ActiveCurrTrancCreditCurncy,
                                                                                             ActiveTotalDebitCurncy = calActivie.ActiveTotalDebitCurncy,
                                                                                             ActiveTotaCreditCurncy = calActivie.ActiveTotaCreditCurncy,
                                                                                             balanceDebitCurncy = calActivie.BalanceDebitCurncy,
                                                                                             balanceCreditCurncy = calActivie.BalanceCreditCurncy,
                                                                                             jopDesc = calActivie.JopDesc,
                                                                                             aid = calActivie.Aid,
                                                                                             children = _db.Cal_Activities.Where(d => d.DeletedAt == null && d.mainActiveId == calActivie.ActiveId)
                                                                                                 .Select(calActivie => new
                                                                                                 {
                                                                                                     activeId = calActivie.ActiveId,
                                                                                                     activeCode = calActivie.ActiveCode,
                                                                                                     activeNameA = calActivie.ActiveNameA,
                                                                                                     activeNameE = calActivie.ActiveNameE,
                                                                                                     mainActiveId = calActivie.mainActiveId,
                                                                                                     activeLevel = calActivie.ActiveLevel,
                                                                                                     activeCategory = calActivie.ActiveCategory,
                                                                                                     activeType = calActivie.ActiveType,
                                                                                                     cashFlowList = calActivie.CashFlowList,
                                                                                                     rate = _db.MsCurrencies.FirstOrDefault(c => c.CurrencyId == calActivie.CurrencyId).Rate,
                                                                                                     currencyId = calActivie.CurrencyId,
                                                                                                     remarksA = calActivie.RemarksA,
                                                                                                     accActiveId = calActivie.AccActiveId,
                                                                                                     openningBalanceDepit = calActivie.OpenningBalanceDepit,
                                                                                                     openningBalanceCredit = calActivie.OpenningBalanceCredit,
                                                                                                     ActiveCurrTrancDepit = calActivie.ActiveCurrTrancDepit,
                                                                                                     ActiveCurrTrancCredit = calActivie.ActiveCurrTrancCredit,
                                                                                                     ActiveTotalDebit = calActivie.ActiveTotalDebit,
                                                                                                     ActiveTotaCredit = calActivie.ActiveTotaCredit,
                                                                                                     balanceDebitLocal = calActivie.BalanceDebitLocal,
                                                                                                     balanceCreditLocal = calActivie.BalanceCreditLocal,
                                                                                                     openningBalanceDepitCurncy = calActivie.OpenningBalanceDepitCurncy,
                                                                                                     openningBalanceCreditCurncy = calActivie.OpenningBalanceCreditCurncy,
                                                                                                     ActiveCurrTrancDepitCurncy = calActivie.ActiveCurrTrancDepitCurncy,
                                                                                                     ActiveCurrTrancCreditCurncy = calActivie.ActiveCurrTrancCreditCurncy,
                                                                                                     ActiveTotalDebitCurncy = calActivie.ActiveTotalDebitCurncy,
                                                                                                     ActiveTotaCreditCurncy = calActivie.ActiveTotaCreditCurncy,
                                                                                                     balanceDebitCurncy = calActivie.BalanceDebitCurncy,
                                                                                                     balanceCreditCurncy = calActivie.BalanceCreditCurncy,
                                                                                                     jopDesc = calActivie.JopDesc,
                                                                                                     aid = calActivie.Aid,
                                                                                                 }).ToList()
                                                                                         }).ToList()
                                                                          }).ToList()
                                                     }).ToList()
                               }).ToListAsync();

            return Ok(query);
        }

        [HttpGet("GetAllActivitiesForSelect")]
        public async Task<IActionResult> GetAllCostCenterForSelect()
        {
            return Ok(await _db.Cal_Activities.Where(j => j.DeletedAt == null)
                .Select(j => new { j.ActiveId, j.ActiveCode, j.ActiveNameA, j.ActiveNameE })
                .OrderByDescending(j => j.ActiveId).ToListAsync());
        }

        [HttpGet("GetAllSys_AnalyticalCodes")]
        public async Task<IActionResult> GetAllSys_AnalyticalCodes()
        {
            return Ok(await _db.SysAnalyticalCodes.Where(s => s.DeletedAt == null && s.CodeLevelType == 1)
                .Select(s => new { s.Aid, s.Code, s.DescA, s.DescE, }).ToListAsync());
        }


        [HttpPost("AddCalActivity")]
        public async Task<IActionResult> AddCalActivity(CalActivitieDto dto)
        {
            ResponseDto res = new ResponseDto();

            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                CalActivities getActivity = await _db.Cal_Activities.FindAsync(dto.ActiveId);

                if (getActivity == null)
                {


                    CalActivities existingCode = await _db.Cal_Activities.Where(c => c.ActiveCode == dto.ActiveCode).FirstOrDefaultAsync();
                    if (existingCode is not null)
                    {
                        res.status = false;
                        res.message = $" هذا الكود موجود من قبل {dto.ActiveCode}  ";
                        res.messageEn = $"This code already exists {dto.ActiveCode}, please change it";
                        return Ok(res);
                    }

                    if (dto.mainActiveId != null)
                    {
                        if (dto.ActiveType == 1)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع النشاط  : رئيسى و ذلك لانه تم أختيار له نوع نشاط رئيسى";
                            res.messageEn = "It`s not possible to make the active type main because a main active type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    if (dto.mainActiveId == null)
                    {
                        if (dto.ActiveType == 2)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع النشاط : فرعي و ذلك لانه لم يتم أختيار له نوع نشاط رئيسى";
                            res.messageEn = "It`s not possible to make the active type sub because no main active type has been chosen for it";
                            return Ok(res);
                        }
                    }


                    CalActivities NewActivity = _mapper.Map<CalActivitieDto, CalActivities>(dto);
                    _db.Cal_Activities.Add(NewActivity);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        Id = NewActivity.ActiveId,
                    };

                    return Ok(response);
                }
                else
                {
                    if (dto.mainActiveId != null)
                    {
                        if (dto.ActiveType == 1)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع النشاط  : رئيسى و ذلك لانه تم أختيار له نوع النشاط رئيسى";
                            res.messageEn = "It`s not possible to make the active type main because a main active type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    if (dto.mainActiveId == null)
                    {
                        if (dto.ActiveType == 2)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع النشاط : فرعي و ذلك لانه لم يتم أختيار له نوع نشاط رئيسى";
                            res.messageEn = "It`s not possible to make the active type sub because no main active type has been chosen for it";
                            return Ok(res);
                        }
                    }


                    _mapper.Map(dto, getActivity);


                    await _db.SaveChangesAsync();


                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "Activity has been modified successfully";
                    res.id = getActivity.ActiveId;


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


        [HttpDelete("DeleteActivity")]
        public async Task<IActionResult> DeleteActivity(int ActiveId)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (ActiveId == 0) return BadRequest("ActiveId  is equal zero");

                CalActivities getActivity = await _db.Cal_Activities.FindAsync(ActiveId);


                if (getActivity == null) return NotFound("Activity is not found");

                if (getActivity.OpenningBalanceDepit > 0 || getActivity.OpenningBalanceCredit > 0 || getActivity.ActiveCurrTrancDepit > 0 ||
                  getActivity.ActiveCurrTrancCredit > 0 || getActivity.ActiveTotalDebit > 0 || getActivity.ActiveTotaCredit > 0 ||
                  getActivity.BalanceDebitLocal > 0 || getActivity.BalanceCreditLocal > 0 || getActivity.OpenningBalanceDepitCurncy > 0 ||
                  getActivity.OpenningBalanceCreditCurncy > 0 || getActivity.ActiveCurrTrancDepitCurncy > 0 ||
                  getActivity.ActiveCurrTrancCreditCurncy > 0 || getActivity.ActiveTotalDebitCurncy > 0 || getActivity.ActiveTotaCreditCurncy > 0
                  || getActivity.BalanceDebitCurncy > 0 || getActivity.BalanceCreditCurncy > 0)
                {
                    res.status = false;
                    res.message = $"لا يمكن مسح  النشاط  هذا لانه يوجد به أرصده";
                    res.messageEn = $"this activity cannot be deleted because it has balances";
                    throw new Exception("لا يمكن مسح النشاط  هذا لانه يوجد به أرصده");
                }

                CalActivities getActivityChildrens = await _db.Cal_Activities.FirstOrDefaultAsync(c => c.mainActiveId == ActiveId);
                if (getActivityChildrens is not null)
                {
                    res.status = false;
                    res.message = "لا يمكن مسح النشاط  لانه يوجد انشطة فرعيه أخرى مرتبطه به";
                    res.messageEn = "this activity  cannot be deleted because there are subaccounts associated with it";
                    throw new Exception("لا يمكن مسح النشاط  لانه يوجد انشطة فرعيه أخرى مرتبطه به");
                }



                _db.Cal_Activities.Remove(getActivity);
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Activity deleted successfully",
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
