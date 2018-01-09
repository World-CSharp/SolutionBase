using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Organization
    {       
        public string Description { get; set; }
        public string Slogan { get; set; }
        public byte[] Logo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }        

    }
}
