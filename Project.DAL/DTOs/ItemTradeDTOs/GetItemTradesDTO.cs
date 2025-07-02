using Project.DAL.DTOs.ItemDTOs;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.ItemTradeDTOs
{
    public class GetItemTradesDTO
    {
        public int Id { get; set; }
        public int BuyerUserId { get; set; }
        public int SellerUserId { get; set; }
        public int UserItemId { get; set; }
        public int Price { get; set; }
        public DateTime TradeCreateDate { get; set; }
        public DateTime? TradeConfirmationDate { get; set; }
        public bool IsConfirmed { get; set; }
        public GetItemDTO ItemDTO { get; set; }
    }
}
