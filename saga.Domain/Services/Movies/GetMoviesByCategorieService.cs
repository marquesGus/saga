using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Services.Movies
{
    public class GetMoviesByCategorieService
    {
        private readonly ISagaUnitOfWork _unit;

        public GetMoviesByCategorieService(ISagaUnitOfWork unit)
        {
            _unit = unit;
        }

        public List<Movie> Run(int id)
        {
            var movies = _unit.MovieGender.Find(x => x.GenderId == id).ToList();
            return FilterMovies(movies);
        }        

        private List<Movie> FilterMovies(List<MovieGender> model)
        {
            List<Movie> movies = new List<Movie>();

            foreach(var gender in movies)
            {
                if (movies.Where(x => x.MovieId == gender.MovieId).SingleOrDefault() == null) movies.Add(_unit.Movie.Get(gender.MovieId));
            }

            return movies;
        }
    }
}
