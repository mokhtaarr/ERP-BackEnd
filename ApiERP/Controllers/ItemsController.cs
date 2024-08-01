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


       
        [HttpDelete("DeleteItemCard")]
        public async Task<IActionResult> DeleteItemCard(int itemCardId)
        {
            var trans = await _db.Database.BeginTransactionAsync();

            try
            {
                var results = await _db.ItemUsages.FromSqlRaw($"IsUsedItem {itemCardId}").ToListAsync();

                bool isAllNull = results.All(item =>
                        item.DeliverId == null &&
                        item.ItemPricintId == null &&
                        item.ItemSerialId == null &&
                        item.StockAdjustItemId == null &&
                        item.StartQtyId == null &&
                        item.PayId == null &&
                        item.PettycashId == null &&
                        item.SpecialItemCardId == null &&
                        item.PurInvId == null &&
                        item.PurOrderId == null &&
                        item.RetPurchId == null &&
                        item.ReqsalesId == null &&
                        item.RetSaleId == null &&
                        item.InvId == null &&
                        item.ItemOfferId == null &&
                        item.SalesOfferId == null &&
                        item.SalesOfferReqId == null &&
                        item.SalesOrderId == null &&
                        item.StockRecId == null &&
                        item.TranId == null &&
                        item.TranReqId == null &&
                        item.PrinQoutId == null &&
                        item.BillItemsId == null &&
                        item.ProdItemAtrribId == null &&
                        item.ItemAtrribBatchId == null &&
                        item.Material == null &&
                        item.ProductJobOrderId == null &&
                        item.ScrapJobOrderId == null &&
                        item.GoStockJobOrderId == null &&
                        item.ProdItemsWorkOrderId == null &&
                        item.MaterialWorkOrderId == null &&
                        item.ScrapWorkOrderId == null &&
                        item.ProjectEstimateItemId == null &&
                        item.ItemPartId == null &&
                        item.ProjectRealItemId == null &&
                        item.TenderContractId == null &&
                        item.ContractorContractContractId == null &&
                        item.ContractorExitractId == null &&
                        item.TenderItemId == null &&
                        item.ExecutExitractId == null &&
                        item.TenderOfferId == null &&
                        item.OwnerExitractId == null &&
                        item.TenderPlanId == null &&
                        item.TenderQoutationId == null &&
                        item.TenderId == null &&
                        item.ItemDeliverId == null &&
                        item.ItemRecQualityId == null &&
                        item.ProdItemRecId == null &&
                        item.JobOrderItemsRepairId == null &&
                        item.ScrapItemsRepairId == null &&
                        item.TaskId == null &&
                        item.VehclItemPart == null
                       );

                if (!isAllNull)
                {
                    foreach (var item in results)
                    {
                        if (item.DeliverId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( DeliverId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (DeliverId)"
                            });
                        if (item.ItemPricintId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemPricintId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemPricintId)"
                            });
                        if (item.ItemSerialId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemSerialId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemSerialId)"
                            });
                        if (item.StockAdjustItemId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( StockAdjustItemId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (StockAdjustItemId)"
                            });
                        if (item.StartQtyId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( StartQtyId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (StartQtyId)"
                            });
                        if (item.PayId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( PayId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (PayId)"
                            });
                        if (item.PettycashId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( PettycashId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (PettycashId)"
                            });
                        if (item.SpecialItemCardId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( SpecialItemCardId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (SpecialItemCardId)"
                            });
                        if (item.PurInvId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( PurInvId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (PurInvId)"
                            });
                        if (item.PurOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( PurOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (PurOrderId)"
                            });
                        if (item.RetPurchId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( RetPurchId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (RetPurchId)"
                            });
                        if (item.ReqsalesId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ReqsalesId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ReqsalesId)"
                            });
                        if (item.RetSaleId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( RetSaleId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (RetSaleId)"
                            });
                        if (item.InvId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( InvId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (InvId)"
                            });
                        if (item.ItemOfferId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemOfferId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemOfferId)"
                            });
                        if (item.SalesOfferId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( SalesOfferId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (SalesOfferId)"
                            });
                        if (item.SalesOfferReqId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( SalesOfferReqId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (SalesOfferReqId)"
                            });
                        if (item.SalesOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( SalesOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (SalesOrderId)"
                            });
                        if (item.StockRecId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( StockRecId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (StockRecId)"
                            });
                        if (item.TranId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TranId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TranId)"
                            });
                        if (item.TranReqId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TranReqId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TranReqId)"
                            });
                        if (item.PrinQoutId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( PrinQoutId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (PrinQoutId)"
                            });
                        if (item.BillItemsId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( BillItemsId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (BillItemsId)"
                            });
                        if (item.ProdItemAtrribId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ProdItemAtrribId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ProdItemAtrribId)"
                            });
                        if (item.ItemAtrribBatchId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemAtrribBatchId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemAtrribBatchId)"
                            });
                        if (item.Material != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( Material ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (Material)"
                            });
                        if (item.ProductJobOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ProductJobOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ProductJobOrderId)"
                            });
                        if (item.ScrapJobOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ScrapJobOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ScrapJobOrderId)"
                            });
                        if (item.GoStockJobOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( GoStockJobOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (GoStockJobOrderId)"
                            });
                        if (item.ProdItemsWorkOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ProdItemsWorkOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ProdItemsWorkOrderId)"
                            });
                        if (item.MaterialWorkOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( MaterialWorkOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (MaterialWorkOrderId)"
                            });
                        if (item.ScrapWorkOrderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ScrapWorkOrderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ScrapWorkOrderId)"
                            });
                        if (item.ProjectEstimateItemId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ProjectEstimateItemId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ProjectEstimateItemId)"
                            });
                        if (item.ItemPartId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemPartId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemPartId)"
                            });
                        if (item.ProjectRealItemId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ProjectRealItemId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ProjectRealItemId)"
                            });
                        if (item.TenderContractId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TenderContractId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TenderContractId)"
                            });
                        if (item.ContractorContractContractId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ContractorContractContractId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ContractorContractContractId)"
                            });
                        if (item.ContractorExitractId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ContractorExitractId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ContractorExitractId)"
                            });
                        if (item.TenderItemId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TenderItemId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TenderItemId)"
                            });
                        if (item.ExecutExitractId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ExecutExitractId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ExecutExitractId)"
                            });
                        if (item.TenderOfferId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TenderOfferId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TenderOfferId)"
                            });
                        if (item.OwnerExitractId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( OwnerExitractId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (OwnerExitractId)"
                            });
                        if (item.TenderPlanId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TenderPlanId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TenderPlanId)"
                            });
                        if (item.TenderQoutationId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TenderQoutationId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TenderQoutationId)"
                            });
                        if (item.TenderId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TenderId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TenderId)"
                            });
                        if (item.ItemDeliverId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemDeliverId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemDeliverId)"
                            });
                        if (item.ItemRecQualityId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ItemRecQualityId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ItemRecQualityId)"
                            });
                        if (item.ProdItemRecId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ProdItemRecId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ProdItemRecId)"
                            });
                        if (item.JobOrderItemsRepairId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( JobOrderItemsRepairId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (JobOrderItemsRepairId)"
                            });
                        if (item.ScrapItemsRepairId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( ScrapItemsRepairId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (ScrapItemsRepairId)"
                            });
                        if (item.TaskId != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( TaskId ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (TaskId)"
                            });
                        if (item.VehclItemPart != null)
                            return Ok(new
                            {
                                status = false,
                                message = "( VehclItemPart ) لا يمكن مسح هذا المنتج لانه مرتبط بهذا الفيلد",
                                messageEn = "This product cannot be deleted because it is related to this field (VehclItemPart)"
                            });
                    }
                }

            

                MsItemImage getItemImage = await _db.MsItemImages.FirstOrDefaultAsync(m=> m.ItemCardId == itemCardId);
                if (getItemImage is not null)
                {
                    _db.MsItemImages.Remove(getItemImage);
                    await _db.SaveChangesAsync();
                }

                List<MsItemUnit> getItemUnits = await _db.MsItemUnits.Where(u=>u.ItemCardId == itemCardId).ToListAsync();
                if (getItemUnits.Any())
                {
                    _db.MsItemUnits.RemoveRange(getItemUnits);
                    await _db.SaveChangesAsync();
                }

                List<MsItemCollection> getItemCollections = await _db.MsItemCollections.Where(c => c.ItemCardId == itemCardId).ToListAsync();
                if (getItemCollections.Any())
                {
                    _db.MsItemCollections.RemoveRange(getItemCollections);
                    await  _db.SaveChangesAsync();

                }

                List<MsItemAlternative> getItemAlternatives = await _db.MsItemAlternatives.Where(a => a.ItemCardId == itemCardId).ToListAsync();
                if (getItemAlternatives.Any())
                {
                    _db.MsItemAlternatives.RemoveRange(getItemAlternatives);
                    await _db.SaveChangesAsync();
                }

                List<MsItemCardDefaulPartition> getItemDefaultPartition = await _db.MsItemCardDefaulPartitions.Where(i=>i.ItemCardId == itemCardId).ToListAsync();
                if (getItemDefaultPartition.Any())
                {
                    _db.MsItemCardDefaulPartitions.RemoveRange(getItemDefaultPartition);
                    await _db.SaveChangesAsync();
                }

                MsItemCard getItem = await _db.MsItemCards.FindAsync(itemCardId);
                if (getItem is not null)
                {
                    _db.MsItemCards.Remove(getItem);
                    await _db.SaveChangesAsync();
                }


                await trans.CommitAsync();

                var response = new
                {
                    status = true,
                    message = "تم المسح بنجاح",
                    messageEn = "item has been deleted successfully",
                };

                return Ok(response);

            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();

                var Bad_response = new
                {
                    status = false,
                    message = $" {ex.Message} حدث خطا",
                    messageEn = $"something went wrong {ex.Message}",
                };

                return Ok(Bad_response);
            }
         
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

                    bool anyDefaultPurchas = dto.list.Any(item => item.IsDefaultSale != null && (bool)item.IsDefaultPurchas);

                    if (!anyDefaultPurchas)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = "يرجي تحديد وحده شراء أساسية",
                            messageEn = "Please select purchase unit",

                        };

                        return Ok(Bad_response);
                    };

                    bool anyDefaultSale = dto.list.Any(item => item.IsDefaultSale != null && (bool)item.IsDefaultSale);


                    if (!anyDefaultSale)
                    {
                        var Bad_response = new
                        {
                            status = false,
                            message = "يرجي تحديد وحده بيع أساسية",
                            messageEn = "Please select sales unit",

                        };

                        return Ok(Bad_response);
                    };


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

                    if(getRecord.BasUnitId != dto.BasUnitId)
                    {
                        var results = await _db.ItemUsages.FromSqlRaw($"IsUsedItem {getRecord.ItemCardId}").ToListAsync();

                        bool isAllNull = results.All(item =>
                                item.DeliverId == null &&
                                item.ItemPricintId == null &&
                                item.ItemSerialId == null &&
                                item.StockAdjustItemId == null &&
                                item.StartQtyId == null &&
                                item.PayId == null &&
                                item.PettycashId == null &&
                                item.SpecialItemCardId == null &&
                                item.PurInvId == null &&
                                item.PurOrderId == null &&
                                item.RetPurchId == null &&
                                item.ReqsalesId == null &&
                                item.RetSaleId == null &&
                                item.InvId == null &&
                                item.ItemOfferId == null &&
                                item.SalesOfferId == null &&
                                item.SalesOfferReqId == null &&
                                item.SalesOrderId == null &&
                                item.StockRecId == null &&
                                item.TranId == null &&
                                item.TranReqId == null &&
                                item.PrinQoutId == null &&
                                item.BillItemsId == null &&
                                item.ProdItemAtrribId == null &&
                                item.ItemAtrribBatchId == null &&
                                item.Material == null &&
                                item.ProductJobOrderId == null &&
                                item.ScrapJobOrderId == null &&
                                item.GoStockJobOrderId == null &&
                                item.ProdItemsWorkOrderId == null &&
                                item.MaterialWorkOrderId == null &&
                                item.ScrapWorkOrderId == null &&
                                item.ProjectEstimateItemId == null &&
                                item.ItemPartId == null &&
                                item.ProjectRealItemId == null &&
                                item.TenderContractId == null &&
                                item.ContractorContractContractId == null &&
                                item.ContractorExitractId == null &&
                                item.TenderItemId == null &&
                                item.ExecutExitractId == null &&
                                item.TenderOfferId == null &&
                                item.OwnerExitractId == null &&
                                item.TenderPlanId == null &&
                                item.TenderQoutationId == null &&
                                item.TenderId == null &&
                                item.ItemDeliverId == null &&
                                item.ItemRecQualityId == null &&
                                item.ProdItemRecId == null &&
                                item.JobOrderItemsRepairId == null &&
                                item.ScrapItemsRepairId == null &&
                                item.TaskId == null &&
                                item.VehclItemPart == null
                               );

                        if (!isAllNull)
                        {
                            foreach (var item in results)
                            {
                                if (item.DeliverId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( DeliverId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (DeliverId)"
                                    });
                                if (item.ItemPricintId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemPricintId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemPricintId)"
                                    });
                                if (item.ItemSerialId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemSerialId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemSerialId)"
                                    });
                                if (item.StockAdjustItemId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( StockAdjustItemId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (StockAdjustItemId)"
                                    });
                                if (item.StartQtyId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( StartQtyId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (StartQtyId)"
                                    });
                                if (item.PayId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( PayId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (PayId)"
                                    });
                                if (item.PettycashId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( PettycashId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (PettycashId)"
                                    });
                                if (item.SpecialItemCardId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( SpecialItemCardId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (SpecialItemCardId)"
                                    });
                                if (item.PurInvId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( PurInvId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (PurInvId)"
                                    });
                                if (item.PurOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( PurOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (PurOrderId)"
                                    });
                                if (item.RetPurchId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( RetPurchId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (RetPurchId)"
                                    });
                                if (item.ReqsalesId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ReqsalesId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ReqsalesId)"
                                    });
                                if (item.RetSaleId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( RetSaleId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (RetSaleId)"
                                    });
                                if (item.InvId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( InvId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (InvId)"
                                    });
                                if (item.ItemOfferId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemOfferId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemOfferId)"
                                    });
                                if (item.SalesOfferId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( SalesOfferId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (SalesOfferId)"
                                    });
                                if (item.SalesOfferReqId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( SalesOfferReqId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (SalesOfferReqId)"
                                    });
                                if (item.SalesOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( SalesOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (SalesOrderId)"
                                    });
                                if (item.StockRecId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( StockRecId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (StockRecId)"
                                    });
                                if (item.TranId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TranId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TranId)"
                                    });
                                if (item.TranReqId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TranReqId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TranReqId)"
                                    });
                                if (item.PrinQoutId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( PrinQoutId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (PrinQoutId)"
                                    });
                                if (item.BillItemsId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( BillItemsId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (BillItemsId)"
                                    });
                                if (item.ProdItemAtrribId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ProdItemAtrribId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ProdItemAtrribId)"
                                    });
                                if (item.ItemAtrribBatchId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemAtrribBatchId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemAtrribBatchId)"
                                    });
                                if (item.Material != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( Material ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (Material)"
                                    });
                                if (item.ProductJobOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ProductJobOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ProductJobOrderId)"
                                    });
                                if (item.ScrapJobOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ScrapJobOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ScrapJobOrderId)"
                                    });
                                if (item.GoStockJobOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( GoStockJobOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (GoStockJobOrderId)"
                                    });
                                if (item.ProdItemsWorkOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ProdItemsWorkOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ProdItemsWorkOrderId)"
                                    });
                                if (item.MaterialWorkOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( MaterialWorkOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (MaterialWorkOrderId)"
                                    });
                                if (item.ScrapWorkOrderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ScrapWorkOrderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ScrapWorkOrderId)"
                                    });
                                if (item.ProjectEstimateItemId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ProjectEstimateItemId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ProjectEstimateItemId)"
                                    });
                                if (item.ItemPartId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemPartId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemPartId)"
                                    });
                                if (item.ProjectRealItemId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ProjectRealItemId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ProjectRealItemId)"
                                    });
                                if (item.TenderContractId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TenderContractId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TenderContractId)"
                                    });
                                if (item.ContractorContractContractId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ContractorContractContractId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ContractorContractContractId)"
                                    });
                                if (item.ContractorExitractId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ContractorExitractId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ContractorExitractId)"
                                    });
                                if (item.TenderItemId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TenderItemId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TenderItemId)"
                                    });
                                if (item.ExecutExitractId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ExecutExitractId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ExecutExitractId)"
                                    });
                                if (item.TenderOfferId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TenderOfferId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TenderOfferId)"
                                    });
                                if (item.OwnerExitractId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( OwnerExitractId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (OwnerExitractId)"
                                    });
                                if (item.TenderPlanId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TenderPlanId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TenderPlanId)"
                                    });
                                if (item.TenderQoutationId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TenderQoutationId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TenderQoutationId)"
                                    });
                                if (item.TenderId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TenderId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TenderId)"
                                    });
                                if (item.ItemDeliverId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemDeliverId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemDeliverId)"
                                    });
                                if (item.ItemRecQualityId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ItemRecQualityId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ItemRecQualityId)"
                                    });
                                if (item.ProdItemRecId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ProdItemRecId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ProdItemRecId)"
                                    });
                                if (item.JobOrderItemsRepairId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( JobOrderItemsRepairId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (JobOrderItemsRepairId)"
                                    });
                                if (item.ScrapItemsRepairId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( ScrapItemsRepairId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (ScrapItemsRepairId)"
                                    });
                                if (item.TaskId != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( TaskId ) لا يمكن تغيير وحده هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (TaskId)"
                                    });
                                if (item.VehclItemPart != null)
                                    return Ok(new
                                    {
                                        status = false,
                                        message = "( VehclItemPart ) لا يمكن متغيير وحده  هذا المنتج لانه مرتبط بهذا الفيلد",
                                        messageEn = "This product cannot be deleted because it is related to this field (VehclItemPart)"
                                    });
                            }
                        }
                        else
                        {
                            bool anyDefaultPurchasUnit = dto.list.Any(item => item.IsDefaultSale != null && (bool)item.IsDefaultPurchas);

                            if (!anyDefaultPurchasUnit)
                            {
                                var Bad_response = new
                                {
                                    status = false,
                                    message = "يرجي تحديد وحده شراء أساسية",
                                    messageEn = "Please select purchase unit",

                                };

                                return Ok(Bad_response);
                            };

                            bool anyDefaultSaleUnit = dto.list.Any(item => item.IsDefaultSale != null && (bool)item.IsDefaultSale);


                            if (!anyDefaultSaleUnit)
                            {
                                var Bad_response = new
                                {
                                    status = false,
                                    message = "يرجي تحديد وحده بيع أساسية",
                                    messageEn = "Please select sales unit",

                                };

                                return Ok(Bad_response);
                            };


                            List<MsItemUnit> getItemUnits = await _db.MsItemUnits.Where(u => u.ItemCardId == getRecord.ItemCardId).ToListAsync();
                            if(getItemUnits.Any())
                            {
                                _db.MsItemUnits.RemoveRange(getItemUnits);
                                await _db.SaveChangesAsync();
                            }

                            getRecord.BasUnitId = dto.BasUnitId;
                            await _db.SaveChangesAsync();

                            if (dto.list != null)
                            {
                                foreach (var itemUnit in dto.list)
                                {
                                    MsItemUnit NewItemUnit = new MsItemUnit
                                    {
                                        UnitCode = itemUnit.UnitCode,
                                        UnitNam = itemUnit.UnitNam,
                                        UnitNameE = itemUnit?.UnitNameE,
                                        ItemCardId = getRecord.ItemCardId,
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

                        }
                    }

                 

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
