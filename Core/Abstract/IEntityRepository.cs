using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstract;

namespace Core.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : class , IEntity , new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>>Filter = null);
        TEntity Get(Expression<Func<TEntity,bool>>Filter);
        void Add(TEntity productId);
        void Update(TEntity productId);
        void Delete(TEntity isDeleted);

    }
}
