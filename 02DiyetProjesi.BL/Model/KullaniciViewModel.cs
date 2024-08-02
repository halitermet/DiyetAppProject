using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Model
{
    public class KullaniciViewModel
    {
        public int Id {  get; set; } // id kalkacak.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public bool IsAdmin { get; set; }
        public byte Yas { get; set; }
        public float Kilo { get; set; }
        public ICollection<DiyetTablosu> DiyetTablolari { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
