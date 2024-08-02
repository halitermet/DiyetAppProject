using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Abstract
{
    public interface IGenericManager<TModel,TEntity>
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        void Remove(TModel model);
        TModel GetById(int id);
        ICollection<TModel> GetAll();
        ICollection<TModel> Search(Expression<Func<TEntity, bool>> predicate);

        //ICollection<TModel> GetAllWithInclude(Expression<Func<TEntity, object>> navigation);
    }
}
