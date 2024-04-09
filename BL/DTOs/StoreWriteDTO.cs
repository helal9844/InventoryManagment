using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StoreWriteDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =8)]
        public string StoreName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string StoreLocation { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string ContactInformation { get; set; }
    }
}
