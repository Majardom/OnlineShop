using System.Data.Entity.ModelConfiguration;
using DAL.DataEntities;

namespace DAL.EntitiesConfiguration
{
    internal class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        internal OrderConfiguration()
        {
            HasKey<int>(order => order.Id);
            Property(order => order.DateOfCreation).HasColumnType("datetime2").IsRequired();
            HasRequired(order => order.Product);
            HasRequired(order => order.Stage);
            Property(order => order.ProductPrice).IsRequired();
            Property(order => order.Amount).IsRequired();
        }
    }
}
