using saga.Domain.Entities;
using System.Collections.Generic;

namespace saga.Domain.DTO
{
    public class MovieDTO
    {
        public Movie Movie { get; set; }
        public List<Gender> Categories { get; set; }
        public MovieRating Rating { get; set; }
    }
}
