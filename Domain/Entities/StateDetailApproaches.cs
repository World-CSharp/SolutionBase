using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StateDetailApproaches:EntityBase
    {
        public StateDetailApproaches()
        {

        }

        public string Description { get; set; }        
        public List<DetailedApproaches> DetailedApproaches { get; set; }
    }
}
