using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductId).ValueGeneratedOnAdd();

            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ProductName).HasMaxLength(50);
            builder.Property(p => p.QuantityPerUnit).IsRequired();
            builder.Property(p => p.UnitPrice).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            //builder.HasOne<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);

            builder.Property(p => p.ProductId).HasColumnName("ProductId");
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(p => p.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            builder.Property(p => p.ProductName).HasColumnName("ProductName");

            builder.ToTable("Products");
        }
    }
}
