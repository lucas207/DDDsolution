﻿using DDDsoulution.Application.Interface;
using DDDsoulution.Domain.Entities;
using DDDsoulution.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDsoulution.Application.Service
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
