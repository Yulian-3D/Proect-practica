using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public List<UserItem> UserItems { get; set; } = new List<UserItem>();
        public List<ItemTrade> BuyItemTrades { get; set; } = new List<ItemTrade>();
        public List<ItemTrade> SellItemTrades { get; set; } = new List<ItemTrade>();
    }
}
