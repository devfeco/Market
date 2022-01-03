using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class Product:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
        public string StockCode { get; set; }
        public Guid? CategoryId { get; set; }
        public Category Category { get; set; }
        public string SeoAuther { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
    }
}
