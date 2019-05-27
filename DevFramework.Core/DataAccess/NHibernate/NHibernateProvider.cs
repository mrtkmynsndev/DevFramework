using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public abstract class NHibernateProvider : IDisposable
    {
        static ISessionFactory _sessionFactory;
        
        public virtual ISessionFactory SessionFactory
        {
            get => _sessionFactory ?? (_sessionFactory = InitializeFactory());
        }

        /// <summary>
        /// Bu fonk zorunlu implemente edilmesini sağladık. Ör: MySql, SqlServer, Oracle return edilecek vs.. gibi
        /// </summary>
        /// <returns></returns>
        protected abstract ISessionFactory InitializeFactory();

        /// <summary>
        /// Entityframeworkte Context'e benzer bir yapı
        /// </summary>
        /// <returns></returns>
        public virtual ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
