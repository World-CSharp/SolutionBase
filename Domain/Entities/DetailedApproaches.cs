using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetailedApproaches
    {
        public int IdUser { get; set; }
        public int IdAproaches{ get; set; }
        public int IdStateDetailApproaches { get; set; }
        public string Comment { get; set; }
        public int PositivePoint { get; set; }
        public int NegativePoint { get; set; }
    }
}
