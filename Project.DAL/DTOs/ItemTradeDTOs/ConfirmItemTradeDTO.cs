using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.ItemTradeDTOs
{
    public class ConfirmItemTradeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool IsConfirmed { get; set; }
    }
}
