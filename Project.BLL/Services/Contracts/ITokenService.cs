using Project.DAL.Entities;
using System.Threading.Tasks;

namespace Project.BLL.Services.Contracts
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(User user);
    }
}
