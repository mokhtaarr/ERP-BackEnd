using DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCategoryController : ControllerBase
    {
        private readonly ERPContext _db;
        public CustomerCategoryController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllCustomerCategory")]
        public async Task<IActionResult> GetAllCustomerCategory()
        {
            return Ok(await _db.MsCustomerCategories.ToListAsync());
        }
    }
}
