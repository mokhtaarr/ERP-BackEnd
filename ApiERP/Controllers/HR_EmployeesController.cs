using AutoMapper;
using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.IRepositories;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HR_EmployeesController : ControllerBase
    {
        private readonly IGenericRepository<HrEmployee> _HrEmployeeRepository;
        private readonly IGenericRepository<HrDepartment> _HrDepartmentRepository;
        private readonly IGenericRepository<HrJob> _HrJob;
        private readonly IGenericRepository<MsStore> _MsStoreRepository;
        private readonly IGenericRepository<CalEmpAccount> _CalEmpAccountRepository;
        private readonly IMapper _mapper;
        private readonly ERPContext _db;
        public HR_EmployeesController(IGenericRepository<HrEmployee> HrEmployeeRepository, IGenericRepository<HrDepartment> hrDepartmentRepository,
            IGenericRepository<HrJob> hrJob, IGenericRepository<MsStore> msStoreRepository,
            IGenericRepository<CalEmpAccount> CalEmpAccountRepository, IMapper mapper, ERPContext db)
        {
            _HrEmployeeRepository = HrEmployeeRepository;
            _HrDepartmentRepository = hrDepartmentRepository;
            _HrJob = hrJob;
            _MsStoreRepository = msStoreRepository;
            _CalEmpAccountRepository = CalEmpAccountRepository;
            _mapper = mapper;
            _db = db;
        }

        [HttpGet("GetAllHrEmployees")]
        public async Task<IActionResult> GetAllHrEmployees()
        {
            return Ok(await  _HrEmployeeRepository.GetAll());
        }

        [HttpGet("GetAllHrDepartment")]
        public async Task<IActionResult> GetAllHrDepartment()
        {
            return Ok(await _HrDepartmentRepository.GetAll());
        }

        [HttpGet("GetAllHrJobs")]
        public async Task<IActionResult> GetAllHrJobs()
        {
            return Ok(await _HrJob.GetAll());
        }

        [HttpGet("GetAllMsStores")]
        public async Task<IActionResult> GetAllMsStores()
        {
            return Ok(await _MsStoreRepository.GetAll());
        }

        
        [HttpGet("GetMainAccountForEmployee")]
        public async Task<IActionResult> GetMainAccountForEmployee(int empId)
        {
            var result = await _CalEmpAccountRepository.Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "BasicAccCode");
            return Ok(result.AccountId);
        }

        [HttpPost("AddHrEmployee")]
        public async Task<IActionResult> AddHrEmployee(HrEmployeeDto dto)
        {
            var trans = await _db.Database.BeginTransactionAsync();
            ResponseDto res = new ResponseDto();

            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");
                HrEmployee getEmployee = await _db.HrEmployees.FindAsync(dto.EmpId);
                if (getEmployee == null) 
                {
                    HrEmployee existingEmpCode = await _db.HrEmployees.Where(c => c.EmpCode == dto.EmpCode).FirstOrDefaultAsync();
                    if (existingEmpCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.EmpCode}  ",
                            messageEn = $"This Employee code already exists {dto.EmpCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    var NewHrEmployee = _mapper.Map<HrEmployeeDto, HrEmployee>(dto);

                    _db.HrEmployees.Add(NewHrEmployee);

                    await _db.SaveChangesAsync();

                     res = AddEmpAccounts(dto.accountId, NewHrEmployee, "BasicAccCode",true);

                    if (!(bool)res.status) throw new Exception("An error occurred while adding the account");

                    if (dto.AddAccount1 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount1, NewHrEmployee, "AddAccountCode1",false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.AddAccount2 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount2, NewHrEmployee, "AddAccountCode2",false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount3 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount3, NewHrEmployee, "AddAccountCode3",false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.AddAccount4 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount4, NewHrEmployee, "AddAccountCode4", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount5 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount5, NewHrEmployee, "AddAccountCode5", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount6 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount6, NewHrEmployee, "AddAccountCode6", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount7 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount7, NewHrEmployee, "AddAccountCode7", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount8 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount8, NewHrEmployee, "AddAccountCode8", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount9 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount9, NewHrEmployee, "AddAccountCode9", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }


                    if (dto.AddAccount10 != null)
                    {
                         res = AddEmpAccounts(dto.AddAccount10, NewHrEmployee, "AddAccountCode10", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    await trans.CommitAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = NewHrEmployee.EmpId
                    };

                    return Ok(response);

                }
                else
                {
                    _mapper.Map(dto, getEmployee);
                 
                    if (dto.IsPrimaryAccountChangedForm == true)
                    {
                        res = EditEmpAccount(dto.accountId,getEmployee, "BasicAccCode", true);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");

                    }

                    if (dto.IsAddAccount1ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount1, getEmployee, "AddAccountCode1", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount2ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount2, getEmployee, "AddAccountCode2", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount3ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount3, getEmployee, "AddAccountCode3", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount4ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount4, getEmployee, "AddAccountCode4", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount5ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount5, getEmployee, "AddAccountCode5", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount6ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount6, getEmployee, "AddAccountCode6", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount7ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount7, getEmployee, "AddAccountCode7", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount8ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount8, getEmployee, "AddAccountCode8", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount9ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount9, getEmployee, "AddAccountCode9", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    if (dto.IsAddAccount10ChangedForm == true)
                    {
                        res = EditEmpAccount(dto.AddAccount10, getEmployee, "AddAccountCode10", false);
                        if (!(bool)res.status) throw new Exception("An error occurred while adding the account");
                    }

                    await _db.SaveChangesAsync();
                    await trans.CommitAsync();


                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Employee has been modified successfully",
                        id = getEmployee.EmpId

                    };

                    return Ok(response);
                }

            }
            catch(Exception ex)
            {
                await trans.RollbackAsync();

                if (res.status != null)
                {
                    return Ok(res);
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



        private  ResponseDto AddEmpAccounts(int? Account, HrEmployee Employee,string accountDescription,bool isPrimary)
        {
            ResponseDto responseDto = new ResponseDto() { status = true };

            try
            {
                CalAccountChart accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == Account);
                var existAccountCode = Employee.EmpCode + "-" + accountChart.AccountCode;
                CalEmpAccount getCalEmpRecord = _db.CalEmpAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                if (getCalEmpRecord is not null)
                {
                    responseDto.status = false;
                    responseDto.message = $"{accountChart.AccountNameA} هذا الحساب تم اضافته مرتين";
                    responseDto.messageEn = $"This account has been added twice {accountChart.AccountNameE}";

                    throw new Exception("This account has been added twice");
                }

                CalEmpAccount EmpAccount = new CalEmpAccount()
                {
                    AccountNameA = accountChart.AccountNameA + "-" + Employee.Name1,
                    AccountNameE = accountChart.AccountNameE + "-" + Employee.Name2,
                    AccountDescription = accountDescription,
                    EmpId = Employee.EmpId,
                    AccountId = Account,
                    AccountCode = Employee.EmpCode + "-" + accountChart.AccountCode,
                    IsInUse = true,
                    IsPrimeAccount = isPrimary,
                };


                _db.CalEmpAccounts.Add(EmpAccount);
                _db.SaveChanges();

                return responseDto;
            }
            catch
            {
                return responseDto;
            }
        }

        private ResponseDto EditEmpAccount(int? AccountId, HrEmployee Employee, string accountDescription,bool isPrimary)
        {
            ResponseDto res = new ResponseDto() {status= true};
            try
            {
              if(AccountId is not null)
                {
                    CalEmpAccount getCalEmpAccount = _db.CalEmpAccounts
                     .FirstOrDefault(c => c.EmpId == Employee.EmpId && c.AccountDescription == accountDescription && c.IsInUse == true);

                    if (getCalEmpAccount is not null) getCalEmpAccount.IsInUse = false;

                    CalAccountChart accountChart = _db.CalAccountCharts.FirstOrDefault(c => c.AccountId == AccountId);

                    string existAccountCode = Employee.EmpCode + "-" + accountChart.AccountCode;


                    CalEmpAccount getCalEmpRecord = _db.CalEmpAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == true);

                    CalEmpAccount getCalEmpRecordFalse = _db.CalEmpAccounts.FirstOrDefault(c => c.AccountCode == existAccountCode && c.IsInUse == false);

                    if (getCalEmpRecord is not null)
                    {
                        res.status = false;
                        res.message = $"{accountChart.AccountNameA}  هذا الحساب موجود من قبل";
                        res.messageEn = $"This account already exists {accountChart.AccountNameE}";


                        return res;
                    }
                    else if (getCalEmpRecordFalse is not null)
                    {
                        getCalEmpRecordFalse.IsInUse = true;
                        return res;

                    }
                    else
                    {
                        var AddEmpAccount = new CalEmpAccount()
                        {
                            AccountNameA = accountChart.AccountNameA + "-" + Employee.Name1,
                            AccountNameE = accountChart.AccountNameE + "-" + Employee.Name2,
                            AccountDescription = accountDescription,
                            EmpId = Employee.EmpId,
                            AccountId = AccountId,
                            AccountCode = Employee.EmpCode + "-" + accountChart.AccountCode,
                            IsInUse = true,
                            IsPrimeAccount = isPrimary,
                        };

                        _db.CalEmpAccounts.Add(AddEmpAccount);
                        return res;
                    }
              }else
                {
                    CalEmpAccount getCalEmpAccount =  _db.CalEmpAccounts
                          .FirstOrDefault(c => c.EmpId == Employee.EmpId && c.AccountDescription == accountDescription && c.IsInUse == true);

                    if (getCalEmpAccount is not null) getCalEmpAccount.IsInUse = false;
                   
                    return res;
                }

            }
            catch(Exception ex)
            {
                res.status = false;
                res.message = $" {ex.Message} حدث خطا";
                res.messageEn = $"something went wrong {ex.Message}";

                return res;
            }

        }

        [HttpGet("GetAllAdditionalAccount")]
        public async Task<IActionResult> GetAllAdditionalAccount(int? empId)
        {
            if (empId == null)
            {
                return BadRequest("CustomerId is required.");
            }

            var accounts = await _db.CalEmpAccounts
                .Where(c => c.EmpId == empId && c.IsInUse == true)
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

        [HttpGet("GetEmployeeMainAccount")]
        public async Task<IActionResult> GetEmployeeMainAccount(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "BasicAccCode" && c.IsPrimeAccount == true);
            return Ok(result);
        }

        [HttpGet("GetAdditionalaccount1")]
        public async Task<IActionResult> GetAdditionalaccount1(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode1" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount2")]
        public async Task<IActionResult> GetAdditionalaccount2(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode2" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount3")]
        public async Task<IActionResult> GetAdditionalaccount3(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode3" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount4")]
        public async Task<IActionResult> GetAdditionalaccount4(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode4" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount5")]
        public async Task<IActionResult> GetAdditionalaccount5(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode5" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount6")]
        public async Task<IActionResult> GetAdditionalaccount6(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode5" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount7")]
        public async Task<IActionResult> GetAdditionalaccount7(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode7" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount8")]
        public async Task<IActionResult> GetAdditionalaccount8(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode8" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount9")]
        public async Task<IActionResult> GetAdditionalaccount9(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode9" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpGet("GetAdditionalaccount10")]
        public async Task<IActionResult> GetAdditionalaccount10(int empId)
        {
            var result = await _CalEmpAccountRepository
                .Find(c => c.EmpId == empId && c.IsInUse == true && c.AccountDescription == "AddAccountCode10" && c.IsPrimeAccount == false);
            return Ok(result);

        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int empId)
        {
            try
            {
                if (empId == 0) return BadRequest("empId  is equal zero");

                HrEmployee getEmployee = await _db.HrEmployees.FindAsync(empId);


                if (getEmployee == null) return NotFound("employee is not found");

                getEmployee.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "employee deleted successfully",
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
