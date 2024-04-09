
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreItemRepo:GenericRepo<StoreItem>,IStoreItemRepo
    {
        public StoreItemRepo(AppDbContext dbContext):base(dbContext)
        {

        }
    }
}
