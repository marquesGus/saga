using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime? DiedDate { get; set; }
        public string Biography { get; set; }
    }
}
