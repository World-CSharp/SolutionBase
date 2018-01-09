using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project:EntityBase
    {
        public int IdOrganization { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
