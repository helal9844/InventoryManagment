using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StoreItemWriteDTO
    {
        [Required]
        public int StoreId { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public IEnumerable<StoreReadDTO>? Stores { get; set; }
        public IEnumerable<ItemReadDTO>? Items { get; set; }
    }
}
