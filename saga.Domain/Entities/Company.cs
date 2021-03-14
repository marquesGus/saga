using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get;set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
