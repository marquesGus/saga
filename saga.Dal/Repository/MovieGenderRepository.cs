using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Dal.Repository
{
    public class MovieGenderRepository : Repository<MovieGender>, IMovieGenderRepository
    {
        IUnitOfWork unitOfWork = new SagaContext();

        public MovieGenderRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }


}
