using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntityBase
    {
       
        public int Id { get; set; }
        public char Status { get; set; }
        public string RegisteredBy { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
