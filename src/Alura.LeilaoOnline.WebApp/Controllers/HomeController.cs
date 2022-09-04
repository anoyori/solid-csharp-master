using Alura.LeilaoOnline.WebApp.Dados.EfCore;
using Alura.LeilaoOnline.WebApp.Dados.Interfaces;
using Alura.LeilaoOnline.WebApp.Models;
using Alura.LeilaoOnline.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IProdutoService _produtoService;

        public HomeController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            var categorias = _produtoService.ConsultaCategoriaComTotalLeiloesEmPregao();
            return View(categorias);
        }

        [Route("[controller]/StatusCode/{statusCode}")]
        public IActionResult StatusCodeError(int statusCode)
        {
            if (statusCode == 404) return View("404");
            return View(statusCode);
        }

        [Route("[controller]/Categoria/{categoria}")]
        public IActionResult Categoria(int id)
        {
            var categ = _produtoService.ConsultaCategoriaPorIdComLeiloesEmPregao(id);
            return View(categ);
        }

        [HttpPost]
        [Route("[controller]/Busca")]
        public IActionResult Busca(string termo)
        {
            ViewData["termo"] = termo;
            var leiloes = _produtoService.ConsultaCategoriaEmPregaoPorTermo(termo);
            return View(leiloes);
        }
    }
}
