using DAL.DataEntities;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;

namespace DAL.Repositories
{
    public class CategoryDescriptionsRepository : GenericRepository<CategoryDescription>, ICategoryDescriptionsRepository
    {
        public CategoryDescriptionsRepository(IShopDbContext context)
            : base(context)
        { }
    }
}
