using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Entities.Concrete;

namespace DevFramework.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
            :this("dbo")
        {

        }

        public ProductMap(string schema)
        {
            ToTable(@"Products", schema);
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40);
            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("int").IsOptional();
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("int").IsOptional();
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsOptional().HasPrecision(19, 4);
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").HasColumnType("smallint").IsOptional();
            Property(x => x.UnitsOnOrder).HasColumnName(@"UnitsOnOrder").HasColumnType("smallint").IsOptional();
            Property(x => x.ReorderLevel).HasColumnName(@"ReorderLevel").HasColumnType("smallint").IsOptional();
            Property(x => x.Discontinued).HasColumnName(@"Discontinued").HasColumnType("bit").IsRequired();

            // Foreign keys
            //HasOptional(a => a.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_Products_Categories
            //HasOptional(a => a.Supplier).WithMany(b => b.Products).HasForeignKey(c => c.SupplierId).WillCascadeOnDelete(false); // FK_Products_Suppliers
        }
    }
}
