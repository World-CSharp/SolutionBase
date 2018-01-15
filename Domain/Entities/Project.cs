using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project:EntityBase
    {
        public Project()
        {

        }

        //public int IdOrganization { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        
        public Organization Organization { get; set; }
    }
}
