using LivrariaEstoque.Context;
using LivrariaEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly AppDbContext _context;
        public GeneroRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Genero> Generos => _context.Generos;
    }
}
