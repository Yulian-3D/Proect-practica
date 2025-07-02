using Project.DAL.Entities;
using Project.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.UserItemDTOs
{
    public class GetUserItemsDTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PhotoLink { get; set; }
        public RarityEnum Rarity { get; set; }
        public string Description { get; set; }
    }
}
