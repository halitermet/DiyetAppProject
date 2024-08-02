using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Repository.Abstract
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;
        public GenericRepository()
        {}

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            entity.DataStatus = Enums.DataStatus.Inserted;
            entity.Created = DateTime.Now;
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            entity.DataStatus = entity.DataStatus != Enums.DataStatus.Deleted 
                            ? Enums.DataStatus.Updated : Enums.DataStatus.Deleted;
            entity.Modifided = DateTime.Now;
             
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.DataStatus = Enums.DataStatus.Deleted;
            entity.Deleted = DateTime.Now;
            this.Update(entity);
        }

        public ICollection<T> GetAll()
        {
           return _dbSet.AsNoTracking().ToList();
        }

        //public ICollection<T> GetAllWithInclude(params Expression<Func<T, object>>[] navigation)
        //{
        //    ICollection<T> query = _dbContext.Set<T>();
        //    foreach (var navigationProperty in navigation) { query = query.Include(navigationProperty); }
        //    return query;
        //    return _dbSet.Include(navigation).AsNoTracking().ToList();
        //}

        public T GetById(int id)
        {
            return _dbSet.AsNoTracking().Single(t => t.Id == id);
        }

        public ICollection<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        
    }
}
