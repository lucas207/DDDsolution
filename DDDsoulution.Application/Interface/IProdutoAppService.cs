using DDDsoulution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
