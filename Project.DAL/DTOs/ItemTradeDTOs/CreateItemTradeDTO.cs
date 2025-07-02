using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.ItemTradeDTOs
{
    public class CreateItemTradeDTO
    {
        public int BuyerUserId { get; set; }
        public int UserItemId { get; set; }
        public int Price { get; set; }
    }
}
