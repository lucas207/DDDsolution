using DDDsoulution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
