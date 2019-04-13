using System;
using System.Collections.Generic;
using BLL.DTO;
using DAL.DataEntities;

namespace BLL.Interfaces.Services
{
    public interface IOrdersService : IDisposable
    {
        IEnumerable<OrderDto> GetAllOrders();
        IEnumerable<StageDto> GetAllOrderStages();
        StageDto GetStageById(int id);
    }
}
