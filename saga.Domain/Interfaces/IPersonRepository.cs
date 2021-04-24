using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IPersonRepository : IRepository<Person>, IDisposable
    {
    }
}
