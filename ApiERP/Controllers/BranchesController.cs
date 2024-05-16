using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {

        private readonly ERPContext _db;

        public BranchesController(ERPContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<ActionResult> GetAllBranches() {
            return Ok(await _db.MsStores.Select(s => new {s.StoreId,s.StoreCode,s.StoreDescA , s.StoreDescE,s.DeletedAt}).Where(s=>s.DeletedAt == null).ToListAsync());
        }


      

        [HttpGet("storeId")]
        public async Task<IActionResult> GetBranch(int storeId)
        {
            try
            {
                if (storeId == 0)
                    return BadRequest("storeId is empty");


                //var branch = await _db.MsStores.SingleOrDefaultAsync(s => s.StoreId == storeId);

                var branch = await _db.MsStores.Where(s => s.StoreId == storeId).Select(s => new  { s.StoreId,s.StoreCode,s.StoreDescA, s.StoreDescE }).SingleOrDefaultAsync();
                


                if (branch == null)
                    return NotFound("the branch is not found"); 
                

                return Ok(branch);
            }
            catch (Exception ex)
            {
               return Ok(ex.Message);
            }
        }


        [HttpGet("partation-of-StoreId")]
        public async Task<IActionResult> GetPartition(int storeId)
        {
            try
            {

                if (storeId == 0)
                    return Ok();

                var getPartition = await _db.MsPartitions.Where(p => p.StoreId == storeId)
                    .Select(p=> new {p.StorePartId , p.PartCode,p.PartDescA,p.PartDescE,p.CreatedAt,p.DeletedAt}).Where(p=>p.DeletedAt == null).OrderByDescending(p=>p.CreatedAt).ToListAsync();

                if (getPartition == null)
                    return NotFound("the partition is not found");

                return Ok(getPartition);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddPartition")]
        public async Task<IActionResult> AddPartition(MsPartitionDto dto)
        {
            try
            {

                if (dto == null)
                    return BadRequest("the model is Empty");


                MsPartition getPartition = await _db.MsPartitions.Where(p => p.PartCode == dto.partCode).FirstOrDefaultAsync();

                if(getPartition != null)
                {

                    var Update_Response = new
                    {
                        status = false,
                        message = "كود هذا المخزن موجود من قبل يرجى تغييره",
                        messageEn = "This store code already exists, please change it",
                        storeId = dto.storeId
                    };

                    return Ok(Update_Response);
                }
                else
                {
                    MsPartition mspartition = new MsPartition
                    {
                        StoreId = dto.storeId,
                        PartCode = dto.partCode,
                        PartDescA = dto.partDescA,
                        PartDescE = dto.partDescE,
                        Remarks = dto.remarks,
                        CreatedAt = DateTime.Now,
                    };

                    await _db.MsPartitions.AddAsync(mspartition);
                    _db.SaveChanges();

                    var response = new
                    {
                        status = true,
                        message = "تم إضافة المخزن بنجاح",
                        messageEn = "The partition is added successfully",
                        storeId = dto.storeId
                    };

                    return Ok(response);
                }
               
            }
            catch 
            {
                var response = new
                {
                    status = false,
                    message = "حدث خطا أثناء إضافة المخزن",
                    messageEn = "something went wrong",
                };

                return Ok(response);
            }
        }


        [HttpPost("UpdatePartition")]
        public async Task<IActionResult> UpdatePartition(MsPartitionDto dto)
        {
            try
            {

                if (dto == null)
                    return BadRequest("the model is Empty");


                MsPartition getPartition = await _db.MsPartitions.Where(p => p.PartCode == dto.partCode).FirstOrDefaultAsync();


                if (getPartition != null)
                {
                    getPartition.PartDescA = dto.partDescA;
                    getPartition.PartDescE = dto.partDescE;
                    getPartition.StoreId = dto.storeId;
                    getPartition.Remarks = dto.remarks;
                    _db.SaveChanges();

                    var Update_Response = new
                    {
                        status = true,
                        message = "تم تعديل المخزن بنجاح",
                        messageEn = "The partition is update successfully",
                        storeId = dto.storeId
                    };

                    return Ok(Update_Response);
                }
                else
                {
                    var response = new
                    {
                        status = false,
                        message = "حدث خطا أثناء تعديل بيانات المخزن",
                        messageEn = "something went wrong",
                    };

                    return Ok(response);
                }

            }
            catch
            {
                var response = new
                {
                    status = false,
                    message = "حدث خطا أثناء إضافة المخزن",
                    messageEn = "something went wrong",
                };

                return Ok(response);
            }
        }


        [HttpGet("GetPartition")]
        public async Task<IActionResult> GetPartition(string partCode)
        {
            if (partCode == null)
                return BadRequest("Empty partition Code");

            var getData = await _db.MsPartitions.Select(p => new { p.StoreId, p.PartCode, p.PartDescA, p.PartDescE,p.Remarks })
                .FirstOrDefaultAsync(p => p.PartCode == partCode);

            if (getData == null)
                return BadRequest("data is not found for this partition code");

            return Ok(getData);
        }

        [HttpDelete("DeletePartition/partitionCode")]
        public async Task<IActionResult> DeletePartition(string partitionCode)
        {
            try
            {
                if(partitionCode.Length == 0 )
                {
                    var Bad_response = new
                    {
                        status = false,
                        message = "لا يوجد داتا في الكود الخاص بالمخزن",
                        messageEn = "partition Code is empty",
                    };

                    return Ok(Bad_response);
                }

                MsPartition getPartition = await _db.MsPartitions.Where(p=>p.PartCode == partitionCode).FirstOrDefaultAsync();

                if(getPartition == null)
                {
                    var NotFound_response = new
                    {
                        status = false,
                        message = "لايوجد داتا لهذا  المخزن",
                        messageEn = "There is no data for this partition",
                    };

                    return Ok(NotFound_response);
                }

                getPartition.DeletedAt = DateTime.Now;
                _db.SaveChanges();

                var delete_response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Deleted successfully",
                };

                return Ok(delete_response);
            }
            catch
            {
                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء أضافة الفرع",
                    messageEn = "something went wrong",
                };

                return Ok(Bad_response);
            }
        }

        [HttpPost("AddStore")]
        public async Task<IActionResult> AddStore(AddmsStoreDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(dto);

                MsStore existStore = await _db.MsStores.FindAsync(dto.StoreId);

                if(existStore == null)
                {

                    MsStore existStoreCode = _db.MsStores.Where(s => s.StoreCode == dto.StoreCode).FirstOrDefault();
                    if (existStoreCode != null)
                    {

                        var Bad_response = new
                        {
                            status = false,
                            message = $" كود هذا الفرع موجود من قبل {dto.StoreCode}  ",
                            messageEn = $"This store code already exists {dto.StoreCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsStore store = new MsStore()
                    {
                        StoreCode = dto.StoreCode,
                        StoreDescA = dto.StoreDescA,
                        StoreDescE = dto.StoreDescE,
                        Tel = dto.Tel,
                    };

                    _db.MsStores.Add(store);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم أضافة الفرع بنجاح",
                        messageEn = "The branch has been added successfully",
                    };

                    return Ok(response);

                }
                else
                {
                    existStore.StoreDescA = dto.StoreDescA;
                    existStore.StoreDescE = dto.StoreDescE;
                    existStore.Tel = dto.Tel;

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم تعديل الفرع بنجاح",
                        messageEn = "Store has been modified successfully",
                    };

                    return Ok(response);
                }


            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("UpdateStore")]
        public async Task<IActionResult> UpdateStore(msStoreDto dto)
        {
            try
            {
                if (dto.StoreId == 0)
                    return BadRequest("storeId is equal 0");

                MsStore getStore = await _db.MsStores.FindAsync(dto.StoreId);

                if (getStore == null)
                    return NotFound("This branch does not found");

                getStore.StoreDescA = dto.StoreDescA;
                getStore.StoreDescE = dto.StoreDescE;
                getStore.Tel = dto.Tel;

                _db.SaveChanges();

                var response = new
                {
                    status = true,
                    message = "تم تعديل بيانات الفرع بنجاح",
                    messageEn = "The branch data has been successfully modified",
                };

                return Ok(response);
            }
            catch
            {

                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء أضافة الفرع",
                    messageEn = "something went wrong",
                };

                return Ok(Bad_response);
            }
        }

        [HttpDelete("DeleteStore/StoreId")]
        public async Task<IActionResult> DeleteStore(int storeId)
        {
            try
            {
                if (storeId == 0)
                {
                    var Bad_response = new
                    {
                        status = false,
                        message = "بيساوى صفر storeId",
                        messageEn = "storeId equal zero",
                    };

                    return Ok(Bad_response);
                }

                MsStore getStore = await _db.MsStores.FindAsync(storeId);

                if (getStore == null)
                {
                    var NotFound_response = new
                    {
                        status = false,
                        message = "لايوجد داتا لهذا الفرع",
                        messageEn = "There is no data for this branch",
                    };

                    return Ok(NotFound_response);
                }

                getStore.DeletedAt = DateTime.Now;
                _db.SaveChanges();

                var delete_response = new
                {
                    status = true,
                    message = "تم الحذف بنجاح",
                    messageEn = "Deleted successfully",
                };

                return Ok(delete_response);

            }
            catch
            {

                var Bad_response = new
                {
                    status = false,
                    message = "حدث خطأ اثناء أضافة الفرع",
                    messageEn = "something went wrong",
                };

                return Ok(Bad_response);
            }
        }
    }
}
