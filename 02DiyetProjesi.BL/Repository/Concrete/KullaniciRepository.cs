using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Repository.Concrete
{
    public class KullaniciRepository
    {
        private EfDbContext _efDbContext;
        public KullaniciRepository()
        {
            _efDbContext = new EfDbContext();
        }
        public void Add(Kullanici kullanici)
        {
            _efDbContext.Kullanicilar.Add(kullanici);
            _efDbContext.SaveChanges();
        }
        public void Update(Kullanici kullanici)
        {
            _efDbContext.Kullanicilar.Update(kullanici);
            _efDbContext.SaveChanges();
        }
        public void Delete(Kullanici kullanici)
        {
            _efDbContext.Kullanicilar.Remove(kullanici);
            _efDbContext.SaveChanges();
        }
        public Kullanici? GetUserById(int id)
        {
            return _efDbContext.Kullanicilar.Find(id);
        }
        public Kullanici GetUser(Func<Kullanici,bool> predicate)
        {
            return _efDbContext.Kullanicilar.Where(predicate).FirstOrDefault() ?? new Kullanici();
        }
        public List<Kullanici> GetUsers()
        {
            return _efDbContext.Kullanicilar.ToList();
        }

    }
}
