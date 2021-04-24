using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>, IDisposable
    {
    }
}
