using Resort.Persistence.Repository_and_Unit_of_Work_Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Resort.Persistence.Repository_and_Unit_of_Work_Implimentation
{
    public class Repository<TEnitity> : IRepository<TEnitity> where TEnitity : class
    {
        protected readonly DbContext Context;
        protected readonly DbSet<TEnitity> DbSet;

        //Database Context

        public Repository(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEnitity>();
        }

        //Get Method

        public TEnitity SelectById(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEnitity> SelectAll()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEnitity> Find(Expression<Func<TEnitity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        //Insert Method

        public void Insert(TEnitity entity)
        {
            DbSet.Add(entity);
        }

        public void InsertRange(IEnumerable<TEnitity> entities)
        {
            DbSet.AddRange(entities);
        }

        //Delete Method

        public void Delete(TEnitity entity)
        {
            DbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEnitity> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}
