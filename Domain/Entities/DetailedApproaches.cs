using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetailedApproaches:EntityBase
    {
       

        public int UserId { get; set; }
        public string Comment { get; set; }
        public int PositivePoint { get; set; }
        public int NegativePoint { get; set; }

        public Aproaches Aproaches { get; set; }
        public StateDetailApproaches StateDetailApproaches  { get; set; }
    }
}
