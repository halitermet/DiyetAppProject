using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Repository.Concrete
{
    public class YiyecekRepository : GenericRepository<Yiyecek>
    {
        private DbContext _dbContext;
        public YiyecekRepository()
        {}
        #region MyRegion
        //private EfDbContext _efDbContext;
        //public YiyecekRepository()
        //{
        //    _efDbContext = new EfDbContext();
        //}
        //public void Add(Kullanici kullanici)
        //{
        //    _efDbContext.Kullanicilar.Add(kullanici);
        //    _efDbContext.SaveChanges();
        //}
        //public void Update(Kullanici kullanici)
        //{
        //    _efDbContext.Kullanicilar.Update(kullanici);
        //    _efDbContext.SaveChanges();
        //}
        //public void Delete(Kullanici kullanici)
        //{
        //    _efDbContext.Kullanicilar.Remove(kullanici);
        //    _efDbContext.SaveChanges();
        //}
        //public Kullanici? GetUserById(int id)
        //{
        //    return _efDbContext.Kullanicilar.Find(id);
        //}
        //public Kullanici GetUser(Expression<Func<Kullanici, bool>> predicate)
        //{
        //    return _efDbContext.Kullanicilar.Where(predicate).FirstOrDefault() ?? new Kullanici();
        //}
        //public List<Kullanici> GetUsers()
        //{
        //    return _efDbContext.Kullanicilar.ToList();
        //} 
        #endregion
        public YiyecekRepository(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
