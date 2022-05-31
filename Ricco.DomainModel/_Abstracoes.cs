using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.DomainModel
{
   

    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Salvar(T entity);
        void Excluir(int id);
        List<T> ObterTodos();
        T ObterPor(int id);

    }

    public interface IRepository
    {
        void SaveChanges();
        void Rollback();
        ICategoriaDeProduto CategoriasDeProdutos { get; }
    }
}
