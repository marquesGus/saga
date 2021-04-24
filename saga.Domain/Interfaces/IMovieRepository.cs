using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>, IDisposable
    {
    }
}
