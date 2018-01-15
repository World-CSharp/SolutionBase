using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {

        }

        public int Id { get; set; }
        public char Status { get; set; }
        public string Registered_By { get; set; }
        public DateTime Registered_On { get; set; }
        public string Modified_By { get; set; }
        public DateTime Modified_On { get; set; }
    }
}
