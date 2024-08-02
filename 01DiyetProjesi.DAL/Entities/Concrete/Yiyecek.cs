using _01DiyetProjesi.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Concrete
{
    public class Yiyecek : BaseEntity
    {
        public string Ad { get; set; }
        public float Kalori { get; set; }
        //Yiyeceklerin gorseli tutulacak.
        public byte[] Resim { get; set; }
        public virtual ICollection<DiyetTablosu> DiyetTablolari { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
