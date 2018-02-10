using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class ServiceType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Order Order { get; set; }
    }
}
