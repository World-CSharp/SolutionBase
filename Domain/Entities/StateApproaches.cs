using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StateApproaches:EntityBase
    {
        public StateApproaches()
        {

        }

        public string Description { get; set; }

        public List<Aproaches> Aproaches { get; set; }
        
    }
}
