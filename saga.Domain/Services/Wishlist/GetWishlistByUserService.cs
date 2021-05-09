using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace saga.Domain.Services.Wishlists
{
    public class GetWishlistByUserService
    {
        private readonly ISagaUnitOfWork _unit;

        public GetWishlistByUserService(ISagaUnitOfWork unit)
        {
            _unit = unit;
        }

        public List<Movie> Run(int userId) 
        {
            var wishlist = _unit.Wishlist.Find(x => x.UserId == userId).ToList();

            return GetMovies(wishlist);
        }

        private List<Movie> GetMovies(List<Wishlist> model)
        {
            List<Movie> movies = new List<Movie>();

            foreach (var id in model) movies.Add(_unit.Movie.Get(id.MovieId));

            return movies;
        }
    }
}
