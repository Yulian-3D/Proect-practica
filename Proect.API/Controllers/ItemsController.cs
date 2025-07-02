using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
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

            return Ok(await _unitOfWork.UserItemRepository.GetItemsByUserId(int.Parse(userId!)));
        }
    }
}
