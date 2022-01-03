using Market.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities.Concrete
{
    public class SiteIdentity:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public string Description { get; set; }
        public string AboutUs { get; set; }
        public string Logo { get; set; }
    }
}
