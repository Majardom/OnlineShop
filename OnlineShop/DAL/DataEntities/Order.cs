using System;
using DAL.DataEntities.Abstract;

namespace DAL.DataEntities
{
    public class Order : BaseDataEntity
    {
        public DateTime DateOfCreation { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual Product Product { get; set; }
        public double ProductPrice { get; set; }
        public double Amount { get; set; }
    }
}
