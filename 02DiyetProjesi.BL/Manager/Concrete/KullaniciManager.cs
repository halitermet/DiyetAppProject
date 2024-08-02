using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Concrete;
using _02DiyetProjesi.BL.Manager.Abstract;
using _02DiyetProjesi.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Concrete
{
    public class KullaniciManager : GenericManager<Kullanici,KullaniciRepository,EfDbContext,KullaniciViewModel>
    {  
        #region MyRegion
        //private KullaniciRepository _kullaniciRepository;
        //public KullaniciManager()
        //{
        //    _kullaniciRepository = new KullaniciRepository(new EfDbContext());
        //}
        //public void Add(KullaniciViewModel kullaniciViewModel)
        //{
        //    Kullanici kullanici = new Kullanici()
        //    {
        //        Ad = kullaniciViewModel.Ad,
        //        Soyad = kullaniciViewModel.Soyad,
        //        Email = kullaniciViewModel.Email,
        //        Yas = kullaniciViewModel.Yas,
        //        Cinsiyet = kullaniciViewModel.Cinsiyet,
        //        Kilo = kullaniciViewModel.Kilo,
        //        IsAdmin = kullaniciViewModel.Email.Contains("@yonetici") ? true : false,

        //    };

        //    _kullaniciRepository.Add(kullanici);
        //}
        //public void Update(KullaniciViewModel kullaniciViewModel)
        //{
        //    Kullanici kullanici = new Kullanici()
        //    {
        //        Id = kullaniciViewModel.Id,
        //        Ad = kullaniciViewModel.Ad,
        //        Soyad = kullaniciViewModel.Soyad,
        //        Email = kullaniciViewModel.Email,
        //        Yas = kullaniciViewModel.Yas,
        //        Cinsiyet = kullaniciViewModel.Cinsiyet,
        //        Kilo = kullaniciViewModel.Kilo,
        //        IsAdmin = kullaniciViewModel.Email.Contains("@yonetici") ? true : false,

        //    };

        //    _kullaniciRepository.Update(kullanici);

        //}
        //public void Delete(KullaniciViewModel kullaniciViewModel)
        //{
        //    Kullanici kullanici = new Kullanici()
        //    {
        //        Id = kullaniciViewModel.Id,
        //        Ad = kullaniciViewModel.Ad,
        //        Soyad = kullaniciViewModel.Soyad,
        //        Email = kullaniciViewModel.Email,
        //        Yas = kullaniciViewModel.Yas,
        //        Cinsiyet = kullaniciViewModel.Cinsiyet,
        //        Kilo = kullaniciViewModel.Kilo,
        //        IsAdmin = kullaniciViewModel.Email.Contains("@yonetici") ? true : false,

        //    };

        //    _kullaniciRepository.Delete(kullanici);

        //}
        //public KullaniciViewModel? GetUserById(int id)
        //{
        //    Kullanici kullanici = _kullaniciRepository.GetById(id);

        //    KullaniciViewModel kullaniciViewModel = new KullaniciViewModel()
        //    {
        //        Id = kullanici.Id,
        //        Ad = kullanici.Ad,
        //        Soyad = kullanici.Soyad,
        //        Email = kullanici.Email,
        //        Yas = kullanici.Yas,
        //        Kilo = kullanici.Kilo,
        //        Cinsiyet = kullanici.Cinsiyet
        //    };
        //    return kullaniciViewModel;

        //}
        ////public KullaniciViewModel GetUser(Func<Kullanici, bool> predicate)
        ////{

        ////}
        ////public List<KullaniciViewModel> GetUsers()
        ////{

        ////} 
        #endregion
    }
}
