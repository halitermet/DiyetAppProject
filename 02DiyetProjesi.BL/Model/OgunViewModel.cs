using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Model
{
    public class OgunViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime? Deleted { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
