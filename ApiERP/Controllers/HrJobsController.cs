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
            var query = await (from job in _db.HrJobs
                               where job.DeletedAt == null && job.ParentId == null
                               select new 
                               {

                                   jobId = job.JobId,
                                   departMentId = job.DepartMentId,
                                   jcode = job.Jcode,
                                   jname1 = job.Jname1,
                                   jname2 = job.Jname2,
                                   jdesc = job.Jdesc,
                                   jresponsibilities = job.Jresponsibilities,
                                   jqualifications = job.Jqualifications,
                                   jduties = job.Jduties,
                                   remarks = job.Remarks,
                                   parentId = job.ParentId,
                                   standardMonthlyWage = job.StandardMonthlyWage,
                                   standardHolyDays = job.StandardHolyDays,
                                   standardDailyWage = job.StandardDailyWage,
                                   standardDailyWorkHours = job.StandardDailyWorkHours,
                                   standardHourlyWage= job.StandardHourlyWage,
                                   numberAvailable = job.NumberAvailable,

                                   children = _db.HrJobs.Where(d => d.DeletedAt == null && d.ParentId == job.JobId)
                                   .Select(job => new {
                                       jobId = job.JobId,
                                       departMentId = job.DepartMentId,
                                       jcode = job.Jcode,
                                       jname1 = job.Jname1,
                                       jname2 = job.Jname2,
                                       jdesc = job.Jdesc,
                                       jresponsibilities = job.Jresponsibilities,
                                       jqualifications = job.Jqualifications,
                                       jduties = job.Jduties,
                                       remarks = job.Remarks,
                                       parentId = job.ParentId,
                                       standardMonthlyWage = job.StandardMonthlyWage,
                                       standardHolyDays = job.StandardHolyDays,
                                       standardDailyWage = job.StandardDailyWage,
                                       standardDailyWorkHours = job.StandardDailyWorkHours,
                                       standardHourlyWage = job.StandardHourlyWage,
                                       numberAvailable = job.NumberAvailable,
                                       children = _db.HrJobs.Where(d => d.DeletedAt == null && d.ParentId == job.JobId)
                                                     .Select(job => new {
                                                         jobId = job.JobId,
                                                         departMentId = job.DepartMentId,
                                                         jcode = job.Jcode,
                                                         jname1 = job.Jname1,
                                                         jname2 = job.Jname2,
                                                         jdesc = job.Jdesc,
                                                         jresponsibilities = job.Jresponsibilities,
                                                         jqualifications = job.Jqualifications,
                                                         jduties = job.Jduties,
                                                         remarks = job.Remarks,
                                                         parentId = job.ParentId,
                                                         standardMonthlyWage = job.StandardMonthlyWage,
                                                         standardHolyDays = job.StandardHolyDays,
                                                         standardDailyWage = job.StandardDailyWage,
                                                         standardDailyWorkHours = job.StandardDailyWorkHours,
                                                         standardHourlyWage = job.StandardHourlyWage,
                                                         numberAvailable = job.NumberAvailable,
                                                         children = _db.HrJobs.Where(d => d.DeletedAt == null && d.ParentId == job.JobId)
                                                             .Select(job => new {
                                                                 jobId = job.JobId,
                                                                 departMentId = job.DepartMentId,
                                                                 jcode = job.Jcode,
                                                                 jname1 = job.Jname1,
                                                                 jname2 = job.Jname2,
                                                                 jdesc = job.Jdesc,
                                                                 jresponsibilities = job.Jresponsibilities,
                                                                 jqualifications = job.Jqualifications,
                                                                 jduties = job.Jduties,
                                                                 remarks = job.Remarks,
                                                                 parentId = job.ParentId,
                                                                 standardMonthlyWage = job.StandardMonthlyWage,
                                                                 standardHolyDays = job.StandardHolyDays,
                                                                 standardDailyWage = job.StandardDailyWage,
                                                                 standardDailyWorkHours = job.StandardDailyWorkHours,
                                                                 standardHourlyWage = job.StandardHourlyWage,
                                                                 numberAvailable = job.NumberAvailable,
                                                                 children = _db.HrJobs.Where(d => d.DeletedAt == null && d.ParentId == job.JobId)
                                                                           .Select(job => new {
                                                                               jobId = job.JobId,
                                                                               departMentId = job.DepartMentId,
                                                                               jcode = job.Jcode,
                                                                               jname1 = job.Jname1,
                                                                               jname2 = job.Jname2,
                                                                               jdesc = job.Jdesc,
                                                                               jresponsibilities = job.Jresponsibilities,
                                                                               jqualifications = job.Jqualifications,
                                                                               jduties = job.Jduties,
                                                                               remarks = job.Remarks,
                                                                               parentId = job.ParentId,
                                                                               standardMonthlyWage = job.StandardMonthlyWage,
                                                                               standardHolyDays = job.StandardHolyDays,
                                                                               standardDailyWage = job.StandardDailyWage,
                                                                               standardDailyWorkHours = job.StandardDailyWorkHours,
                                                                               standardHourlyWage = job.StandardHourlyWage,
                                                                               numberAvailable = job.NumberAvailable,
                                                                           
                                                                           }).ToList()

                                                             }).ToList()

                                                     }).ToList()
                                   }).ToList()


                               }).ToListAsync();



            return Ok(query);
        }


        [HttpGet("GetAllHrJobForSelect")]
        public async Task<IActionResult> GetAllHrJobForSelect()
        {
            return Ok(await _db.HrJobs.Where(j => j.DeletedAt == null).Select(j => new { j.JobId, j.Jname1, j.Jname2,j.CreatedAt })
                .OrderByDescending(j=>j.CreatedAt).ToListAsync());
        }


        [HttpPost("AddHrJob")]
        public async Task<IActionResult> AddHrJob(HrJobDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                HrJob getHrJob = await _db.HrJobs.FindAsync(dto.JobId);

                if (getHrJob == null)
                {


                    HrJob existingCode = await _db.HrJobs.Where(c => c.Jcode == dto.Jcode).FirstOrDefaultAsync();
                    if (existingCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.Jcode}  ",
                            messageEn = $"This Jod code already exists {dto.Jcode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                     HrJob addJob = new HrJob
                     {
                         DepartMentId = dto.DepartMentId,
                         Jcode = dto.Jcode,
                         Jname1 = dto.Jname1,
                         Jname2 = dto.Jname2,
                         Jdesc = dto.Jdesc,
                         Jresponsibilities = dto.Jresponsibilities,
                         Jqualifications = dto.Jqualifications,
                         Jduties = dto.Jduties,
                         Remarks = dto.Remarks,
                         ParentId = dto.ParentId,
                         StandardMonthlyWage = dto.StandardMonthlyWage,
                         StandardHolyDays = dto.StandardHolyDays,
                         StandardHourlyWage=dto.StandardHourlyWage,
                         StandardDailyWage = dto.StandardDailyWage,
                         StandardDailyWorkHours = dto.StandardDailyWorkHours,
                         NumberAvailable = dto.NumberAvailable,
                         CreatedAt = DateTime.Now
                     };

                    _db.HrJobs.Add(addJob);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        Id = addJob.JobId,
                    };

                    return Ok(response);
                }
                else
                {
                    getHrJob.DepartMentId = dto.DepartMentId;
                    getHrJob.Jname1 = dto.Jname1;
                    getHrJob.Jname2 = dto.Jname2;
                    getHrJob.Jdesc = dto.Jdesc;
                    getHrJob.Jresponsibilities = dto.Jresponsibilities;
                    getHrJob.Jqualifications = dto.Jqualifications;
                    getHrJob.Jduties = dto.Jduties;
                    getHrJob.Remarks = dto.Remarks;
                    getHrJob.ParentId = dto.ParentId;
                    getHrJob.StandardMonthlyWage = dto.StandardMonthlyWage;
                    getHrJob.StandardHolyDays = dto.StandardHolyDays;
                    getHrJob.StandardHourlyWage = dto.StandardHourlyWage;
                    getHrJob.StandardDailyWage = dto.StandardDailyWage;
                    getHrJob.StandardDailyWorkHours = dto.StandardDailyWorkHours;
                    getHrJob.NumberAvailable = dto.NumberAvailable;
                    getHrJob.UpdateAt = DateTime.Now;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "department has been modified successfully",
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


        [HttpDelete("DeleteHrJob")]
        public async Task<IActionResult> DeleteHrJob(int JobId)
        {
            try
            {
                if (JobId == 0) return BadRequest("JobId is equal zero");

                HrJob getHrJob = await _db.HrJobs.FindAsync(JobId);

                if (getHrJob == null) return NotFound("HR Job is not found");

                getHrJob.DeletedAt = DateTime.Now;
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




    }
}
