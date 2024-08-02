using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Concrete;
using _02DiyetProjesi.BL.Manager.Abstract;
using _02DiyetProjesi.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Concrete
{
    public class DiyetTablosuManager : GenericManager<DiyetTablosu, DiyetTablosuRepository, EfDbContext, DiyetTablosuViewModel>
    {

    }
}
