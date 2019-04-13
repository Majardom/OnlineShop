using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;
using DAL.Interfaces.UnitOfWork;
using DAL.Repositories;
using DAL.ShopDbContext;
using DAL.UnitOfWork;
using Ninject.Modules;
using Ninject.Web.Common;

namespace BLL.DependencyConfiguration
{
    /// <summary>
    /// Ninject module for dependencies settings.
    /// </summary>
    public class DalModule : NinjectModule
    {
        /// <summary>
        /// Connection string to data base.
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Creates instance of ninject module.
        /// </summary>
        /// <param name="connectionString"></param>
        public DalModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Method to set bindings for DAL classes.
        /// </summary>
        public override void Load()
        {
            Bind<IShopDbContext>().To<ShopDbContext>().InRequestScope().WithConstructorArgument(_connectionString);
            Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();

            Bind<IProductsRepository>().To<ProductsRepository>().InRequestScope();
            Bind<IOrdersRepository>().To<OrdersRepository>().InRequestScope();
            Bind<IProductsCategoriesRepository>().To<ProductCategoriesRepository>().InRequestScope();
            Bind<IStagesRepository>().To<StagesRepository>().InRequestScope();
            Bind<ICategoryDescriptionsRepository>().To<CategoryDescriptionsRepository>().InRequestScope();
        }
    }
}
