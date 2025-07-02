using Project.DAL.Entities.Enums;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.ItemDTOs
{
    public class GetItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PhotoLink { get; set; }
        public RarityEnum Rarity { get; set; }
        public string Description { get; set; }
    }
}
