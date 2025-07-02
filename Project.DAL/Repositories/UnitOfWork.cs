using Project.DAL.Persistence;
using Project.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IItemRepository itemRepository;
        private IItemTradeRepository itemTradeRepository;
        private IUserItemRepository userItemRepository;

        public IItemRepository ItemRepository
        {
            get
            {
                if (itemRepository is null)
                {
                    itemRepository = new ItemRepository(_dbContext);
                }
                return itemRepository;
            }
        }

        public IItemTradeRepository ItemTradeRepository
        {
            get
            {
                if (itemTradeRepository is null)
                {
                    itemTradeRepository = new ItemTradeRepository(_dbContext);
                }
                return itemTradeRepository;
            }
        }

        public IUserItemRepository UserItemRepository
        {
            get
            {
                if (userItemRepository is null)
                {
                    userItemRepository = new UserItemRepository(_dbContext);
                }
                return userItemRepository;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
