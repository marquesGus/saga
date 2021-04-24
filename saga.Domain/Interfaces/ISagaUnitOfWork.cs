using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Domain.Interfaces
{
    public partial interface ISagaUnitOfWork : IUnitOfWork
    {
        ICastRepository Cast { get; }
        ICompanyRepository Company { get; }
        IGenderRepository Gender { get; }
        IMovieGenderRepository MovieGender { get; }
        IMovieRatingRepository MovieRating { get; }
        IMovieRepository MovieRepository { get; }
        IPersonRepository Person { get; }
        IUserRepository User { get; }
        IWishlistRepository Wishlist { get; }
    }
}
