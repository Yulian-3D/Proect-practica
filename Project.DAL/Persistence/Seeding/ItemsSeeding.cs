using Project.DAL.Entities;
using Project.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Persistence.Seeding
{
    public static class ItemsSeeding
    {
        public static List<Item> Items { get; set; } = new List<Item>();
        public static List<ItemTrade> ItemTrades { get; set; } = new List<ItemTrade>();
        public static List<UserItem> UserItems { get; set; } = new List<UserItem>();

        public static void SeedingInit()
        {
            SeedItemEntities();
            SeedItemTradeEntities();
            SeedUserItemEntities();
        }

        private static void SeedItemEntities()
        {
            Items.Add(new Item()
            {
                Id = 1,
                Name = "Dagger of Darkness",
                Price = 51,
                PhotoLink = "https://images.unsplash.com/photo-1614890094520-7b8dd0ec56d2?fm=jpg&q=60&w=3000&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8YWZyaWNhbiUyMGFtZXJpY2FuJTIwbWFufGVufDB8fDB8fHww",
                Rarity = RarityEnum.Epic,
                Description = $"Mega super duper dagger."
            });
        }

        private static void SeedItemTradeEntities()
        {
            ItemTrades.Add(new ItemTrade()
            {
                Id = 1,
                BuyerUserId = 1,
                SellerUserId = 2,
                ItemId = 1,
                Price = 55,
                TradeCreateDate = DateTime.Now.AddDays(-1),
                IsConfirmed = false
            });
        }

        private static void SeedUserItemEntities()
        {
            UserItems.Add(new UserItem()
            {
                Id = 1,
                UserId = 1,
                ItemId = 1
            });
        }
    }
}
