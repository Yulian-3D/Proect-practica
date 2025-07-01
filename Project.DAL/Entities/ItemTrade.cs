using JWTWithCookiesAndRefreshTokens.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class ItemTrade
    {
        public int Id { get; set; }
        public int BuyerUserId { get; set; }
        public int SellerUserId { get; set; }
        public int ItemId { get; set; }
        public int Price { get; set; }
        public DateTime TradeDate { get; set; }
        public User BuyerUser { get; set; }
        public User SellerUser { get; set; }
        public Item Item { get; set; }
    }
}
