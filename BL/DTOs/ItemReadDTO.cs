using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ItemReadDTO
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
