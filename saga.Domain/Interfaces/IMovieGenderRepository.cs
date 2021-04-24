using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IMovieGenderRepository : IRepository<MovieGender>, IDisposable
    {
    }
}
