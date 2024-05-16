using DAL.Context;
using DAL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrJobsController : ControllerBase
    {
        private readonly ERPContext _db;
        public HrJobsController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllHrJobs")]
        public async Task<IActionResult> GetAllHrJobs()
        {
            var query = await  (from hrJobs in _db.HrJobs
                               where hrJobs.DeletedAt == null
                               select new 
                               {
                                   name = hrJobs.Jname1,
                                   //children =  _db.HrJobs.Where(j => j.DeletedAt == null && j.JobId == hrJobs.ParentId).Select(j=> new {name = j.Jname1}).ToList(),
                                   children = _db.HrJobs.Where(j => j.DeletedAt == null && j.JobId == hrJobs.ParentId)
                                   .Select(j=> new {
                                       jobId = j.JobId,
                                       name = j.Jname1,
                                       nameEn = j.Jname2,
                                       Jname1 = j.Jname1

                                   }).ToList(),
                               }).ToListAsync();

            return Ok(query);
        }
    }
}
