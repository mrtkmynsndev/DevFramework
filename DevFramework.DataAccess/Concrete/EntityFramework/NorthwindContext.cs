using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;
using DevFramework.DataAccess.Concrete.EntityFramework.Mappings;

namespace DevFramework.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("name=NorthwindContext")
        {
            //Do Nothing in DB
            Database.SetInitializer<NorthwindContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
