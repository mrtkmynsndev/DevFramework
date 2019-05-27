using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateProvider _nHibernateProvider;
        private IQueryable<T> _entites;

        public NhQueryableRepository(NHibernateProvider nHibernateProvider)
        {
            _nHibernateProvider = nHibernateProvider;
        }

        public IQueryable<T> Table => this.Entites;

        public IQueryable<T> Entites {
            get
            {
                if(_entites == null)
                {
                    _entites = _nHibernateProvider.OpenSession().Query<T>();
                }

                return _entites;
            }
        }
    }
}
