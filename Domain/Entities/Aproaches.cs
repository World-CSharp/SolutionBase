using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aproaches : EntityBase
    {        
       
        public int StateApproachesId { get; set; }
        public int TypeSolutionId { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public DateTime Date { get; set; }
        public int IdUser { get; set; }

        public List<DetailedApproaches> DetailedApproaches { get; set; }
        public StateApproaches StateApproaches { get; set; }
        public TypeSolution TypeSolution { get; set; }
    }
}
