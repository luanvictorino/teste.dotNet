using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [StringLength(100)]
        public string Titulo { get; set; }
        [StringLength(100)]
        public string Autor { get; set; }
        public short Ano { get; set; }
        public char Status { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
