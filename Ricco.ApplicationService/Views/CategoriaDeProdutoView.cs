using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.ApplicationService.Views
{
    public class CategoriaDeProdutoView : IView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataCadastro { get; set; }
        public string DataAtualizacao { get; set; }
        public string CadastradoPor { get; set; }
        public string AtualizadoPor { get; set; }
    }

    public interface ICategoriaDeProdutoFacade : IFacadeBase<CategoriaDeProdutoView>
    {

    }
}
