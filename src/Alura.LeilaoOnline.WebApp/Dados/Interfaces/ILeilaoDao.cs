using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados.Interfaces
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarCategorias();

        Leilao BuscarPorId(int id);

        IEnumerable<Leilao> BuscarLeiloes();

        void Incluir(Leilao leilao);

        void Excluir(Leilao leilao);

        void Alterar(Leilao leilao);
    }
}
