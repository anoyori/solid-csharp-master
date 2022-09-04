using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados.Interfaces
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> ListarCategorias();

        Leilao BuscarLeitaoPorId(int id);

        IEnumerable<Leilao> ListarLeiloes();

        void Incluir(Leilao leilao);

        void Excluir(Leilao leilao);

        void Alterar(Leilao leilao);
    }
}
