using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysBooksController : ControllerBase
    {
        private readonly ERPContext _db;

        public SysBooksController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllSysBooks")]
        public async Task<IActionResult> GetAllSysBooks()
        {
            return Ok(await _db.SysBooks.Where(b => b.DeletedAt == null).OrderByDescending(b => b.CreatedAt).ToListAsync());
        }

        [HttpGet("GetAllSysTermType")]
        public async Task<IActionResult> GetAllSysTermType()
        {
            return Ok(await _db.SystermTypes.ToListAsync());
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _db.GUsers.Where(s => s.DeletedAt == null).ToListAsync());
        }

        [HttpGet("GetAllBranch")]
        public async Task<IActionResult> GetAllBranch()
        {
            return Ok(await _db.MsStores.Where(s => s.DeletedAt == null).ToListAsync());
        }


        [HttpPost("AddSysBook")]
        public async Task<IActionResult> AddSysBook(SysBookDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                SysBook getBook = await _db.SysBooks.FindAsync(dto.BookId);

                if (getBook == null)
                {


                    SysBook existingSysBookCode = await _db.SysBooks.Where(c => c.PrefixCode == dto.PrefixCode).FirstOrDefaultAsync();
                    if (existingSysBookCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.PrefixCode}  ",
                            messageEn = $"This SysBook code already exists {dto.PrefixCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    SysBook newSysBook = new SysBook
                    {
                        PrefixCode = dto.PrefixCode,
                        BookNameAr = dto.BookNameAr,
                        BookNameEn = dto.BookNameEn,
                        TermType = dto.TermType,
                        StoreId = dto.StoreId,
                        UserId = dto.UserId,
                        StartNum = dto.StartNum,
                        EndNum = dto.EndNum,
                        AutoSerial = dto.AutoSerial,
                        IsDefault = dto.IsDefault,
                        SystemIssuedOnly = dto.SystemIssuedOnly,
                        CreatedAt = DateTime.Now
                    };

                    _db.SysBooks.Add(newSysBook);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = newSysBook.BookId
                    };

                    return Ok(response);
                }
                else
                {
                    getBook.BookNameAr = dto.BookNameAr;
                    getBook.BookNameEn = dto.BookNameEn;
                    getBook.TermType = dto.TermType;
                    getBook.StoreId = dto.StoreId;
                    getBook.UserId = dto.UserId;
                    getBook.StartNum = dto.StartNum;
                    getBook.EndNum = dto.EndNum;
                    getBook.AutoSerial = dto.AutoSerial;
                    getBook.IsDefault = dto.IsDefault;
                    getBook.SystemIssuedOnly = dto.SystemIssuedOnly;
                    getBook.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "SysBook has been modified successfully",
                        id = getBook.BookId

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

        [HttpDelete("DeleteCity")]
        public async Task<IActionResult> DeleteSysBook(int BookId)
        {
            try
            {
                if (BookId == 0) return BadRequest("BookId  is equal zero");

                SysBook getBook = await _db.SysBooks.FindAsync(BookId);


                if (getBook == null) return NotFound("SysBook is not found");

                getBook.DeletedAt = DateTime.Now;
                await _db.SaveChangesAsync();

                var response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "SysBook deleted successfully",
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
