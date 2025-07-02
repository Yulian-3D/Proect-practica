using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DTOs.ItemTradeDTOs
{
    public class ConfirmItemTradeDTO
    {
        public int Id { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
