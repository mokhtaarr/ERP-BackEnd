using DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
