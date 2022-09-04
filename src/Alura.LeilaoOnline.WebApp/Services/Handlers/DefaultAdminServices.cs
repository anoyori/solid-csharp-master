using Alura.LeilaoOnline.WebApp.Dados.Interfaces;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminServices : IAdminService
    {
        readonly ILeilaoDao _leilaoDao;

        public DefaultAdminServices(ILeilaoDao leilaoDao)
        {
            _leilaoDao = leilaoDao;
        }

        public IEnumerable<Categoria> ListarTodasCategorias()
        {
            return _leilaoDao.ListarCategorias();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _leilaoDao.BuscarLeitaoPorId(id);
        }

        public IEnumerable<Leilao> ListarTodosLeiloes()
        {
            return _leilaoDao.ListarLeiloes();
        }

        public void CadastrarLeilao(Leilao leilao)
        {
            _leilaoDao.Incluir(leilao);
        }

        public void RemoverLeilao(Leilao leilao)
        {
            _leilaoDao.Excluir(leilao);
        }

        public void AtualizarLeilao(Leilao leilao)
        {
            _leilaoDao.Alterar(leilao);
        }

        public void IniciaPregaodoLeilaoPorId(int id)
        {
            var leilao = _leilaoDao.BuscarLeitaoPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _leilaoDao.Alterar(leilao);
            }
        }

        public void FinalizaPregaodoLeilaoPorId(int id)
        {
            var leilao = _leilaoDao.BuscarLeitaoPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Pregao){
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _leilaoDao.Alterar(leilao);
            }           
        }
    }
}
