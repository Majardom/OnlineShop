using System.Data.Entity.ModelConfiguration;
using DAL.DataEntities;

namespace DAL.EntitiesConfiguration
{
    internal class CategoryDescriptionConfiguration : EntityTypeConfiguration<CategoryDescription>
    {
        internal CategoryDescriptionConfiguration()
        {
            HasKey<int>(description => description.Id);
            Property(description => description.Description).IsRequired();
        }
    }
}
