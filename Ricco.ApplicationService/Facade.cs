using Ricco.ApplicationService.Facades;
using Ricco.ApplicationService.Views;
using Ricco.DataAccess;
using Ricco.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.ApplicationService
{
    public class Facade : IFacade
    {
        public Facade()
        {
            _repository = new Repository();
        }

        private IRepository _repository;

        private ICategoriaDeProdutoFacade _categoriaDeProduto;

        public ICategoriaDeProdutoFacade CategoriasDeProdutos => _categoriaDeProduto ?? (_categoriaDeProduto = new CategoriaDeProdutoFacade(_repository));

       

        public void SaveChanges()
        {
           
        }

        public void Rollback()
        {
            _categoriaDeProduto = null;
           
        }
    }
}
