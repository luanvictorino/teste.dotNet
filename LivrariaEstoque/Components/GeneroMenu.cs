using LivrariaEstoque.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LivrariaEstoque.Components
{
    public class GeneroMenu : ViewComponent
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroMenu(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        public IViewComponentResult Invoke()
        {
            var generos = _generoRepository.Generos.OrderBy(g =>
                g.GeneroNome);

            return View(generos);
        }
    }
}
