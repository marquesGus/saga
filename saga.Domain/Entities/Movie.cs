using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
   public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
        public string Synopsis { get; set; }
        public string Trailer { get; set; }
        public string Runtime { get; set; }
    }
}
