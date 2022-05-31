using Ricco.DataAccess.Repositories;
using Ricco.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.DataAccess
{
    public class Repository : IRepository
    {

        public Repository()
        {

        }

        private ICategoriaDeProduto _categoriaDeproduto;


        public ICategoriaDeProduto CategoriasDeProdutos => _categoriaDeproduto ?? (_categoriaDeproduto = new CategoriaDeProdutoRepository());

        public void Rollback()
        {
            
        }

        public void SaveChanges()
        {
            
        }
    }
}
