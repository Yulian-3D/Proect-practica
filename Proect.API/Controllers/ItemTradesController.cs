using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Exceptions;
using Project.DAL.DTOs.ItemDTOs;
using Project.DAL.DTOs.ItemTradeDTOs;
using Project.DAL.Entities;
using Project.DAL.Repositories;
using Project.DAL.Repositories.Contracts;

namespace Proect.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ItemTradesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemTradesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetItemTradesByUserId()
        {
            var userId = User.FindFirst("userId")?.Value;

            var resultfromdb = await _unitOfWork.ItemTradeRepository.GetItemTradesByUserId(int.Parse(userId!));

            var result = new List<GetItemTradesDTO>();

            foreach (var itemTrade in resultfromdb)
            {
                result.Add(new GetItemTradesDTO
                {
                    Id = itemTrade.Id,
                    BuyerUserId = itemTrade.BuyerUserId,
                    SellerUserId = itemTrade.SellerUserId,
                    UserItemId = itemTrade.UserItemId,
                    Price = itemTrade.Price,
                    TradeCreateDate = itemTrade.TradeCreateDate,
                    TradeConfirmationDate = itemTrade.TradeConfirmationDate,
                    IsConfirmed = itemTrade.IsConfirmed,
                    ItemDTO = new GetItemDTO()
                    {
                        Id = itemTrade.UserItem.Item.Id,
                        Name = itemTrade.UserItem.Item.Name,
                        Price = itemTrade.UserItem.Item.Price,
                        PhotoLink = itemTrade.UserItem.Item.PhotoLink,
                        Rarity = itemTrade.UserItem.Item.Rarity,
                        Description = itemTrade.UserItem.Item.Description
                    }
                });
            }

            return Ok(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateItemTrade([FromBody] CreateItemTradeDTO createItemTradeDTO)
        {
            var userId = User.FindFirst("userId")?.Value;

            var entity = new ItemTrade()
            {
                BuyerUserId = createItemTradeDTO.BuyerUserId,
                SellerUserId = int.Parse(userId!),
                UserItemId = createItemTradeDTO.UserItemId,
                Price = createItemTradeDTO.Price,
                TradeCreateDate = DateTime.UtcNow,
                IsConfirmed = false
            };
            await _unitOfWork.ItemTradeRepository.CreateAsync(entity);

            var isSuccessResult = await _unitOfWork.SaveChangesAsync() > 0;

            if (!isSuccessResult)
            {
                throw new InternalServerErrorException();
            }

            return Ok(new { Result = true });
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> ConfirmItemTrade([FromBody] ConfirmItemTradeDTO confirmItemTradeDTO)
        {
            var userId = User.FindFirst("userId")?.Value;

            var entityFromDB = await _unitOfWork.ItemTradeRepository.GetItemTradeForConfirmTradeById(confirmItemTradeDTO.Id);

            if (entityFromDB is null)
            {
                throw new EntityNotFoundException();
            }

            if (entityFromDB.BuyerUserId != int.Parse(userId!))
            {
                throw new ForbiddenAccessException();
            };

            entityFromDB.TradeConfirmationDate = DateTime.UtcNow;
            entityFromDB.IsConfirmed = confirmItemTradeDTO.IsConfirmed;
            entityFromDB.UserItem.UserId = int.Parse(userId!);
            entityFromDB.BuyerUser.Count -= entityFromDB.Price;
            entityFromDB.SellerUser.Count += entityFromDB.Price;

            var isSuccessResult = await _unitOfWork.SaveChangesAsync() > 0;

            if (!isSuccessResult)
            {
                throw new InternalServerErrorException();
            }

            return Ok(new { Result = true });
        }

        [HttpDelete("{id:int}")]
        [Authorize]
        public async Task<IActionResult> DeleteItemTrade([FromRoute] int id)
        {
            var userId = User.FindFirst("userId")?.Value;

            var entityFromDB = await _unitOfWork.ItemTradeRepository.GetFirstOrDefaultAsync(id);

            if (entityFromDB is null)
            {
                throw new EntityNotFoundException();
            }

            if (entityFromDB.SellerUserId != int.Parse(userId!))
            {
                throw new ForbiddenAccessException();
            };

            if (entityFromDB.TradeConfirmationDate != null)
            {
                throw new BadRequestException();
            };

            _unitOfWork.ItemTradeRepository.Delete(entityFromDB);

            var isSuccessResult = await _unitOfWork.SaveChangesAsync() > 0;

            if (!isSuccessResult)
            {
                throw new InternalServerErrorException();
            }

            return Ok(new { result = true });
        }
    }
}
