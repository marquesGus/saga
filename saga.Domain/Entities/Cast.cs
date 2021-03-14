using saga.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
    public class Cast
    {
        public int CastId { get; set; }
        public virtual Movie Movie { get; set; }
        public int MovieId { get; set; }
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
        public bool Star { get; set; }
        public ProfessionEnum Profession { get; set; }
    }
}
