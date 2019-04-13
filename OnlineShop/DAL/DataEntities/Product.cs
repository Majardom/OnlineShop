using DAL.DataEntities.Abstract;

namespace DAL.DataEntities
{
    public class Product : BaseDataEntity
    {
        public string Caption { get; set; }
        public string ImgPath { get; set; }
        public virtual ProductCategory Category { get; set; }
    }
}
