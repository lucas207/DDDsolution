using DDDsoulution.Domain.Entities;
using DDDsoulution.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
