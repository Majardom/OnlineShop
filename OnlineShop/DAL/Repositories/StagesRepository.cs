using DAL.DataEntities;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;

namespace DAL.Repositories
{
    public class StagesRepository : GenericRepository<Stage>, IStagesRepository
    {
        public StagesRepository(IShopDbContext context)
            :base(context)
        { }
    }
}
