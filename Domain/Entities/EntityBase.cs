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
        public string Registered_By { get; set; }
        public DateTime Registered_In { get; set; }
        public string Modified_By { get; set; }
        public DateTime Modified_In { get; set; }
    }
}
