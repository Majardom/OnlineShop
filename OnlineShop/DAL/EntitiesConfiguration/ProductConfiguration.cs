using System.Data.Entity.ModelConfiguration;
using DAL.DataEntities;

namespace DAL.EntitiesConfiguration
{
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        internal ProductConfiguration()
        {
            HasKey<int>(product => product.Id);
            Property(product => product.Caption).HasMaxLength(30).IsRequired();
            Property(product => product.ImgPath).IsRequired();
            HasRequired(product => product.Category);
        }
    }
}
