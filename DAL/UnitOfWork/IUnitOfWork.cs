using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork:IDisposable
    {
        IItemRepo ItemRepo { get; }
        IStoreRepo StoreRepo { get; }   
        IStoreItemRepo StoreItemRepo { get; }   
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
