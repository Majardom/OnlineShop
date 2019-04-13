using DAL.DataEntities;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;

namespace DAL.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        public ProductsRepository(IShopDbContext context)
            : base(context)
        { }
    }
}
