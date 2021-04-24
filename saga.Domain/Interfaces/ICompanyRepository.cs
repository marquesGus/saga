using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface ICompanyRepository : IRepository<Company>, IDisposable
    {
    }
}
