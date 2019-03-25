using DDDsoulution.Application.Interface;
using DDDsoulution.Domain.Entities;
using DDDsoulution.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Application.Service
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
