using Ricco.ApplicationService.Adapters;
using Ricco.ApplicationService.Views;
using Ricco.DataAccess;
using Ricco.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.ApplicationService.Facades
{
    internal class CategoriaDeProdutoFacade : ICategoriaDeProdutoFacade
    {
        private readonly IRepository repository;

        public CategoriaDeProdutoFacade(IRepository repository)
        {
            this.repository = repository;
        }

        public void Excluir(int id)
        {
            repository.CategoriasDeProdutos.Excluir(id);
        }

        public CategoriaDeProdutoView ObterPor(int id)
        {
            return repository.CategoriasDeProdutos.ObterPor(id).ConvertToView();
        }

        public List<CategoriaDeProdutoView> ObterTodos()
        {
            return repository.CategoriasDeProdutos.ObterTodos().ConvertToView();
        }

        public void Salvar(CategoriaDeProdutoView view)
        {
            var obj = view.Id == 0 ? new CategoriaDeProduto() : repository.CategoriasDeProdutos.ObterPor(view.Id);
            obj.Descricao = view.Descricao;
            obj.AtualizadoPor = view.AtualizadoPor;
            obj.Nome = view.Nome;
            obj.Registrar();
            obj.Validar();

            repository.CategoriasDeProdutos.Salvar(obj);
            
        }
    }
}
