using saga.Domain.Entities;
using System;

namespace saga.Domain.Interfaces
{
    public interface IWishlistRepository : IRepository<Wishlist>, IDisposable
    {
    }
}
