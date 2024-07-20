using AutoMapper;
using DAL.Context;
using DAL.Dtos;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace ApiERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ERPContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;


        public ItemsController(ERPContext db, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            return Ok(await _db.MsItemCards.Where(i=>i.DeletedAt == null).OrderByDescending(i=>i.ItemCardId).Take(100).AsNoTracking().ToListAsync());
        }



        [HttpGet("is-used-item/{itemCardId}")]
        public async Task<IActionResult> IsUsedItem(int itemCardId)
        {
            var results = await _db.IsUsedItemAsync(itemCardId);
            return Ok(results);
        }

        [HttpPost("AddItemWitImage")]
        public async Task<IActionResult> AddItemWitImage([FromForm]MsItemCardWithImage dto)
        {
            ResponseDto res = new ResponseDto();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("يوجد خطا في البيانات المرسله يرجى مرجعتها");
                }


                if (dto.Image != null && dto.Image.Length > 0)
                {
                    MsItemImage getImage = await _db.MsItemImages.FirstOrDefaultAsync(m=>m.ItemCardId == dto.ItemCardId);
                    if(getImage is null)
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
                            ItemCardId = dto.ItemCardId,
                            ImgPath = uniqueFileName,
                            ImgDesc1 = dto.ImgDesc1,
                            ImgDesc2 = dto.ImgDesc2
                        };

                        _db.MsItemImages.Add(image);
                        await _db.SaveChangesAsync();
                    }
                    else
                    {
                        var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Items-uploads");
                        var cleanFileName = dto.Image.FileName.Replace("-", "");

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + cleanFileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await dto.Image.CopyToAsync(fileStream);
                        }

                        getImage.ImgPath = uniqueFileName;
                        getImage.ImgDesc1 = dto.ImgDesc1;
                        getImage.ImgDesc2 = dto.ImgDesc2;
                        await _db.SaveChangesAsync();


                    }


                }

                return Ok();


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

        [HttpPost("AddMsItemCard")]
        public async Task<IActionResult> AddMsItemCard([FromBody]MsItemcardDto dto)
        {
            var trans = await _db.Database.BeginTransactionAsync();
            ResponseDto res = new ResponseDto();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("يوجد خطا في البيانات المرسله يرجى مرجعتها");
                }


                MsItemCard getRecord = await _db.MsItemCards.FindAsync(dto.ItemCardId);

                if (getRecord == null)
                {
                    MsItemCard existingItemCode = await _db.MsItemCards.Where(c => c.ItemCode == dto.ItemCode).FirstOrDefaultAsync();
                    if (existingItemCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.ItemCode}  ",
                            messageEn = $"This item  code already exists {dto.ItemCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }

                    MsItemCard NewItem = _mapper.Map<MsItemcardDto, MsItemCard>(dto);

                    _db.MsItemCards.Add(NewItem);
                    await _db.SaveChangesAsync();

                    //if (dto.BasUnitId != null || dto.BasUnitId != 0)
                    //{
                    //    MsItemUnit BasicUnit = new MsItemUnit
                    //    {
                    //        ItemCardId = NewItem.ItemCardId,
                    //        UnitCode = dto.UnitCode,
                    //        UnitNam = dto.UnitNam,
                    //        UnitNameE = dto?.UnitNameE,
                    //        Symbol = dto?.Symbol,
                    //        BasUnitId = dto.BasUnitId,
                    //        UnittRate = dto?.UnittRate,
                    //        EtaxUnitCode = dto.EtaxUnitCode,
                    //        CannotDevide = dto.cannotDevide
                    //    };

                    //    _db.MsItemUnits.Add(BasicUnit);
                    //    await _db.SaveChangesAsync();
                    //}



                    if(dto.list != null)
                    {
                        foreach (var itemUnit in dto.list)
                        {
                            MsItemUnit NewItemUnit = new MsItemUnit
                            {
                                UnitCode = itemUnit.UnitCode,
                                UnitNam = itemUnit.UnitNam,
                                UnitNameE = itemUnit?.UnitNameE,
                                ItemCardId = NewItem.ItemCardId,
                                BasUnitId = dto.BasUnitId,
                                UnittRate = itemUnit?.UnittRate,
                                Symbol = itemUnit?.Symbol,
                                BarCode1 = itemUnit?.BarCode1,
                                BarCode2 = itemUnit?.BarCode2,
                                BarCode3 = itemUnit?.BarCode3,
                                BarCode4 = itemUnit?.BarCode4,
                                BarCode5 = itemUnit?.BarCode5,
                                BarCode6 = itemUnit?.BarCode6,
                                BarCode7 = itemUnit?.BarCode7,
                                BarCode8 = itemUnit?.BarCode8,
                                BarCode9 = itemUnit?.BarCode9,
                                BarCode10 = itemUnit?.BarCode10,
                                BarCode11 = itemUnit?.BarCode11,
                                BarCode12 = itemUnit?.BarCode12,
                                BarCode13 = itemUnit?.BarCode13,
                                BarCode14 = itemUnit?.BarCode14,
                                BarCode15 = itemUnit?.BarCode15,
                                EtaxUnitCode = itemUnit?.EtaxUnitCode,
                                Quantity1 = itemUnit?.Quantity1,
                                Quantity2 = itemUnit?.Quantity2,
                                Quantity3 = itemUnit?.Quantity3,
                                Quantity4 = itemUnit?.Quantity4,
                                Quantity5 = itemUnit?.Quantity5,
                                Price1 = itemUnit?.Price1,
                                Price2 = itemUnit?.Price2,
                                Price3 = itemUnit?.Price3,
                                Price4 = itemUnit?.Price4,
                                Price5 = itemUnit?.Price5,
                                Price6 = itemUnit?.Price6,
                                Price7 = itemUnit?.Price7,
                                Price8 = itemUnit?.Price8,
                                Price9 = itemUnit?.Price9,
                                Price10 = itemUnit?.Price10,
                                IsDefaultPurchas = itemUnit.IsDefaultPurchas,
                                IsDefaultSale = itemUnit.IsDefaultSale,
                                CannotDevide = itemUnit.CannotDevide,
                            };

                            _db.MsItemUnits.Add(NewItemUnit);
                            await _db.SaveChangesAsync();

                        }
                    }

                    if(dto.itemCollections.Count > 0)
                    {
                        foreach (var itemCollection in dto.itemCollections)
                        {
                            MsItemCollection NewCollection = new MsItemCollection
                            {
                                ItemCardId = NewItem.ItemCardId,
                                SubItemId = itemCollection.ItemCardId,
                                UnitId = itemCollection?.UnitId,
                                ItemType = itemCollection.ItemType,
                                UnitRate = itemCollection.UnitRate,
                                Quantity = itemCollection.Quantity,
                                Remarks = itemCollection.Remarks
                            };

                            _db.MsItemCollections.Add(NewCollection);
                            await _db.SaveChangesAsync();

                        }
                    }

                    if (dto.itemPartition.Count > 0)
                    {
                        foreach (var itemPart in dto.itemPartition)
                        {
                            MsItemCardDefaulPartition NewDefaultPartition = new MsItemCardDefaulPartition
                            {
                                ItemCardId = NewItem.ItemCardId,
                                StoreId = itemPart.StoreId,
                                StorePartId = itemPart.StorePartId
                            };

                            _db.MsItemCardDefaulPartitions.Add(NewDefaultPartition);
                            await _db.SaveChangesAsync();

                        }
                    }

                    if (dto.itemAlternatives.Count > 0)
                    {
                        foreach (var itemnative in dto.itemAlternatives)
                        {
                            MsItemAlternative NewItemNAtive = new MsItemAlternative
                            {
                                ItemCardId = NewItem.ItemCardId,
                                AlterItemCardId = itemnative.ItemCardId,
                                UnitId = itemnative?.UnitId,
                                ItemType = itemnative.ItemType,
                                UnitRate = itemnative.UnitRate,
                                Quantity = itemnative.Quantity,
                                Remarks = itemnative.Remarks
                            };

                            _db.MsItemAlternatives.Add(NewItemNAtive);
                            await _db.SaveChangesAsync();

                        }
                    }
                    await trans.CommitAsync();

                    res.status = true;
                    res.message = "تم الإضافة بنجاح";
                    res.messageEn = "added successfully";
                    res.id = NewItem.ItemCardId;

                    return Ok(res);
                }
                else
                {
                    _mapper.Map(dto, getRecord);
                    await _db.SaveChangesAsync();


                    if (dto.itemCollections.Count > 0)
                    {
                        foreach (var itemCollection in dto.itemCollections)
                        {
                            MsItemCollection NewCollection = new MsItemCollection
                            {
                                ItemCardId = getRecord.ItemCardId,
                                SubItemId = itemCollection.ItemCardId,
                                UnitId = itemCollection?.UnitId,
                                ItemType = itemCollection.ItemType,
                                UnitRate = itemCollection.UnitRate,
                                Quantity = itemCollection.Quantity,
                                Remarks = itemCollection.Remarks
                            };

                            _db.MsItemCollections.Add(NewCollection);
                            await _db.SaveChangesAsync();

                        }
                    }

                    if (dto.itemPartition.Count > 0)
                    {
                        foreach (var itemPart in dto.itemPartition)
                        {
                            MsItemCardDefaulPartition NewDefaultPartition = new MsItemCardDefaulPartition
                            {
                                ItemCardId = getRecord.ItemCardId,
                                StoreId = itemPart.StoreId,
                                StorePartId = itemPart.StorePartId
                            };

                            _db.MsItemCardDefaulPartitions.Add(NewDefaultPartition);
                            await _db.SaveChangesAsync();

                        }
                    }

                    if (dto.itemAlternatives.Count > 0)
                    {
                        foreach (var itemnative in dto.itemAlternatives)
                        {
                            MsItemAlternative NewItemNAtive = new MsItemAlternative
                            {
                                ItemCardId = getRecord.ItemCardId,
                                AlterItemCardId = itemnative.ItemCardId,
                                UnitId = itemnative?.UnitId,
                                ItemType = itemnative.ItemType,
                                UnitRate = itemnative.UnitRate,
                                Quantity = itemnative.Quantity,
                                Remarks = itemnative.Remarks
                            };

                            _db.MsItemAlternatives.Add(NewItemNAtive);
                            await _db.SaveChangesAsync();

                        }
                    }



                    await trans.CommitAsync();

                    res.status = true;
                    res.message = "تم التعديل بنجاح";
                    res.messageEn = "item has been modified successfully";
                    res.id = getRecord.ItemCardId;

                    return Ok(res);

                }


            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();

                if (res.status != null)
                {
                    return Ok(res);
                }
                else
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
        }


        [HttpGet("GetAllItemCategory")]
        public async Task<IActionResult> GetAllItemCategory()
        {
            return Ok(await _db.MsItemCategories.Where(j => j.DeletedAt == null)
                .Select(j => new { j.ItemCategoryId, j.ItemCatCode, j.ItemCatDescA, j.ItemCatDescE })
                .OrderByDescending(j => j.ItemCategoryId).ToListAsync());
        }

        [HttpGet("GetAllMsStores")]
        public async Task<IActionResult> GetAllMsStores()
        {
            return Ok(await _db.MsStores.Where(j => j.DeletedAt == null)
                .Select(j => new { j.StoreId, j.StoreCode, j.StoreDescA, j.StoreDescE })
                .OrderByDescending(j => j.StoreId).ToListAsync());
        }

        [HttpGet("GetAllPartition")]
        public async Task<IActionResult> GetAllPartition()
        {
            return Ok(await _db.MsPartitions.Where(j => j.DeletedAt == null)
                .Select(j => new { j.StorePartId, j.PartCode, j.PartDescA, j.PartDescE })
                .OrderByDescending(j => j.StorePartId).ToListAsync());
        }

        [HttpGet("GetAllItemUnit")]
        public async Task<IActionResult> GetAllItemUnit(int itemCardId)
        {
            return Ok(await _db.MsItemUnits.Where(u=>u.ItemCardId == itemCardId)
                .OrderByDescending(j => j.UnitId).ToListAsync());
        }

        [HttpGet("GetBasicItemUnit")]
        public async Task<IActionResult> GetBasicItemUnit(int basUnitId)
        {
            return Ok(await _db.ProdBasicUnits.AsNoTracking().FirstOrDefaultAsync(u => u.BasUnitId == basUnitId));
                
        }

        [HttpPost("AddItemUnit")]
        public async Task<IActionResult> AddItemUnit(MsItemUnitDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsItemUnit getItemUnit = await _db.MsItemUnits.FindAsync(dto.UnitId);

                if (getItemUnit == null)
                {
                    MsItemUnit existingItemUnitCode = await _db.MsItemUnits.Where(c => c.UnitCode == dto.UnitCode).FirstOrDefaultAsync();
                    if (existingItemUnitCode is not null)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = $" هذا الكود موجود من قبل {dto.UnitCode}  ",
                            messageEn = $"This unit  code already exists {dto.UnitCode}, please change it",

                        };

                        return Ok(Bad_response);
                    }


                    MsItemUnit NewUnit = _mapper.Map<MsItemUnitDto, MsItemUnit>(dto);

                    _db.MsItemUnits.Add(NewUnit);
                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم الإضافة بنجاح",
                        messageEn = "added successfully",
                        id = dto.ItemCardId,
                    };

                    return Ok(response);
                }
                else
                {
                    _mapper.Map(dto, getItemUnit);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "item Unit has been modified successfully",
                        id = getItemUnit.ItemCardId,

                    };

                    return Ok(response);

                }
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

        [HttpPost("UpdateItemUnit")]
        public async Task<IActionResult> UpdateItemUnit(MsItemUnitDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("model is not valid");

                MsItemUnit getItemUnit = await _db.MsItemUnits.FindAsync(dto.UnitId);

                if (getItemUnit == null)
                {
                    return NotFound();
                }
                else
                {
                    _mapper.Map(dto, getItemUnit);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم التعديل بنجاح",
                        messageEn = "item Unit has been modified successfully",
                        id = getItemUnit.ItemCardId,

                    };

                    return Ok(response);

                }
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

        [HttpDelete("DeleteItemUnit")]
        public async Task<IActionResult> DeleteItemUnit(int unitId)
        {
            try
            {
                MsItemUnit getItemUnit = await _db.MsItemUnits.FindAsync(unitId);

                if (getItemUnit == null)
                {
                    return NotFound();
                }
                else
                {
                    _db.MsItemUnits.Remove(getItemUnit);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم المسح بنجاح",
                        messageEn = "item Unit has been deleted successfully",
                    };

                    return Ok(response);

                }
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

        [HttpGet("GetAllProdBsicUnits")]
        public async Task<IActionResult> GetAllProdBsicUnits()
        {
            return Ok(await _db.ProdBasicUnits.Where(b => b.DeletedAt == null && b.ParentUnit == null).AsNoTracking().ToListAsync());
        }

        [HttpGet("GetAllProdBsicUnitsSub")]
        public async Task<IActionResult> GetAllProdBsicUnitsSub(int basUnitId)
        {
            return Ok(await _db.ProdBasicUnits.Where(b => b.DeletedAt == null && b.ParentUnit == basUnitId).AsNoTracking().ToListAsync());
        }

        [HttpGet("GetAllItemForItemCollections")]
        public async Task<IActionResult> GetAllItemForItemCollections()
        {
            var items = await _db.MsItemCards
                .Where(i => i.DeletedAt == null)
                .Include(i => i.MsItemUnits)  // تضمين الكيان المرتبط
                .Select(i => new
                {
                    i.ItemCardId,
                    i.ItemCode,
                    i.ItemDescA,
                    i.ItemDescE,
                    i.ItemType,
                    UnitId = i.MsItemUnits.Select(u => u.UnitId).FirstOrDefault(),
                    UnitRate = i.MsItemUnits.Select(u => u.UnittRate).FirstOrDefault(),
                    UnitNam = i.MsItemUnits.Select(u => u.UnitNam).FirstOrDefault() 
                })
                .ToListAsync();

            return Ok(items);
        }

        [HttpGet("GetItemUnits")]
        public async Task<IActionResult> GetItemUnits(int itemCardId)
        {
            var msitemUnit = await _db.MsItemUnits.Where(u=>u.ItemCardId == itemCardId)
                .Select(u=> new {u.UnitId,u.UnitNam}).ToListAsync();

            if (msitemUnit.Count == 0)
            {
                return Ok();
            }
            else
            {
                return Ok(msitemUnit);
            }
        }




        [HttpGet("GetProductImage")]
        public async Task<IActionResult> GetProductImage(int itemCardId)
        {
            return Ok(await _db.MsItemImages.FirstOrDefaultAsync(i=>i.ItemCardId == itemCardId));
        }


        [HttpGet("GetItemCollection")]
        public async Task<IActionResult> GetItemCollection(int itemCardId)
        {
            var query = await (from itemcollection in _db.MsItemCollections
                               where itemcollection.ItemCardId == itemCardId
                               select new
                               {
                                   itemCollectId = itemcollection.ItemCollectId,
                                   subItemId = itemcollection.SubItemId,
                                   unitId = itemcollection.UnitId,
                                   quantity = itemcollection.Quantity,
                                   remarks = itemcollection.Remarks,
                                   itemCode =  _db.MsItemCards.FirstOrDefault(i=>i.ItemCardId == itemcollection.SubItemId).ItemCode,
                                   itemDescA = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemcollection.SubItemId).ItemDescA,
                                   itemDescE = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemcollection.SubItemId).ItemDescE,
                                   unitNam = _db.MsItemUnits.FirstOrDefault(u=>u.UnitId == itemcollection.UnitId).UnitNam,
                                   itemType = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemcollection.SubItemId).ItemType

                               }).ToListAsync();

            return Ok(query);
        }


        [HttpPost("UpdateItemCollection")]
        public async Task<IActionResult> UpdateItemCollection(msItemCollectionDto dto)
        {
            try
            {
                MsItemCollection getItem = await _db.MsItemCollections.FindAsync(dto.itemCollectId);
                if (getItem == null) return NotFound();

                getItem.UnitId = dto.UnitId;
                getItem.Remarks = dto.Remarks;
                getItem.Quantity = dto.Quantity;

                _db.SaveChanges();

                var response = new
                {
                    status = true,
                    message = "تم التعديل بنجاح",
                    messageEn = "modofied successfully",
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


        [HttpGet("GetItemAlternatives")]
        public async Task<IActionResult> GetItemAlternatives(int itemCardId)
        {
            var query = await (from itemAlter in _db.MsItemAlternatives
                               where itemAlter.ItemCardId == itemCardId
                               select new
                               {
                                   alterId = itemAlter.AlterId,
                                   alterItemCardId = itemAlter.AlterItemCardId,
                                   unitId = itemAlter.UnitId,
                                   quantity = itemAlter.Quantity,
                                   remarks = itemAlter.Remarks,
                                   itemCode = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemAlter.AlterItemCardId).ItemCode,
                                   itemDescA = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemAlter.AlterItemCardId).ItemDescA,
                                   itemDescE = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemAlter.AlterItemCardId).ItemDescE,
                                   unitNam = _db.MsItemUnits.FirstOrDefault(u => u.UnitId == itemAlter.UnitId).UnitNam,
                                   itemType = _db.MsItemCards.FirstOrDefault(i => i.ItemCardId == itemAlter.AlterItemCardId).ItemType

                               }).ToListAsync();

            return Ok(query);
        }

        [HttpPost("UpdateItemAlter")]
        public async Task<IActionResult> UpdateItemAlter(itemsAlternatives dto)
        {
            try
            {
                MsItemAlternative getItem = await _db.MsItemAlternatives.FindAsync(dto.AlterId);
                if (getItem == null) return NotFound();

                getItem.UnitId = dto.UnitId;
                getItem.Remarks = dto.Remarks;
                getItem.Quantity = dto.Quantity;

                _db.SaveChanges();

                var response = new
                {
                    status = true,
                    message = "تم التعديل بنجاح",
                    messageEn = "modofied successfully",
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


        [HttpDelete("DeleteItemAlternative")]
        public async Task<IActionResult> DeleteItemAlternative(int alterId)
        {
            try
            {
                MsItemAlternative getItemAlter = await _db.MsItemAlternatives.FindAsync(alterId);

                if (getItemAlter == null)
                {
                    return NotFound();
                }
                else
                {
                    _db.MsItemAlternatives.Remove(getItemAlter);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم المسح بنجاح",
                        messageEn = "item alternative has been deleted successfully",
                    };

                    return Ok(response);

                }
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


        [HttpGet("GetItemDefaultPartitions")]
        public async Task<IActionResult> GetItemDefaultPartitions(int itemCardId)
        {
            var query = await (from itemPart in _db.MsItemCardDefaulPartitions
                               where itemPart.ItemCardId == itemCardId
                               select new
                               {
                                   itemStorePrtId = itemPart.ItemStorePrtId,
                                   storePartId = itemPart.StorePartId,
                                   storeCode = _db.MsStores.FirstOrDefault(m => m.StoreId == itemPart.StoreId).StoreCode,
                                   storeDescA = _db.MsStores.FirstOrDefault(m=>m.StoreId == itemPart.StoreId).StoreDescA,
                                   partCode = _db.MsPartitions.FirstOrDefault(p => p.StorePartId == itemPart.StorePartId).PartCode,
                                   partDescA = _db.MsPartitions.FirstOrDefault(p=>p.StorePartId == itemPart.StorePartId).PartDescA,
                               }).ToListAsync();

            return Ok(query);
        }

        [HttpDelete("DeleteItemDefaultPartition")]
        public async Task<IActionResult> DeleteItemDefaultPartition(int itemStorePrtId)
        {
            try
            {
                MsItemCardDefaulPartition getDefaultPartition = await _db.MsItemCardDefaulPartitions.FindAsync(itemStorePrtId);

                if (getDefaultPartition == null)
                {
                    return NotFound();
                }
                else
                {
                    _db.MsItemCardDefaulPartitions.Remove(getDefaultPartition);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم المسح بنجاح",
                        messageEn = "item default Partition has been deleted successfully",
                    };

                    return Ok(response);

                }
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


        [HttpDelete("DeleteItemCollection")]
        public async Task<IActionResult> DeleteItemCollection(int itemCollectId)
        {
            try
            {
                MsItemCollection getItemCollection = await _db.MsItemCollections.FindAsync(itemCollectId);

                if (getItemCollection == null)
                {
                    return NotFound();
                }
                else
                {
                    _db.MsItemCollections.Remove(getItemCollection);

                    await _db.SaveChangesAsync();

                    var response = new
                    {
                        status = true,
                        message = "تم المسح بنجاح",
                        messageEn = "item collection has been deleted successfully",
                    };

                    return Ok(response);

                }
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

        [HttpGet("GetItemPartitionWithHisStore")]
        public async Task<IActionResult> GetItemPartitionWithHisStore()
        {
            var query = await (from partition in _db.MsPartitions join store in _db.MsStores
                               on partition.StoreId equals store.StoreId
                               select new
                               {
                                   storePartId = partition.StorePartId,
                                   partCode = partition.PartCode,
                                   partDescA = partition.PartDescA,
                                   partDescE = partition.PartDescE,
                                   storeId = store.StoreId,
                                   storeCode = store.StoreCode,
                                   storeDescA = store.StoreDescA,
                                   storeDescE = store.StoreDescA,
                                   
                               }).ToListAsync();

            return Ok(query);
        }

    }
}
