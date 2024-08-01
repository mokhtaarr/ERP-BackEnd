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
    public class SysFinancialYearsController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IMapper _mapper;

        public SysFinancialYearsController(ERPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet("GetAllSys_FinancialYears")]
        public async Task<IActionResult> GetAllSys_FinancialYears()
        {
            return Ok(await _db.SysFinancialYears.Where(s => s.DeletedAt == null).ToListAsync());
        }

        [HttpGet("GetSysFinancialIntervals")]
        public async Task<IActionResult> GetSysFinancialIntervals(int FinancialYearsId)
        {
            if (FinancialYearsId == 0) return BadRequest();

            List<SysFinancialInterval> GetSysFinancialIntervals =  await _db.SysFinancialIntervals.Where(f => f.DeletedAt == null && f.FinancialYearId == FinancialYearsId).ToListAsync();

            return Ok(GetSysFinancialIntervals);
        }


        [HttpPost("AddFinancialYear")]
        public async Task<IActionResult> AddFinancialYear(SysFinancialYearDto dto)
        {
            var trans = await _db.Database.BeginTransactionAsync();
            ResponseDto res = new ResponseDto();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("يوجد خطا في البيانات المرسله يرجى مرجعتها");
                }



                SysFinancialYear getRecord = await _db.SysFinancialYears.FindAsync(dto.FinancialYearsId);

                if (getRecord == null)
                {

                    SysFinancialYear existingFinancialYearsCode = await _db.SysFinancialYears.Where(c => c.FinancialYearsCode == dto.FinancialYearsCode).FirstOrDefaultAsync();
                    if (existingFinancialYearsCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.FinancialYearsCode}  ",
                            messageEn = $"This   code already exists {dto.FinancialYearsCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    SysFinancialYear NewFinancial = _mapper.Map<SysFinancialYearDto,SysFinancialYear>(dto);


                    _db.SysFinancialYears.Add(NewFinancial);
                    await _db.SaveChangesAsync();

                    if (dto.SysFinancialIntervalList != null)
                    {
                        foreach (var financial in dto.SysFinancialIntervalList)
                        {
                            SysFinancialInterval newFinancialInterval = new SysFinancialInterval
                            {
                                FinancialIntervalCode = financial.FinancialIntervalCode,
                                MonthNameA = financial.MonthNameA,
                                MonthNameE = financial.MonthNameE,
                                StartingFrom = financial.StartingFrom,
                                EndingDate = financial.EndingDate,
                                IsClosed = financial.IsClosed,
                                IsActive = financial.IsActive,
                                FinancialYearId = NewFinancial.FinancialYearsId
                            };

                            _db.SysFinancialIntervals.Add(newFinancialInterval);
                            await _db.SaveChangesAsync();
                        };
                    }

                 
                    await trans.CommitAsync();

                    res.status = true;
                    res.message = "تم الإضافة بنجاح";
                    res.messageEn = "added successfully";
                    res.id = NewFinancial.FinancialYearsId;

                    return Ok(res);
                }
                else
                {
                    _mapper.Map(dto, getRecord);
                    await _db.SaveChangesAsync();

                    if (dto.SysFinancialIntervalList != null)
                    {
                        List<SysFinancialInterval> getOldSysFinancialIntervalList = await _db.SysFinancialIntervals.Where(f => f.FinancialYearId == getRecord.FinancialYearsId).ToListAsync();
                        if (getOldSysFinancialIntervalList.Any())
                        {
                            _db.SysFinancialIntervals.RemoveRange(getOldSysFinancialIntervalList);
                            _db.SaveChanges();
                        }

                        foreach (var financial in dto.SysFinancialIntervalList)
                        {
                            SysFinancialInterval newFinancialInterval = new SysFinancialInterval
                            {
                                FinancialIntervalCode = financial.FinancialIntervalCode,
                                MonthNameA = financial.MonthNameA,
                                MonthNameE = financial.MonthNameE,
                                StartingFrom = financial.StartingFrom,
                                EndingDate = financial.EndingDate,
                                IsClosed = financial.IsClosed,
                                IsActive = financial.IsActive,
                                FinancialYearId = getRecord.FinancialYearsId
                            };

                            _db.SysFinancialIntervals.Add(newFinancialInterval);
                            await _db.SaveChangesAsync();
                        };
                    }

                    await trans.CommitAsync();

                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "item has been modified successfully";
                    res.id = getRecord.FinancialYearsId;

                    return Ok(res);

                }


            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                var Bad_response = new
                    {
                      status = false,
                      message = $" {ex.Message} حدث خطا",
                      messageEn = $"something went wrong {ex.Message}",
                    };
                    return Ok(Bad_response);
            }

            
        }


        [HttpDelete("DeleteFanincial")]
        public async Task<IActionResult> DeleteFanincial(int FinancialYearsId)
        {
            try
            {
                if (FinancialYearsId == 0) return BadRequest();


                List<SysFinancialInterval> getSysFinancialIntervals = await _db.SysFinancialIntervals.Where(f=>f.FinancialYearId == FinancialYearsId).ToListAsync();
                List<int> financialIntervalsIds = getSysFinancialIntervals.Select(f => f.FinancialIntervalsId).ToList();


                bool hasMatchingRecords = await _db.CalPostOrders
                    .AnyAsync(c => financialIntervalsIds.Contains((int)c.FinancialIntervalsId));

                if (hasMatchingRecords == true)
                {
                    var response = new
                    {
                        status = false,
                        message = "لايمكن مسح هذه السنه المالية لانه تم استخدامها",
                        messageEn = "can not delete this period because it`s used before",
                    };

                    return Ok(response);
                }
                else
                {
                    _db.SysFinancialIntervals.RemoveRange(getSysFinancialIntervals);
                    _db.SaveChanges();

                    SysFinancialYear getRecord  = await  _db.SysFinancialYears.FindAsync(FinancialYearsId);
                    if(getRecord is not null) { 
                        _db.SysFinancialYears.Remove(getRecord);
                        _db.SaveChanges();
                    }

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم المسح بنجاح",
                        messageEn = "item Unit has been deleted successfully",
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


    }
}
