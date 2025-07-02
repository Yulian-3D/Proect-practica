using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Project.DAL.DTOs.UserItemDTOs;
using Project.DAL.Repositories.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace Proect.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetItemsByUserId()
        {
            var userId = User.FindFirst("userId")?.Value;

            var resultFromDB = await _unitOfWork.UserItemRepository.GetItemsByUserId(int.Parse(userId!));

            var result = new List<GetUserItemsDTO>();

            foreach (var item in resultFromDB)
            {
                result.Add(new GetUserItemsDTO
                {
                    Id = item.Id,
                    ItemId = item.Item.Id,
                    Name = item.Item.Name,
                    Price = item.Item.Price,
                    PhotoLink = item.Item.PhotoLink,
                    Rarity = item.Item.Rarity,
                    Description = item.Item.Description
                });
            }
            return Ok(result);
        }
    }
}
