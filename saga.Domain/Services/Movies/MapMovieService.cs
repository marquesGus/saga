using saga.Domain.DTO;
using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace saga.Domain.Services.Movies
{
    public class MapMovieService
    {
        private readonly ISagaUnitOfWork _unit;
        private MovieDTO movie;

        public MapMovieService(ISagaUnitOfWork unit)
        {
            _unit = unit;
        }

        public MovieDTO Run(int id)
        {
            movie = new MovieDTO();
            movie.Movie = _unit.Movie.Get(id);
            movie.Categories = GetCategories(id);
            movie.Rating = _unit.MovieRating.Find(x => x.MovieId == id).SingleOrDefault();

            return movie;
        }

        private List<Gender> GetCategories(int id)
        {
            var genders = new List<Gender>();
            var movieGenders = _unit.MovieGender.Find(x => x.MovieId == id).ToList();

            foreach (var gender in movieGenders) genders.Add(_unit.Gender.Get(gender.GenderId));

            return genders;
        }

    }
}
