using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DiyetProjesi.DAL.Repository.Concrete
{
    public class OgunRepository : GenericRepository<Ogun>
    {
        private DbContext _dbContext;
        public OgunRepository()
        { }
        public OgunRepository(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
