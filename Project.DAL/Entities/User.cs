using Microsoft.AspNetCore.Identity;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTWithCookiesAndRefreshTokens.Data.Entities
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public List<UserItem> UserItems { get; set; } = new List<UserItem>();
        public List<ItemTrade> ItemTrades { get; set; } = new List<ItemTrade>();
    }
}
