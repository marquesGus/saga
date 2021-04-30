using saga.Dal.Repository;
using saga.Domain.Entities;
using saga.Domain.Interfaces;

namespace saga.Dal
{
    public class SagaUnitOfWork : ISagaUnitOfWork
    {
        private SagaContext _context;
        private ICastRepository _cast;
        private ICompanyRepository _company;
        private IGenderRepository _gender;
        private IMovieGenderRepository _movieGender;
        private IMovieRatingRepository _movieRating;
        private IMovieRepository _movie;
        private IPersonRepository _person;
        private IUserRepository _user;
        private IWishlistRepository _wishlist;

        public SagaUnitOfWork(SagaContext context)
        {
            _context = context;
        }

        public ICastRepository Cast
        {
            get {
                return _cast ?? (_cast = new CastRepository(_context));
            }
        }

        public ICompanyRepository Company
        {
            get
            {
                return _company ?? (_company = new CompanyRepository(_context));
            }
        }

        public IGenderRepository Gender
        {
            get
            {
                return _gender ?? (_gender = new GenderRepository(_context));
            }
        }

        public IMovieGenderRepository MovieGender
        {
            get
            {
                return _movieGender ?? (_movieGender = new MovieGenderRepository(_context));
            }
        }

        public IMovieRatingRepository MovieRating
        {
            get
            {
                return _movieRating ?? (_movieRating = new MovieRatingRepository(_context));
            }
        }

        public IMovieRepository Movie
        {
            get
            {
                return _movie ?? (_movie = new MovieRepository(_context));
            }
        }

        public IPersonRepository Person
        {
            get
            {
                return _person ?? (_person = new PersonRepository(_context));
            }
        }

        public IUserRepository User
        {
            get
            {
                return _user ?? (_user = new UserRepository(_context));
            }
        }

        public IWishlistRepository Wishlist
        {
            get
            {
                return _wishlist ?? (_wishlist = new WishlistRepository(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
