using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Dal.Repository
{
    public class MovieRatingRepository : Repository<MovieRating>, IMovieRatingRepository
    {
        IUnitOfWork unitOfWork = new SagaContext();

        public MovieRatingRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }


}
