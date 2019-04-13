using System;
using DAL.Interfaces.DbContext;
using DAL.Interfaces.Repository;
using DAL.Interfaces.UnitOfWork;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IShopDbContext _context;

        public IOrdersRepository Orders { get; private set; }

        public IProductsCategoriesRepository Categories { get; private set; }

        public IProductsRepository Products { get; private set; }

        public IStagesRepository Stages { get; private set; }

        public ICategoryDescriptionsRepository CategoryDescriptions { get; private set; }

        public UnitOfWork(
            IShopDbContext context,
            IOrdersRepository orders,
            IProductsCategoriesRepository categories,
            IProductsRepository products,
            IStagesRepository stages,
            ICategoryDescriptionsRepository categoryDescriptions
            )
        {
            _context = context;
            Orders = orders;
            Categories = categories;
            Products = products;
            Stages = stages;
            CategoryDescriptions = categoryDescriptions;
            _isDisposed = false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _isDisposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool isDisposing)
        {
            if (_isDisposed)
                return;

            if (isDisposing)
            {
                Orders = null;
                Categories = null;
                Products = null;
                Stages = null;
                CategoryDescriptions = null;
            }

            _context.Dispose();
            _context = null;
            _isDisposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
