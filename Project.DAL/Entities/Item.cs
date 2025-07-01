using Project.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PhotoLink { get; set; }
        public RarityEnum Rarity { get; set; }
        public string Description { get; set; }
        public List<UserItem> UserItems { get; set; } = new List<UserItem>();
        public List<ItemTrade> ItemTrades { get; set; } = new List<ItemTrade>();
    }
}
