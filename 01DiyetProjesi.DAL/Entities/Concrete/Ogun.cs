using _01DiyetProjesi.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Concrete
{
    public class Ogun : BaseEntity
    {
        public string Ad { get; set; }
        public virtual ICollection<DiyetTablosu> DiyetTablolari { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
