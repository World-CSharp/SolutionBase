using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public  class Label:EntityBase
    {        
        public string Description { get; set; }
        public string Comment { get; set; }

    }
}
