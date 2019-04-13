using System.Data.Entity.ModelConfiguration;
using DAL.DataEntities;

namespace DAL.EntitiesConfiguration
{
    internal class StageConfiguration :EntityTypeConfiguration<Stage>
    {
        internal StageConfiguration()
        {
            HasKey<int>(stage => stage.Id);
            Property(stage => stage.Caption).HasMaxLength(50).IsRequired();
        }
    }
}
