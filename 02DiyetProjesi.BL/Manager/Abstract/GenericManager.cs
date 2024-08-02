using _01DiyetProjesi.DAL.Entities.Abstract;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _01DiyetProjesi.DAL.Repository.Abstract;
using _01DiyetProjesi.DAL.Repository.Concrete;
using _02DiyetProjesi.BL.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02DiyetProjesi.BL.Manager.Abstract
{
    public class GenericManager<TEntity, TRepo,TDbContext,TModel> : IGenericManager<TModel,TEntity> 
        where TEntity : BaseEntity, new()
        where TModel : class, new()
        where TDbContext : DbContext, new()
        where TRepo : GenericRepository<TEntity>, new()
    {
        private TRepo _repo;
        private TDbContext _dbContext;
        private IMapper _mapper;
        public GenericManager()
        {
            _dbContext = new TDbContext();
            _repo = (TRepo)Activator.CreateInstance(typeof(TRepo),_dbContext);
            //_repo = new TRepo();

            var config = new MapperConfiguration(cfg =>
            {
                //cfg.AllowNullCollections = true;
                cfg.CreateMap<TModel,TEntity>().ReverseMap();
                //cfg.CreateMap<ICollection<TModel>,ICollection<TEntity>>().ReverseMap();
            });
            _mapper = new Mapper(config);
        }
        public void Add(TModel model)
        {

            TEntity entity = _mapper.Map<TEntity>(model);
            _repo.Add(entity);
        }
        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repo.Update(entity);
        }
        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repo.Remove(entity);
        }
        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repo.Delete(entity);
        }
        public ICollection<TModel> GetAll()
        {
            ICollection<TEntity> entities = _repo.GetAll();
            //EKLENEN SATIR//
            entities = entities.Where(e => e.Deleted == null).ToList();

            ICollection<TModel> models = new List<TModel>();

            foreach (TEntity entity in entities)
            {
                models.Add(_mapper.Map<TModel>(entity));
            }

            //ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities);
            return models;
        }

        //public ICollection<TModel> GetAllWithInclude(params Expression<Func<TEntity, object>>[] navigation)
        //{
        //    IQueryable<TEntity> entities = _repo.GetAllWithInclude(navigation);
        //    entities = entities.Where(e => e.Deleted == null);

        //    ICollection<TModel> models = new List<TModel>();

        //    foreach (TEntity entity in entities)
        //    {
        //        TModel model = _mapper.Map<TModel>(entity);
        //        models.Add(model);
        //    }

        //    return models;
        //}

        public TModel GetById(int id)
        {
            TEntity entity = _repo.GetById(id);
            TModel model = _mapper.Map<TModel>(entity);
            return model;
        }
        public ICollection<TModel> Search(Expression<Func<TEntity, bool>> predicate)
        {
            ICollection<TEntity> entities = _repo.Search(predicate);
            //ICollection<TModel> models = _mapper.Map<ICollection<TModel>>(entities);
            ICollection<TModel> models = new List<TModel>();

            foreach (TEntity entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }

            return models;
        }

       
    }
}
