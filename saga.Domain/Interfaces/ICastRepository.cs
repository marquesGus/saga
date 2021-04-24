using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface ICastRepository : IRepository<Cast>, IDisposable
    {
    }
}
