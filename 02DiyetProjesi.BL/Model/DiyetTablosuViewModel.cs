using _01DiyetProjesi.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Model
{
    public class DiyetTablosuViewModel
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int YiyecekId { get; set; }
        public Yiyecek? Yiyecek { get; set; }
        public int OgunId { get; set; }
        public Ogun? Ogun { get; set; }
        public int PorsiyonId { get; set; }
        public Porsiyon? Porsiyon { get; set; }
        public int Birim { get; set; }
        public DateTime YenilenGun { get; set; }
    }
}
