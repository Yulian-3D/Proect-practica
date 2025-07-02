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
    public class UserItemRepository : GenericRepository<UserItem>, IUserItemRepository
    {
        private readonly AppDbContext _context;
        public UserItemRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetItemsByUserId(int userId)
        {
            return await _context.UserItems
                .Where(i => i.UserId == userId).Select(x => x.Item)
                .ToListAsync();
        }
    }
}
