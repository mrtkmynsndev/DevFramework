using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;

namespace DevFramework.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap() : this("dbo")
        {

        }

        public CategoryMap(string schema)
        {
            ToTable(@"Categories", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"CategoryID").HasColumnType("int").IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CategoryName).HasColumnName("CategoryName").HasColumnType("nvarchar").IsRequired();
            Property(x => x.Description).HasColumnName("Description").HasColumnType("ntext").IsOptional();
            Property(x => x.Picture).HasColumnName("Picture").HasColumnType("image").IsOptional();
        }
    }
}
