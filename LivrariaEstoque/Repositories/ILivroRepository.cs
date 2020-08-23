using LivrariaEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Repositories
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> Livros { get; }
        Livro GetLivroByNome(string livroNome);
    }
}
