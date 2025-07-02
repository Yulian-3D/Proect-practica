using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.ItemTradeDTOs
{
    public class CreateItemTradeDTO
    {
        [Required]
        public int BuyerUserId { get; set; }
        [Required]
        public int UserItemId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public int Price { get; set; }
    }
}
