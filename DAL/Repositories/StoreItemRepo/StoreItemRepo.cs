
using Microsoft.EntityFrameworkCore;
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

        public List<StoreItem> GetAllInclue()
        {
            return _context.Set<StoreItem>().Where(e=>e.IsDeleted==false)
                .Include(si => si.Store)
                .Include(si => si.Item)
                .ToList();
        }
    }
}
