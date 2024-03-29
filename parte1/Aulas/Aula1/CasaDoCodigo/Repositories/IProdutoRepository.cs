﻿using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(IList<Livro> livros);
        IList<Produto> GetProdutos();
    }
}