using AutoMapper;
using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysAnalyticalCodesController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IMapper _mapper;

        public SysAnalyticalCodesController(ERPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        [HttpGet("GetAllSysAnalyticalCode")]
        public async Task<IActionResult> GetAllSysAnalyticalCode()
        {
            var query = await (from Analytic in _db.SysAnalyticalCodes
                               where Analytic.DeletedAt == null && Analytic.ParentAid == null
                               select new
                               {
                                   aid = Analytic.Aid,
                                   parentAid = Analytic.ParentAid,
                                   codeLevel= Analytic.CodeLevel,
                                   codeLevelType = Analytic.CodeLevelType,
                                   code = Analytic.Code,
                                   descA = Analytic.DescA,
                                   descE = Analytic.DescE,
                                   stopped = Analytic.Stopped,
                                   accountId = Analytic.AccountId,
                                   costCenterId = Analytic.CostCenterId,
                                   assetId = Analytic.AssetId,
                                   empId = Analytic.EmpId,
                                   bspartnerId = Analytic.BspartnerId,
                                   customerId = Analytic.CustomerId,
                                   vendorId = Analytic.VendorId,
                                   itemCardId = Analytic.ItemCardId,
                                   addField1 = Analytic.AddField1,
                                   addField2 = Analytic.AddField2,
                                   addField3 = Analytic.AddField3,
                                   addField4 = Analytic.AddField4,
                                   addField5 = Analytic.AddField5,
                                   addField6 = Analytic.AddField6,
                                   addField7 = Analytic.AddField7,
                                   addField8 = Analytic.AddField8,
                                   addField9 = Analytic.AddField9,
                                   addField10 = Analytic.AddField10,
                                   addField11=Analytic.AddField11,
                                   addField12=Analytic.AddField12,
                                   addField13=Analytic.AddField13,
                                   addField14=Analytic.AddField14,
                                   addField15=Analytic.AddField15,
                                   addField16=Analytic.AddField16,
                                   addField17=Analytic.AddField17,
                                   addField18=Analytic.AddField18,
                                   addField19=Analytic.AddField19,
                                   addField20=Analytic.AddField20,
                                   addField21=Analytic.AddField21,
                                   addField22=Analytic.AddField22,
                                   addField23=Analytic.AddField23,
                                   addField24=Analytic.AddField24,
                                   addField25= Analytic.AddField25,
                                   remarksA = Analytic.RemarksA,
                                   remarksE = Analytic.RemarksE,
                                   accomulatAid = Analytic.AccomulatAid,
                                   anDate1 = Analytic.AnDate1,
                                   anDate2 = Analytic.AnDate2,
                                   anDate3 = Analytic.AnDate3,
                                   isNotify1 = Analytic.IsNotify1,
                                   notifyDate1 = Analytic.NotifyDate1,
                                   isNotify2 = Analytic.IsNotify2,
                                   notifyDate2 = Analytic.NotifyDate2,
                                   isNotify3 = Analytic.IsNotify3,
                                   notifyDate3 = Analytic.NotifyDate3,
                                   addField26 = Analytic.AddField26,
                                   addField27 = Analytic.AddField27,
                                   addField28 = Analytic.AddField28,
                                   addField29 = Analytic.AddField29,
                                   addField30  = Analytic.AddField30,
                                   children = _db.SysAnalyticalCodes.Where(d => d.DeletedAt == null && d.ParentAid == Analytic.Aid)
                                   .Select(Analytic => new
                                   {
                                       aid = Analytic.Aid,
                                       parentAid = Analytic.ParentAid,
                                       codeLevel = Analytic.CodeLevel,
                                       codeLevelType = Analytic.CodeLevelType,
                                       code = Analytic.Code,
                                       descA = Analytic.DescA,
                                       descE = Analytic.DescE,
                                       stopped = Analytic.Stopped,
                                       accountId = Analytic.AccountId,
                                       costCenterId = Analytic.CostCenterId,
                                       assetId = Analytic.AssetId,
                                       empId = Analytic.EmpId,
                                       bspartnerId = Analytic.BspartnerId,
                                       customerId = Analytic.CustomerId,
                                       vendorId = Analytic.VendorId,
                                       itemCardId = Analytic.ItemCardId,
                                       addField1 = Analytic.AddField1,
                                       addField2 = Analytic.AddField2,
                                       addField3 = Analytic.AddField3,
                                       addField4 = Analytic.AddField4,
                                       addField5 = Analytic.AddField5,
                                       addField6 = Analytic.AddField6,
                                       addField7 = Analytic.AddField7,
                                       addField8 = Analytic.AddField8,
                                       addField9 = Analytic.AddField9,
                                       addField10 = Analytic.AddField10,
                                       addField11 = Analytic.AddField11,
                                       addField12 = Analytic.AddField12,
                                       addField13 = Analytic.AddField13,
                                       addField14 = Analytic.AddField14,
                                       addField15 = Analytic.AddField15,
                                       addField16 = Analytic.AddField16,
                                       addField17 = Analytic.AddField17,
                                       addField18 = Analytic.AddField18,
                                       addField19 = Analytic.AddField19,
                                       addField20 = Analytic.AddField20,
                                       addField21 = Analytic.AddField21,
                                       addField22 = Analytic.AddField22,
                                       addField23 = Analytic.AddField23,
                                       addField24 = Analytic.AddField24,
                                       addField25 = Analytic.AddField25,
                                       remarksA = Analytic.RemarksA,
                                       remarksE = Analytic.RemarksE,
                                       accomulatAid = Analytic.AccomulatAid,
                                       anDate1 = Analytic.AnDate1,
                                       anDate2 = Analytic.AnDate2,
                                       anDate3 = Analytic.AnDate3,
                                       isNotify1 = Analytic.IsNotify1,
                                       notifyDate1 = Analytic.NotifyDate1,
                                       isNotify2 = Analytic.IsNotify2,
                                       notifyDate2 = Analytic.NotifyDate2,
                                       isNotify3 = Analytic.IsNotify3,
                                       notifyDate3 = Analytic.NotifyDate3,
                                       addField26 = Analytic.AddField26,
                                       addField27 = Analytic.AddField27,
                                       addField28 = Analytic.AddField28,
                                       addField29 = Analytic.AddField29,
                                       addField30 = Analytic.AddField30,
                                       children = _db.SysAnalyticalCodes.Where(d => d.DeletedAt == null && d.ParentAid == Analytic.Aid)
                                                 .Select(Analytic => new
                                                 {
                                                     aid = Analytic.Aid,
                                                     parentAid = Analytic.ParentAid,
                                                     codeLevel = Analytic.CodeLevel,
                                                     codeLevelType = Analytic.CodeLevelType,
                                                     code = Analytic.Code,
                                                     descA = Analytic.DescA,
                                                     descE = Analytic.DescE,
                                                     stopped = Analytic.Stopped,
                                                     accountId = Analytic.AccountId,
                                                     costCenterId = Analytic.CostCenterId,
                                                     assetId = Analytic.AssetId,
                                                     empId = Analytic.EmpId,
                                                     bspartnerId = Analytic.BspartnerId,
                                                     customerId = Analytic.CustomerId,
                                                     vendorId = Analytic.VendorId,
                                                     itemCardId = Analytic.ItemCardId,
                                                     addField1 = Analytic.AddField1,
                                                     addField2 = Analytic.AddField2,
                                                     addField3 = Analytic.AddField3,
                                                     addField4 = Analytic.AddField4,
                                                     addField5 = Analytic.AddField5,
                                                     addField6 = Analytic.AddField6,
                                                     addField7 = Analytic.AddField7,
                                                     addField8 = Analytic.AddField8,
                                                     addField9 = Analytic.AddField9,
                                                     addField10 = Analytic.AddField10,
                                                     addField11 = Analytic.AddField11,
                                                     addField12 = Analytic.AddField12,
                                                     addField13 = Analytic.AddField13,
                                                     addField14 = Analytic.AddField14,
                                                     addField15 = Analytic.AddField15,
                                                     addField16 = Analytic.AddField16,
                                                     addField17 = Analytic.AddField17,
                                                     addField18 = Analytic.AddField18,
                                                     addField19 = Analytic.AddField19,
                                                     addField20 = Analytic.AddField20,
                                                     addField21 = Analytic.AddField21,
                                                     addField22 = Analytic.AddField22,
                                                     addField23 = Analytic.AddField23,
                                                     addField24 = Analytic.AddField24,
                                                     addField25 = Analytic.AddField25,
                                                     remarksA = Analytic.RemarksA,
                                                     remarksE = Analytic.RemarksE,
                                                     accomulatAid = Analytic.AccomulatAid,
                                                     anDate1 = Analytic.AnDate1,
                                                     anDate2 = Analytic.AnDate2,
                                                     anDate3 = Analytic.AnDate3,
                                                     isNotify1 = Analytic.IsNotify1,
                                                     notifyDate1 = Analytic.NotifyDate1,
                                                     isNotify2 = Analytic.IsNotify2,
                                                     notifyDate2 = Analytic.NotifyDate2,
                                                     isNotify3 = Analytic.IsNotify3,
                                                     notifyDate3 = Analytic.NotifyDate3,
                                                     addField26 = Analytic.AddField26,
                                                     addField27 = Analytic.AddField27,
                                                     addField28 = Analytic.AddField28,
                                                     addField29 = Analytic.AddField29,
                                                     addField30 = Analytic.AddField30,
                                                     children = _db.SysAnalyticalCodes.Where(d => d.DeletedAt == null && d.ParentAid == Analytic.Aid)
                                                                .Select(Analytic => new
                                                                {
                                                                    aid = Analytic.Aid,
                                                                    parentAid = Analytic.ParentAid,
                                                                    codeLevel = Analytic.CodeLevel,
                                                                    codeLevelType = Analytic.CodeLevelType,
                                                                    code = Analytic.Code,
                                                                    descA = Analytic.DescA,
                                                                    descE = Analytic.DescE,
                                                                    stopped = Analytic.Stopped,
                                                                    accountId = Analytic.AccountId,
                                                                    costCenterId = Analytic.CostCenterId,
                                                                    assetId = Analytic.AssetId,
                                                                    empId = Analytic.EmpId,
                                                                    bspartnerId = Analytic.BspartnerId,
                                                                    customerId = Analytic.CustomerId,
                                                                    vendorId = Analytic.VendorId,
                                                                    itemCardId = Analytic.ItemCardId,
                                                                    addField1 = Analytic.AddField1,
                                                                    addField2 = Analytic.AddField2,
                                                                    addField3 = Analytic.AddField3,
                                                                    addField4 = Analytic.AddField4,
                                                                    addField5 = Analytic.AddField5,
                                                                    addField6 = Analytic.AddField6,
                                                                    addField7 = Analytic.AddField7,
                                                                    addField8 = Analytic.AddField8,
                                                                    addField9 = Analytic.AddField9,
                                                                    addField10 = Analytic.AddField10,
                                                                    addField11 = Analytic.AddField11,
                                                                    addField12 = Analytic.AddField12,
                                                                    addField13 = Analytic.AddField13,
                                                                    addField14 = Analytic.AddField14,
                                                                    addField15 = Analytic.AddField15,
                                                                    addField16 = Analytic.AddField16,
                                                                    addField17 = Analytic.AddField17,
                                                                    addField18 = Analytic.AddField18,
                                                                    addField19 = Analytic.AddField19,
                                                                    addField20 = Analytic.AddField20,
                                                                    addField21 = Analytic.AddField21,
                                                                    addField22 = Analytic.AddField22,
                                                                    addField23 = Analytic.AddField23,
                                                                    addField24 = Analytic.AddField24,
                                                                    addField25 = Analytic.AddField25,
                                                                    remarksA = Analytic.RemarksA,
                                                                    remarksE = Analytic.RemarksE,
                                                                    accomulatAid = Analytic.AccomulatAid,
                                                                    anDate1 = Analytic.AnDate1,
                                                                    anDate2 = Analytic.AnDate2,
                                                                    anDate3 = Analytic.AnDate3,
                                                                    isNotify1 = Analytic.IsNotify1,
                                                                    notifyDate1 = Analytic.NotifyDate1,
                                                                    isNotify2 = Analytic.IsNotify2,
                                                                    notifyDate2 = Analytic.NotifyDate2,
                                                                    isNotify3 = Analytic.IsNotify3,
                                                                    notifyDate3 = Analytic.NotifyDate3,
                                                                    addField26 = Analytic.AddField26,
                                                                    addField27 = Analytic.AddField27,
                                                                    addField28 = Analytic.AddField28,
                                                                    addField29 = Analytic.AddField29,
                                                                    addField30 = Analytic.AddField30,
                                                                    children = _db.SysAnalyticalCodes.Where(d => d.DeletedAt == null && d.ParentAid == Analytic.Aid)
                                                                           .Select(Analytic => new
                                                                           {
                                                                               aid = Analytic.Aid,
                                                                               parentAid = Analytic.ParentAid,
                                                                               codeLevel = Analytic.CodeLevel,
                                                                               codeLevelType = Analytic.CodeLevelType,
                                                                               code = Analytic.Code,
                                                                               descA = Analytic.DescA,
                                                                               descE = Analytic.DescE,
                                                                               stopped = Analytic.Stopped,
                                                                               accountId = Analytic.AccountId,
                                                                               costCenterId = Analytic.CostCenterId,
                                                                               assetId = Analytic.AssetId,
                                                                               empId = Analytic.EmpId,
                                                                               bspartnerId = Analytic.BspartnerId,
                                                                               customerId = Analytic.CustomerId,
                                                                               vendorId = Analytic.VendorId,
                                                                               itemCardId = Analytic.ItemCardId,
                                                                               addField1 = Analytic.AddField1,
                                                                               addField2 = Analytic.AddField2,
                                                                               addField3 = Analytic.AddField3,
                                                                               addField4 = Analytic.AddField4,
                                                                               addField5 = Analytic.AddField5,
                                                                               addField6 = Analytic.AddField6,
                                                                               addField7 = Analytic.AddField7,
                                                                               addField8 = Analytic.AddField8,
                                                                               addField9 = Analytic.AddField9,
                                                                               addField10 = Analytic.AddField10,
                                                                               addField11 = Analytic.AddField11,
                                                                               addField12 = Analytic.AddField12,
                                                                               addField13 = Analytic.AddField13,
                                                                               addField14 = Analytic.AddField14,
                                                                               addField15 = Analytic.AddField15,
                                                                               addField16 = Analytic.AddField16,
                                                                               addField17 = Analytic.AddField17,
                                                                               addField18 = Analytic.AddField18,
                                                                               addField19 = Analytic.AddField19,
                                                                               addField20 = Analytic.AddField20,
                                                                               addField21 = Analytic.AddField21,
                                                                               addField22 = Analytic.AddField22,
                                                                               addField23 = Analytic.AddField23,
                                                                               addField24 = Analytic.AddField24,
                                                                               addField25 = Analytic.AddField25,
                                                                               remarksA = Analytic.RemarksA,
                                                                               remarksE = Analytic.RemarksE,
                                                                               accomulatAid = Analytic.AccomulatAid,
                                                                               anDate1 = Analytic.AnDate1,
                                                                               anDate2 = Analytic.AnDate2,
                                                                               anDate3 = Analytic.AnDate3,
                                                                               isNotify1 = Analytic.IsNotify1,
                                                                               notifyDate1 = Analytic.NotifyDate1,
                                                                               isNotify2 = Analytic.IsNotify2,
                                                                               notifyDate2 = Analytic.NotifyDate2,
                                                                               isNotify3 = Analytic.IsNotify3,
                                                                               notifyDate3 = Analytic.NotifyDate3,
                                                                               addField26 = Analytic.AddField26,
                                                                               addField27 = Analytic.AddField27,
                                                                               addField28 = Analytic.AddField28,
                                                                               addField29 = Analytic.AddField29,
                                                                               addField30 = Analytic.AddField30,
                                                                           }).ToList()
                                                                }).ToList()
                                                 }).ToList()
                                   }).ToList()

                               }).ToListAsync();

            return Ok(query);
        }

        [HttpGet("GetAllSysAnalyticalCodeForSelect")]
        public async Task<IActionResult> GetAllSysAnalyticalCodeForSelect()
        {
            return Ok(await _db.SysAnalyticalCodes.Where(j => j.DeletedAt == null && j.CodeLevelType == 1 )
                .Select(j => new { j.Aid, j.Code, j.DescA, j.DescE })
                .OrderByDescending(j => j.Aid).ToListAsync());
        }

        [HttpGet("GetAllAccountChartForSelect")]
        public async Task<IActionResult> GetAllAccountChartForSelect()
        {
            return Ok(await _db.CalAccountCharts.Where(j => j.DeletedAt == null && j.AccountType == 2 )
                .Select(j => new { j.AccountId, j.AccountCode, j.AccountNameA, j.AccountNameE })
                .OrderByDescending(j => j.AccountId).ToListAsync());
        }

        [HttpGet("GetAllCostCenterForSelect")]
        public async Task<IActionResult> GetAllCostCenterForSelect()
        {
            return Ok(await _db.CalCostCenters.Where(j => j.DeletedAt == null && j.CostType == 2)
                .Select(j => new { j.CostCenterId, j.CostCenterCode, j.CostCenterNameA, j.CostCenterNameE })
                .OrderByDescending(j => j.CostCenterId).ToListAsync());
        }

        [HttpGet("GetAllCustomer")]
        public async Task<IActionResult> GetAllCustomer()
        {
            return Ok(await _db.MsCustomers.Where(j => j.DeletedAt == null)
                .Select(j => new { j.CustomerId, j.CustomerCode, j.CustomerDescA, j.CustomerDescE })
                .OrderByDescending(j => j.CustomerId).ToListAsync());
        }

        [HttpGet("GetAllHrEmployees")]
        public async Task<IActionResult> GetAllHrEmployees()
        {
            return Ok(await _db.HrEmployees.Where(j => j.DeletedAt == null)
                .Select(j => new { j.EmpId, j.EmpCode, j.Name1, j.Name2 })
                .OrderByDescending(j => j.EmpId).ToListAsync());
        }

        [HttpGet("GetAllAssets")]
        public async Task<IActionResult> GetAllAssets()
        {
            return Ok(await _db.AssetAssetCards.Where(j => j.DeletedAt == null)
                .Select(j => new { j.AssetId, j.AssetCode, j.Name1, j.Name2 })
                .OrderByDescending(j => j.AssetId).ToListAsync());
        }

        [HttpGet("GetAllVendors")]
        public async Task<IActionResult> GetAllVendors()
        {
            return Ok(await _db.MsVendors.Where(j => j.DeletedAt == null)
                .Select(j => new { j.VendorId, j.VendorCode, j.VendorDescA, j.VendorDescE })
                .OrderByDescending(j => j.VendorId).ToListAsync());
        }


        [HttpPost("AddSysAnalyticalCode")]
        public async Task<IActionResult> AddSysAnalyticalCode(SysAnalyticalCodeDto dto)
        {
            ResponseDto res = new ResponseDto();

            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                SysAnalyticalCode getAnalyticalCode = await _db.SysAnalyticalCodes.FindAsync(dto.Aid);

                if (getAnalyticalCode == null)
                {


                    SysAnalyticalCode existingCode = await _db.SysAnalyticalCodes.Where(c => c.Code == dto.Code).FirstOrDefaultAsync();
                    if (existingCode is not null)
                    {
                        res.status = false;
                        res.message = $" هذا الكود موجود من قبل {dto.Code}  ";
                        res.messageEn = $"This SysAnalytical Code already exists {dto.Code}, please change it";
                        return Ok(res);
                    }

                    if (dto.ParentAid != null)
                    {
                        if (dto.CodeLevelType == 1)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المستوى  : رئيسى و ذلك لانه تم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make level type main because a main center type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    if (dto.ParentAid == null)
                    {
                        if (dto.CodeLevelType == 2)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المستوى : فرعي و ذلك لانه لم يتم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make level type sub because no main center type has been chosen for it";
                            return Ok(res);
                        }
                    }


                    SysAnalyticalCode NewSysAnalyticalCode = _mapper.Map<SysAnalyticalCodeDto, SysAnalyticalCode>(dto);
                    _db.SysAnalyticalCodes.Add(NewSysAnalyticalCode);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        Id = NewSysAnalyticalCode.Aid,
                    };

                    return Ok(response);
                }
                else
                {
                    if (dto.ParentAid != null)
                    {
                        if (dto.CodeLevelType == 1)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المستوى  : رئيسى و ذلك لانه تم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make level type main because a main center type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    if (dto.ParentAid == null)
                    {
                        if (dto.CodeLevelType == 2)
                        {
                            res.status = false;
                            res.message = "لا يمكن جعل نوع المستوى : فرعي و ذلك لانه لم يتم أختيار له نوع مركز رئيسى";
                            res.messageEn = "It`s not possible to make level type sub because no main center type has been chosen for it";
                            return Ok(res);
                        }
                    }

                    _mapper.Map(dto, getAnalyticalCode);


                    await _db.SaveChangesAsync();


                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "SysAnalytical Code has been modified successfully";
                    res.id = getAnalyticalCode.Aid;


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


        [HttpDelete("DeleteSysAnalyticalCode")]
        public async Task<IActionResult> DeleteSysAnalyticalCode(int aid)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (aid == 0) return BadRequest("aid  is equal zero");

                SysAnalyticalCode getSysAnalyticalCode = await _db.SysAnalyticalCodes.FindAsync(aid);


                if (getSysAnalyticalCode == null) return NotFound("SysAnalytical Code is not found");

                SysAnalyticalCode getSysAnalyticalCodeSub = await _db.SysAnalyticalCodes.FirstOrDefaultAsync(c => c.ParentAid == aid);
                if (getSysAnalyticalCodeSub is not null)
                {
                    res.status = false;
                    res.message = "لا يمكن مسح كود التحليل لانه يوجد أكواد فرعيه أخرى مرتبطه به";
                    res.messageEn = "this SysAnalytical Code  cannot be deleted because there are subaccounts associated with it";
                    throw new Exception("لا يمكن مسح مركز التكلفة لانه يوجد مراكز فرعيه أخرى مرتبطه به");
                }



                _db.SysAnalyticalCodes.Remove(getSysAnalyticalCode);
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
