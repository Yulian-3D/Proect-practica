﻿using Microsoft.EntityFrameworkCore;
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
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
