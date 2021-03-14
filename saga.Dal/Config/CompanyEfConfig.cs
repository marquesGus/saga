using saga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saga.Dal.Config
{
    public class CompanyEfConfig : EntityTypeConfiguration<Company>
    {
    }
}
