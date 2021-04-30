using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Dal.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        SagaContext unitOfWork = new SagaContext();

        public CompanyRepository(SagaContext unitOfWork)
            : base(unitOfWork)
        {

        }
    }


}
