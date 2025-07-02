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
            {//////////////////////////////////////////////////////////////////////////УЛЬДУАР////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////Огненный Левиафан
                Id = 1,
                Name = "Боевой шлем в железных заклепках",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "голова"
            });
            Items.Add(new Item()
            {
                Id = 2,
                Name = "Восходящее солнце",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "метательное"
            });
            Items.Add(new Item()
            {
                Id = 3,
                Name = "Золотистый саронитовый коготь",
                Price = 150000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "правая рука"
            });
            Items.Add(new Item()
            {
                Id = 4,
                Name = "Катушка Левиафана",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кольцо"
            });
            Items.Add(new Item()
            {
                Id = 5,
                Name = "Колье-оберег Фрейи",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "шея"
            });
            Items.Add(new Item()
            {
                Id = 6,
                Name = "Мощь автоматизации",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кольцо"
            });
            Items.Add(new Item()
            {
                Id = 7,
                Name = "Наплечные пластины дремлющей энергии",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "плечо"
            });
            Items.Add(new Item()
            {
                Id = 8,
                Name = "Наручники механика",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "наручи"
            });
            Items.Add(new Item()
            {
                Id = 9,
                Name = "Облачение Левиафана",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "пояс"
            });
            Items.Add(new Item()
            {
                Id = 10,
                Name = "Очки парообразования",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "голова"
            });
            Items.Add(new Item()
            {
                Id = 11,
                Name = "Перчатки огненного чудища",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кисти рук"
            });
            Items.Add(new Item()
            {
                Id = 12,
                Name = "Пластинчатые поножи опустошения",
                Price = 150000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "ноги"
            });
            Items.Add(new Item()
            {
                Id = 13,
                Name = "Повязки конструктора",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кисти рук"
            });
            Items.Add(new Item()
            {
                Id = 14,
                Name = "Подвеска опустошительного пожара",
                Price = 150000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "шея"
            });
            Items.Add(new Item()
            {
                Id = 15,
                Name = "Раскаленные стяжки Мимирона",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "наручи"
            });
            Items.Add(new Item()
            {
                Id = 16,
                Name = "Руководство по заправке огненного левиафана",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "левая рука"
            });
            Items.Add(new Item()
            {
                Id = 17,
                Name = "Сапоги жаркой развязки",
                Price = 150000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "ступни"
            });
            Items.Add(new Item()
            {
                Id = 18,
                Name = "Сияющее кольцо регенерации  ",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кольцо"
            });
            Items.Add(new Item()
            {
                Id = 19,
                Name = "Титановый страж",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "одноручное"
            });
            Items.Add(new Item()
            {
                Id = 20,
                Name = "Иллюзия: Отведение удара",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Rare,
                Description = "чертеж"
            });
            Items.Add(new Item()
            {
                Id = 21,
                Name = "Иллюзия: Вытягивание крови",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Rare,
                Description = "чертеж"
            });
            Items.Add(new Item()
            {
                Id = 22,
                Name = "Потемневший осколок Вал'анира",
                Price = 175000,
                PhotoLink = "",
                Rarity = RarityEnum.Mythic,
                Description = "осколок"
            });
            Items.Add(new Item()
            {
                Id = 23,
                Name = "Формула иллюзии: Отведение удара",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Rare,
                Description = "формула"
            });
            Items.Add(new Item()
            {
                Id = 24,
                Name = "Формула иллюзии: Вытягивание крови",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Rare,
                Description = "формула"
            });
            Items.Add(new Item()
            {
                Id = 25,
                Name = "Печать Титанов",
                Price = 120000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "улучшение"
            });
            Items.Add(new Item()
            {
                Id = 26,
                Name = "Первоэлемент",
                Price = 25000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "материал"
            });
            ////////////////////////////////////////////////////////////////////Повелитель горнов Игнис
            Items.Add(new Item()
            {
                Id = 27,
                Name = "Железное сердце",
                Price = 150000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "аксессуар"
            });
            Items.Add(new Item()
            {
                Id = 28,
                Name = "Кираса из кузни жизни",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "грудь"
            });
            Items.Add(new Item()
            {
                Id = 29,
                Name = "Накулачники хранителя очага",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "наручи"
            });
            Items.Add(new Item()
            {
                Id = 30,
                Name = "Напряженность",
                Price = 100000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "посох"
            });
            Items.Add(new Item()
            {
                Id = 31,
                Name = "Обожженный кушак",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "пояс"
            });
            Items.Add(new Item()
            {
                Id = 32,
                Name = "Обугленные саронитовые наголенники",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "ступни"
            });
            Items.Add(new Item()
            {
                Id = 33,
                Name = "Огненный Круг",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кольцо"
            });
            Items.Add(new Item()
            {
                Id = 34,
                Name = "Покрытое сажей оплечье",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "плечо"
            });
            Items.Add(new Item()
            {
                Id = 35,
                Name = "Резец мироздателя",
                Price = 150000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "двуручний топор"
            });
            Items.Add(new Item()
            {
                Id = 36,
                Name = "Сапоги крадущегося пламени",
                Price = 100000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "ступни"
            });
            Items.Add(new Item()
            {
                Id = 37,
                Name = "Скипетр творения",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "жезл"
            });
            Items.Add(new Item()
            {
                Id = 38,
                Name = "Тлеющее кольцо",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "кольцо"
            });
            Items.Add(new Item()
            {
                Id = 39,
                Name = "Угольный латный ремень",
                Price = 100000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "пояс"
            });
            Items.Add(new Item()
            {
                Id = 40,
                Name = "Шлем хранителя горнов",
                Price = 75000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "голова"
            });
            Items.Add(new Item()
            {
                Id = 41,
                Name = "Потемневший осколок Вал'анира",
                Price = 175000,
                PhotoLink = "",
                Rarity = RarityEnum.Mythic,
                Description = "осколок"
            });
            Items.Add(new Item()
            {
                Id = 42,
                Name = "Первоэлемент",
                Price = 25000,
                PhotoLink = "",
                Rarity = RarityEnum.Epic,
                Description = "материал"
            });
            //////////////////////////////////////////////////////////Oстрокрылая
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
            UserItems.Add(new UserItem()
            {
                Id = 2,
                UserId = 2,
                ItemId = 2
            });
            UserItems.Add(new UserItem()
            {
                Id = 3,
                UserId = 1,
                ItemId = 3
            });
            UserItems.Add(new UserItem()
            {
                Id = 4,
                UserId = 2,
                ItemId = 4
            });
            UserItems.Add(new UserItem()
            {
                Id = 5,
                UserId = 1,
                ItemId = 5
            });
            UserItems.Add(new UserItem()
            {
                Id = 6,
                UserId = 1,
                ItemId = 6
            });
            UserItems.Add(new UserItem()
            {
                Id = 7,
                UserId = 2,
                ItemId = 7
            });
            UserItems.Add(new UserItem()
            {
                Id = 8,
                UserId = 2,
                ItemId = 7
            });
            UserItems.Add(new UserItem()
            {
                Id = 9,
                UserId = 1,
                ItemId = 8
            });
            UserItems.Add(new UserItem()
            {
                Id = 10,
                UserId = 2,
                ItemId = 8
            });
            UserItems.Add(new UserItem()
            {
                Id = 11,
                UserId = 2,
                ItemId = 9
            });
            UserItems.Add(new UserItem()
            {
                Id = 12,
                UserId = 2,
                ItemId = 10
            });
            UserItems.Add(new UserItem()
            {
                Id = 13,
                UserId = 1,
                ItemId = 11
            });
            UserItems.Add(new UserItem()
            {
                Id = 14,
                UserId = 1,
                ItemId = 30
            });
            UserItems.Add(new UserItem()
            {
                Id = 15,
                UserId = 2,
                ItemId = 31
            });
            UserItems.Add(new UserItem()
            {
                Id = 16,
                UserId = 2,
                ItemId = 31
            });


        }
    }
}
