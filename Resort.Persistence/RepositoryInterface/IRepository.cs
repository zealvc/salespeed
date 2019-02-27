using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Resort.Persistence.Repository_and_Unit_of_Work_Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Get Method

        TEntity SelectById(int id);
        IEnumerable<TEntity> SelectAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Insert Method

        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);

        //Delete Method

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
