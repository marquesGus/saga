using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IGenderRepository : IRepository<Gender>, IDisposable
    {
    }
}
