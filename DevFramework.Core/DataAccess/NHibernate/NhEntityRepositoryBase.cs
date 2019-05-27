using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
    {
        NHibernateProvider _nHibernateProvider;
        public NhEntityRepositoryBase(NHibernateProvider nHibernateProvider)
        {
            _nHibernateProvider = nHibernateProvider;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _nHibernateProvider.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nHibernateProvider.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nHibernateProvider.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session = _nHibernateProvider.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateProvider.OpenSession())
            {
                return filter == null ? session.Query<TEntity>().ToList() : session.Query<TEntity>().Where(filter).ToList();
            }
        }
    }
}
