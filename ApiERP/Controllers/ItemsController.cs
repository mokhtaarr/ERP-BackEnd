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
    public class ItemsController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ItemsController(ERPContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            return Ok(await _db.MsItemCards.Select(p => new { p.ItemCardId, p.ItemDescA }).ToListAsync());
        }

        [HttpPost("AddItem")]
        public async Task<IActionResult> AddItem([FromForm]MsItemcardDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("يوجد خطا في البيانات المرسله يرجى مرجعتها"); 
            }


            try
            {

                MsItemCard getRecord = await _db.MsItemCards.FindAsync(dto.ItemCardId);

                if (getRecord != null)
                {
                    getRecord.ItemCode = dto.ItemCode;
                    getRecord.ItemDescA = dto.ItemDescA;

                    _db.SaveChanges();

                    return Ok();
                }

                MsItemCard item = new MsItemCard
                {
                    ItemCode = dto.ItemCode,
                    ItemDescA = dto.ItemDescA,
                    ItemDescE = dto.ItemDescE,

                };

                _db.MsItemCards.Add(item);
                await _db.SaveChangesAsync();


                if (dto.Image != null && dto.Image.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Items-uploads");
                    var cleanFileName = dto.Image.FileName.Replace("-", "");

                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + cleanFileName;
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await dto.Image.CopyToAsync(fileStream);
                    }

                    MsItemImage image = new MsItemImage
                    {
                        ItemCardId = item.ItemCardId,
                        ImgPath = uniqueFileName,
                        ImgDesc1 = dto.ImgDesc1,
                        ImgDesc2 = dto.ImgDesc2
                    };

                    _db.MsItemImages.Add(image);
                    await _db.SaveChangesAsync();

                }


                return Ok();
            }
            catch (Exception ex)
            {
                {
                    return StatusCode(500, $"حدث خطأ: {ex.Message}"); 
                }
            }

           
        }
    }
}
