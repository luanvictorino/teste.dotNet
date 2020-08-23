using Microsoft.AspNetCore.Mvc;
using LivrariaEstoque.Repositories;
using LivrariaEstoque.Models.ViewModels;

namespace LivrariaEstoque.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILivroRepository _livroRepository;

        public HomeController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LivrosRecentes = _livroRepository.Livros
            };

            return View(homeViewModel);
        }
    }
}
