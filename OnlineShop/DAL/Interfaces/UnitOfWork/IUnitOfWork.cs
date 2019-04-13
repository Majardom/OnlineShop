using System;
using DAL.Interfaces.Repository;

namespace DAL.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IOrdersRepository Orders { get; }
        IProductsCategoriesRepository Categories { get; }
        IProductsRepository Products { get; }
        IStagesRepository Stages { get; }
        ICategoryDescriptionsRepository CategoryDescriptions { get; }
        void Save();
    }
}
