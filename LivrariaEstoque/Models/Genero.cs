using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        [StringLength(100)]
        public string GeneroNome { get; set; }
        public List<Livro> Livros { get; set; } 
    }
}
