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
    public class AccountController : ControllerBase
    {
        private readonly ERPContext _db;
        public AccountController(ERPContext db)
        {
            _db = db;
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
    }
}
