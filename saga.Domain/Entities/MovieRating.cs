using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Entities
{
    public class MovieRating
    {
        public int MovieRatingId { get; set; }
        public virtual Movie Movie { get; set; }
        public int MovieId { get; set; }
        public float Score { get; set; }
        public int Votes { get; set; }

        public float SubmitVote(int rate)
        {
            Votes += 1;
            float newRate = Score + rate;


            return newRate / Votes;
        }
    }
}
