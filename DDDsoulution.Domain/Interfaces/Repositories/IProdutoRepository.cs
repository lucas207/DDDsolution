using DDDsoulution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string Nome);
    }
}
