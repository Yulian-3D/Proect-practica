using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;
using Project.DAL.Persistence;
using Project.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories
{
    public class ItemTradeRepository : GenericRepository<ItemTrade>, IItemTradeRepository
    {
        private readonly AppDbContext _context;
        public ItemTradeRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<ItemTrade> GetItemTradeForConfirmTradeById(int itemTradeId)
        {
            return await _context.ItemTrades
                .Where(x => x.Id == itemTradeId)
                .Include(x => x.UserItem).ThenInclude(x => x.Item)
                .Include(x => x.SellerUser)
                .Include(x => x.BuyerUser)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ItemTrade>> GetItemTradesByUserId(int userId)
        {

            var result = await _context.ItemTrades
                .Where(x => x.BuyerUserId == userId || x.SellerUserId == userId)
                .Include(x => x.UserItem).ThenInclude(x => x.Item)
                .ToListAsync();
            return result;
        }
    }
}
