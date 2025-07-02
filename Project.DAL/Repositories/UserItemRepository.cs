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
        public UserItemRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
