using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
    public class Wishlist
    {
        public int WishlistId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
