using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaEstoque.Models;
using LivrariaEstoque.Models.ViewModels;
using LivrariaEstoque.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaEstoque.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IActionResult List(string genero)
        {
            string _genero = genero;
            IEnumerable<Livro> livros;
            string generoAtual = string.Empty;

            if (string.IsNullOrEmpty(genero))
            {
                livros = _livroRepository.Livros.OrderBy(l => l.Titulo);
                genero = "Todos os livros";
            }
            else
            {
                livros = _livroRepository.Livros.Where(l =>
                    l.Genero.GeneroNome.Equals(genero)).OrderBy(l => l.Titulo);
               
                generoAtual = _genero;
            }

            var livrosListViewModel = new LivroListViewModel
            {
                Livros = livros,
                Genero = generoAtual
            };

            return View(livrosListViewModel);
        }


        public IActionResult search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Livro> livros;
            string _generoAtual = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                livros = _livroRepository.Livros.OrderBy(l => l.LivroId);
            }
            else
            {
                livros = _livroRepository.Livros.Where(l => l.Titulo.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Livro/List.cshtml", new LivroListViewModel { Livros = livros, Genero = "Todos os Livros" });
        }
    }
}
