using System.Collections.Generic;

namespace LivrariaEstoque.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Livro> LivrosRecentes { get; set; }
    }
}
