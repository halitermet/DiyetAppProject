using _01DiyetProjesi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modifided { get; set; }
        public DateTime? Deleted { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
