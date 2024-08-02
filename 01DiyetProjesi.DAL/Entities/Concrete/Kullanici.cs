using _01DiyetProjesi.DAL.Entities.Abstract;
using _01DiyetProjesi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Concrete
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        // @ kısıtlaması ve 6 harf kısıtlamları eklenecek.
        public string Email { get; set; }
        public string Sifre { get; set; }
        public bool IsAdmin { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public byte Yas { get; set; }
        public float Kilo { get; set; }
        public virtual ICollection<DiyetTablosu> DiyetTablolari {get; set;}
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

    }
}
