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
    public class HrDepartmentsController : ControllerBase
    {
        private readonly ERPContext _db;
        public HrDepartmentsController(ERPContext db)
        {
            _db = db;
        }

        [HttpGet("GetAllHrDepartments")]
        public async Task<IActionResult> GetAllHrDepartments()
      {
            var query = await (from department in _db.HrDepartments
                               where department.DeletedAt == null && department.ParentId == null
                               select new
                               {
                                   departMentId = department.DepartMentId,
                                   departCode = department.DepartCode,
                                   name = department.DepartName1,
                                   departName1 = department.DepartName1,
                                   departName2 = department.DepartName2,
                                   parentId = department.ParentId,
                                   departTask = department.DepartTask,
                                   remarks = department.Remarks,
                                   children = _db.HrDepartments.Where(d => d.DeletedAt == null && d.ParentId == department.DepartMentId)
                                   .Select(department => new {
                                       departMentId = department.DepartMentId,
                                       departCode = department.DepartCode,
                                       name = department.DepartName1,
                                       departName2 = department.DepartName2,
                                       parentId = department.ParentId,
                                       departTask = department.DepartTask,
                                       remarks = department.Remarks,
                                       children = _db.HrDepartments.Where(d => d.DeletedAt == null && d.ParentId == department.DepartMentId)
                                                 .Select(department => new {
                                                     departMentId = department.DepartMentId,
                                                     departCode = department.DepartCode,
                                                     name = department.DepartName1,
                                                     departName2 = department.DepartName2,
                                                     parentId = department.ParentId,
                                                     departTask = department.DepartTask,
                                                     remarks = department.Remarks,
                                                     children = _db.HrDepartments.Where(d => d.DeletedAt == null && d.ParentId == department.DepartMentId)
                                                      .Select(department => new {
                                                          departMentId = department.DepartMentId,
                                                          departCode = department.DepartCode,
                                                          name = department.DepartName1,
                                                          departName2 = department.DepartName2,
                                                          parentId = department.ParentId,
                                                          departTask = department.DepartTask,
                                                          remarks = department.Remarks,
                                                          children = _db.HrDepartments.Where(d => d.DeletedAt == null && d.ParentId == department.DepartMentId)
                                                            .Select(department => new {
                                                                departMentId = department.DepartMentId,
                                                                departCode = department.DepartCode,
                                                                name = department.DepartName1,
                                                                departName2 = department.DepartName2,
                                                                parentId = department.ParentId,
                                                                departTask = department.DepartTask,
                                                                remarks = department.Remarks,
                                                                children = _db.HrDepartments.Where(d => d.DeletedAt == null && d.ParentId == department.DepartMentId)
                                                                    .Select(department => new {
                                                                        departMentId = department.DepartMentId,
                                                                        departCode = department.DepartCode,
                                                                        name = department.DepartName1,
                                                                        departName2 = department.DepartName2,
                                                                        parentId = department.ParentId,
                                                                        departTask = department.DepartTask,
                                                                        remarks = department.Remarks,

                                                                    }).ToList()
                                                              }).ToList()

                                                       }).ToList()

                                                 }).ToList()
                                   }).ToList()

                               }).ToListAsync();

            return Ok(query);
        }

        [HttpPost("AddHrDepartment")]
        public async Task<IActionResult> AddHrDepartment(HrDepartmentDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                HrDepartment getdepartment = await _db.HrDepartments.FindAsync(dto.departMentId);

                if (getdepartment == null)
                {


                    HrDepartment existingDepartment = await _db.HrDepartments.Where(c => c.DepartCode == dto.departCode).FirstOrDefaultAsync();
                    if (existingDepartment is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" كود هذا القسم موجود من قبل {dto.departCode}  ",
                            messageEn = $"This department code already exists {dto.departCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    HrDepartment addDepartment = new HrDepartment
                    {
                        DepartCode = dto.departCode,
                        DepartName1 = dto.name,
                        DepartName2 = dto.departName2,
                        DepartTask = dto.departTask,
                        Remarks = dto.remarks,
                        ParentId = dto.parentId,
                    };

                    _db.HrDepartments.Add(addDepartment);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                    };

                    return Ok(response);
                }
                else
                {
                    getdepartment.DepartName1 = dto.name;
                    getdepartment.DepartName2 = dto.departName2;
                    getdepartment.DepartTask = dto.departTask;
                    getdepartment.Remarks = dto.remarks;
                    getdepartment.ParentId = dto.parentId;

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



        [HttpDelete("DeleteHrDepartment")]
        public async Task<IActionResult> DeleteHrDepartment(int departMentId)
        {
            try
            {
                if (departMentId == 0) return BadRequest("departMentId is equal zero");

                HrDepartment getHrDepartment = await _db.HrDepartments.FindAsync(departMentId);

                if (getHrDepartment == null) return NotFound("HR Department is not found");

                getHrDepartment.DeletedAt = DateTime.Now;
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
