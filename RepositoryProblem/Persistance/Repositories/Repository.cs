using RepositoryProblem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Persistance.Repositories
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity :class
    {
        protected readonly ApplicationDbContext Context;

        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity Get(int? id)
        {
            return Context.Set<TEntity>().Find(id);
        }


        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Edit(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

       
    }
}