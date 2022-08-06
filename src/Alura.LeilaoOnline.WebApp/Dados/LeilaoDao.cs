using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDao
    {
        public Leilao(AppDbContext context)
        {
            AppDbContext _context
        }

        private IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        private Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(x => x.Id == id);
        }

        private IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes.Include(l => l.Categoria).ToList();
        }

        private void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        private void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }

        private void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }


    }
}
