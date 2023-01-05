using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
      public string ProductName { get; set; }
      public int Stock { get; set; }
      public int Price { get; set; }

      public Company Company { get; set; }
      public int CompanyId { get; set; }
        
    }
}