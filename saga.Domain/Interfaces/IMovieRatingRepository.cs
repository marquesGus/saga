using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IMovieRatingRepository : IRepository<MovieRating>, IDisposable
    {
    }
}
