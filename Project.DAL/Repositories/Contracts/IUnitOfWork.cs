using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Contracts
{
    public interface IUnitOfWork
    {
        IItemRepository ItemRepository { get; }
        IItemTradeRepository ItemTradeRepository { get; }
        IUserItemRepository UserItemRepository { get; }
        public Task<int> SaveChangesAsync();
    }
}
