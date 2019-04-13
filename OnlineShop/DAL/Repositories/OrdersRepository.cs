using DAL.DataEntities;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;

namespace DAL.Repositories
{
    public class OrdersRepository : GenericRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(IShopDbContext context)
            :base(context)
        {}
    }
}
