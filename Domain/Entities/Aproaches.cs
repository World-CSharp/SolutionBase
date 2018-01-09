using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aproaches : EntityBase
    {        
        public int IdStateApproaches { get; set; }
        public int IdTypeSolution { get; set; }
        public int IdUser { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public DateTime Date { get; set; }
    }
}
