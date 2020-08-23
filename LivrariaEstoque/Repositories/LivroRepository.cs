using LivrariaEstoque.Context;
using LivrariaEstoque.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AppDbContext _context;
        public LivroRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Livro> Livros => _context.Livros.Include(g => g.Genero);

        public Livro GetLivroByNome(string livroNome)
        {
            return _context.Livros.FirstOrDefault(l => l.Titulo == l.Titulo);
        }
    }
}
