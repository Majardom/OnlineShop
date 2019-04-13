using DAL.DataEntities;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;

namespace DAL.Repositories
{
    public class ProductCategoriesRepository : GenericRepository<ProductCategory>, IProductsCategoriesRepository
    {
        public ProductCategoriesRepository(IShopDbContext context)
            : base(context)
        { }
    }
}
