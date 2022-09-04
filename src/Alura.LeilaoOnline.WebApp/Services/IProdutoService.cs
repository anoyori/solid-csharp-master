using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IProdutoService
    {
        public IEnumerable<CategoriaComInfoLeilao> ConsultaCategoriaComTotalLeiloesEmPregao();
        public Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id);
        public IEnumerable<Leilao> ConsultaCategoriaEmPregaoPorTermo(string termo);

    }
}
