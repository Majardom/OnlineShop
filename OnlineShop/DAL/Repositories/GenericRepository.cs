using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.DataEntities.Abstract;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseDataEntity
    {
        protected DbSet<TEntity> Entities;
        protected IShopDbContext Context;

        public GenericRepository(IShopDbContext context)
        {
            Entities = context.Set<TEntity>();
            Context = context;
        }

        public TEntity GetById(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList();
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            var currentEntity = GetById(entity.Id);
            Context.Entry(currentEntity).CurrentValues.SetValues(entity);
            Context.Entry(currentEntity).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
