using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order : BaseEntity
    {
        public string OrderOwnerName { get; set; }
        public DateTime OrderDate { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Product Product { get; set; }
        public int ProudctId { get; set; }
    }
}