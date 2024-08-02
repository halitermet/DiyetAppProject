using _01DiyetProjesi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime Created { get; set; }
        DateTime? Modifided { get; set; }
        DateTime? Deleted { get; set; }
        DataStatus DataStatus { get; set; }
    }
}
