using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        public IEnumerable<Categoria> ListarTodasCategorias();
        public Leilao ConsultaLeilaoPorId(int id);
        public IEnumerable<Leilao> ListarTodosLeiloes();
        public void CadastrarLeilao(Leilao leilao);
        public void RemoverLeilao(Leilao leilao);
        public void AtualizarLeilao(Leilao leilao);
        public void IniciaPregaodoLeilaoPorId(int id);
        public void FinalizaPregaodoLeilaoPorId(int id);
    }
}
