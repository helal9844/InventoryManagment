
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenericRepo<T>:IGenericRepo<T> where T : class
    {
        protected readonly AppDbContext _context;
        private PropertyInfo[] PropertyInfos;
        public GenericRepo(AppDbContext context)
        {
            _context = context;
            PropertyInfos = typeof(T).GetProperties();
        }
        public void Add(T entity)
        {
            foreach (PropertyInfo property in PropertyInfos)
            {
                if (property.Name == "CreatedDate")
                    property.SetValue(entity, DateTime.Now);    
            }
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            foreach(PropertyInfo property in PropertyInfos)
            {
                if (property.Name == "DeletedDate")
                    property.SetValue(entity, DateTime.Now);
                if (property.Name == "IsDeleted")
                    property.SetValue(entity, true);
            }
            _context.Set<T>().Update(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            foreach (PropertyInfo property in PropertyInfos)
            {
                if (property.Name == "UpdatedDate")
                    property.SetValue(entity, DateTime.Now);
            }
            _context.Set<T>().Update(entity);
        }
        public T Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().SingleOrDefault(expression);
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AnyAsync(expression);
        }

        public async Task<List<T>> GetAllAsunc()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> SingleOrDefualtAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(expression);
        }
    }
}
