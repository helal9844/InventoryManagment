
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
                if (property.Name == "IsDeleted")
                    property.SetValue(entity, false);
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
            IQueryable<T> query = _context.Set<T>();
            foreach (PropertyInfo property in PropertyInfos)
            {
                
                if (property.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(property.Name).GetValue(x).Equals(false)).AsQueryable();
                }
            }
           return query.ToList();
        }

        public void Update(T entity)
        {
            foreach (PropertyInfo property in PropertyInfos)
            {
                if (property.Name == "UpdatedDate")
                    property.SetValue(entity, DateTime.Now);
                if (property.Name == "IsDeleted")
                    property.SetValue(entity, false);
            }
            _context.Set<T>().Update(entity);
        }
        public T Find(Expression<Func<T, bool>> expression)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (PropertyInfo property in PropertyInfos)
            {

                if (property.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(property.Name).GetValue(x).Equals(false)).AsQueryable();
                }
            }
            return query.SingleOrDefault(expression);
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (PropertyInfo property in PropertyInfos)
            {

                if (property.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(property.Name).GetValue(x).Equals(false)).AsQueryable();
                }
            }
            return await query.AnyAsync(expression);
        }

        public async Task<List<T>> GetAllAsunc()
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (PropertyInfo property in PropertyInfos)
            {

                if (property.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(property.Name).GetValue(x).Equals(false)).AsQueryable();
                }
            }
            return await query.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (PropertyInfo property in PropertyInfos)
            {

                if (property.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(property.Name).GetValue(x).Equals(false)).AsQueryable();
                }
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> SingleOrDefualtAsync(Expression<Func<T, bool>> expression)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (PropertyInfo property in PropertyInfos)
            {

                if (property.Name == "IsDeleted")
                {
                    query = query.ToList().Where(x => x.GetType().GetProperty(property.Name).GetValue(x).Equals(false)).AsQueryable();
                }
            }
            return await query.SingleOrDefaultAsync(expression);
        }
    }
}
