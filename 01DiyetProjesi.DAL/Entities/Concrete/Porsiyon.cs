using _01DiyetProjesi.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Concrete
{
    public class Porsiyon : BaseEntity
    {
        //Yemek kaşığı, tabak, bardak gibi düşünülmüştür.
        public string Tur { get; set; }
        public virtual ICollection<DiyetTablosu> DiyetTablolari { get; set; }
        public override string ToString()
        {
            return Tur;
        }
    }
}
