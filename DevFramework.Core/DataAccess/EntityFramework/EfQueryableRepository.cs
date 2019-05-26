using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T: class, IEntity, new()
    {
        private DbContext _dbContext;
        IDbSet<T> _entities;
        public EfQueryableRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = dbContext.Set<T>();
        }

        public IQueryable<T> Table => this.Entites;
        protected virtual IDbSet<T> Entites
        {
            get => _entities ?? (_entities = _dbContext.Set<T>());
        }
    }
}
