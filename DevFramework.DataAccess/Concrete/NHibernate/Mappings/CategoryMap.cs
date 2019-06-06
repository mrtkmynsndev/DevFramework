using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DevFramework.Entities.Concrete;

namespace DevFramework.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.Id).Column("CategoryID").GeneratedBy.Identity();

            Map(x => x.CategoryName).Column("CategoryName");
            Map(x => x.Description).Column("Description");
            Map(x => x.Picture).Column("Picture");

        }
    }
}
