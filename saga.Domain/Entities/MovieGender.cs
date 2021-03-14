using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
    public class MovieGender
    {
        public int MovieGenderId { get; set; }
        public virtual Movie Movie { get; set; }
        public int MovieId { get; set; }
        public virtual Gender Gender { get; set; }
        public int GenderId { get; set; }
    }
}
