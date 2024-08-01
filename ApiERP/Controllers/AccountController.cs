using AutoMapper;
using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IMapper _mapper;

        public AccountController(ERPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(usersDto dto)
        {
            try
            {
                if (dto == null) return BadRequest("model is empty");

                GUser userName = await _db.GUsers.Where(u => u.FirstName == dto.firstName && u.IsActive == true).FirstOrDefaultAsync();
                if (userName == null)
                {
                    var userName_response = new
                    {
                        status = false,
                        message = "اسم المستخدم غير صحيح",
                        messageEn = "Username is incorrect",
                    };

                    return Ok(userName_response);
                }

                GUser userPassword = await _db.GUsers.Where(u => u.Password == dto.password && u.IsActive == true).FirstOrDefaultAsync();
                if (userPassword == null)
                {
                    var Password_response = new
                    {
                        status = false,
                        message = "كلمه السر غير صحيحة",
                        messageEn = "password is incorrect",
                    };

                    return Ok(Password_response);
                }

                var response = new
                {
                    status = true,
                    message = "تم تسجيل الدخول بنجاح",
                    messageEn = "You have been logged in successfully",
                };
                return Ok(response);
            }
            catch
            {
                var bad_Response = new
                {
                    status = true,
                    message = "حدث خطأ اثناء تسجيل الدخول",
                    messageEn = "something went wrong",
                };

                return Ok(bad_Response);
            }
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _db.GUsers.Where(u=>u.DeletedAt == null && u.IsActive == true).ToListAsync());
        }

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _db.HrEmployees.Where(e=>e.DeletedAt == null).Select(e=> new {e.EmpId,e.EmpCode,e.Name1,e.Name2}).ToListAsync());
        }


        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(GUsersDto dto)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");
               GUser getUser = await _db.GUsers.FindAsync(dto.UserId);
                if (getUser == null)
                {
                    GUser existingUserCode = await _db.GUsers.Where(c => c.UserCode == dto.UserCode).FirstOrDefaultAsync();
                    if (existingUserCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.UserCode} ",
                            messageEn = $"This user code already exists {dto.UserCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    var NewUser = _mapper.Map<GUsersDto,GUser>(dto);

                    _db.GUsers.Add(NewUser);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = NewUser.UserId
                    };

                    return Ok(response);

                }
                else
                {
                    _mapper.Map(dto, getUser);
                    await _db.SaveChangesAsync();


                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "Employee has been modified successfully",
                        id = getUser.UserId

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


        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            try
            {
                if (userId == 0) return BadRequest("userId is equal zero");

                GUser getUser = await _db.GUsers.FindAsync(userId);


                if (getUser == null) return NotFound("user is not found");

                getUser.IsActive = false;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "deleted successfully",
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

        private static readonly string[] ArabicMonthNames = new[]
         {
             "يناير", "فبراير", "مارس", "أبريل", "مايو", "يونيو",
             "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"
         };


        [HttpGet("GetDateRanges")]
        public IActionResult GetDateRanges(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest("تاريخ البداية يجب أن يكون قبل تاريخ النهاية.");
            }

            var dateRanges = new List<DateRange>();

            var current = new DateTime(startDate.Year, startDate.Month, 1);
            var end = new DateTime(endDate.Year, endDate.Month, 1).AddMonths(1).AddDays(-1);

            while (current <= end)
            {
                var monthStart = new DateTime(current.Year, current.Month, 1);
                var monthEnd = monthStart.AddMonths(1).AddDays(-1);

                if (monthStart < startDate)
                {
                    monthStart = startDate;
                }
                if (monthEnd > endDate)
                {
                    monthEnd = endDate;
                }

                var monthNameEnglish = monthStart.ToString("MMMM", CultureInfo.InvariantCulture);
                //var monthNameArabic = monthStart.ToString("MMMM", new CultureInfo("ar-SA"));
                var monthNameArabic = ArabicMonthNames[monthStart.Month - 1];


                dateRanges.Add(new DateRange
                {
                    MonthNameEnglish = monthNameEnglish,
                    MonthNameArabic = monthNameArabic,
                    StartDate = monthStart,
                    EndDate = monthEnd
                });

                current = current.AddMonths(1);
            }

            return Ok(dateRanges);
        }
    }
}
