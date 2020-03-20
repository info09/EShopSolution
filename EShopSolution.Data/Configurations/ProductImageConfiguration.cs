using EShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImage");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(i => i.Caption).HasMaxLength(200).IsRequired(false);

            builder.HasOne(i => i.Product).WithMany(i => i.ProductImages).HasForeignKey(i => i.ProductId);
        }
    }
}
