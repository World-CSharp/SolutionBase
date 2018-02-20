using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TypeSolution : EntityBase
    {
       
        public string Description { get; set; }

        public List<Aproaches> Aproaches { get; set; }

    }
}
