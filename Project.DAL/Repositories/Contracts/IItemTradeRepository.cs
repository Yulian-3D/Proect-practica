using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Contracts
{
    public interface IItemTradeRepository : IGenericRepository<ItemTrade>
    {
        Task<IEnumerable<ItemTrade>> GetItemTradesByUserId(int userId);
        Task<ItemTrade> GetItemTradeForConfirmTradeById(int itemTradeId);
    }
}
