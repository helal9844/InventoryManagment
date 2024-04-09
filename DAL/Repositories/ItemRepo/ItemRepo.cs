
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemRepo : GenericRepo<Item>, IItemRepo
    {
        public ItemRepo(AppDbContext context) : base(context)
        {
        }
    }
}
