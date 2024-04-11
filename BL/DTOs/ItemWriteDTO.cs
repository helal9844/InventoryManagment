using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ItemWriteDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string ItemName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Description { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Catagory { get; set; }
    }
}
