using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Models.ViewModels
{
    public class LivroListViewModel
    {
        public IEnumerable<Livro> Livros { get; set; }
        public string Genero { get; set; }
    }
}
