using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Dal.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        IUnitOfWork unitOfWork = new SagaContext();

        public MovieRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }


}
