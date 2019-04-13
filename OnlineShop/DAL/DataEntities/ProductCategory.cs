
using DAL.DataEntities.Abstract;

namespace DAL.DataEntities
{
    public class ProductCategory : BaseDataEntity
    {
        public virtual CategoryDescription Description { get; set; }
        public string Caption { get; set; }
    }
}
