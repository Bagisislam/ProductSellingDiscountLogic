using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using EntityLayer.Abstract;

namespace Core.Concrete
{
    public class EntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> Filter = null)
        {
            using (var context = new TContext())
            {
                return Filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(Filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> Filter)
        {
            using (var context = new TContext())
            {
                return Filter != null ? context.Set<TEntity>().SingleOrDefault(Filter) : null;
            }
        }

        public void Add(TEntity productId)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(productId);
                entry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity productId)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(productId);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity isDeleted)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(isDeleted);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
