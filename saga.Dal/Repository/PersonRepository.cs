using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Dal.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        SagaContext unitOfWork = new SagaContext();

        public PersonRepository(SagaContext unitOfWork)
            : base(unitOfWork)
        {

        }
    }


}
