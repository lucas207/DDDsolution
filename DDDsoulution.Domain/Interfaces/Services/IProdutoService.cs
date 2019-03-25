using DDDsoulution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
