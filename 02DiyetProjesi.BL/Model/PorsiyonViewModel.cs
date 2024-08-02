using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Model
{
    public class PorsiyonViewModel
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public override string ToString()
        {
            return Tur;
        }
    }
}
