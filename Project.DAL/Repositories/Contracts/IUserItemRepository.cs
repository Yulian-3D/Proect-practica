﻿using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Contracts
{
    public interface IUserItemRepository : IGenericRepository<UserItem>
    {
        Task<IEnumerable<UserItem>> GetItemsByUserId(int userId);
    }
}
