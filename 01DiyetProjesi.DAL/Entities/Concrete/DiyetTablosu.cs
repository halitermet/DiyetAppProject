using _01DiyetProjesi.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Concrete
{
    public class DiyetTablosu : BaseEntity
    {
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public int YiyecekId { get; set; }
        public virtual Yiyecek Yiyecek { get; set; }
        public int OgunId { get; set; }
        public virtual Ogun Ogun { get; set; }
        public int PorsiyonId { get; set; }
        public virtual Porsiyon Porsiyon { get; set; }
        public int Birim { get; set; }
        public DateTime YenilenGun { get; set; }
    }
}
