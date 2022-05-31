using Ricco.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.ApplicationService.Views
{
    public interface IFacade
    {
       
        ICategoriaDeProdutoFacade CategoriasDeProdutos { get; }
        void SaveChanges();
        void Rollback();
    }

    public interface IFacadeBase<T> where T : IView
    {
        void Salvar(T view);
        void Excluir(int id);
        T ObterPor(int id);
        List<T> ObterTodos();
    }
}
