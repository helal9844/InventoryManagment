
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreRepo : GenericRepo<Store>, IStoreRepo
    {
        public StoreRepo(AppDbContext context) : base(context)
        {
        }
    }
}
