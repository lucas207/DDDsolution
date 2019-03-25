using DDDsoulution.Domain.Entities;
using DDDsoulution.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDsoulution.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string Nome)
        {
            return Db.Produtos.Where(p => p.Nome == Nome);
        }
    }
}
