using DDDsoulution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
