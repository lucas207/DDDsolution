using DDDsoulution.Domain.Entities;
using DDDsoulution.Domain.Interfaces.Repositories;
using DDDsoulution.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
