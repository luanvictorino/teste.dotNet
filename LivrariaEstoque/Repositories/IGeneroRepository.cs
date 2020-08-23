using LivrariaEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaEstoque.Repositories
{
    public interface IGeneroRepository
    {
        IEnumerable<Genero> Generos { get; }
    }
}
