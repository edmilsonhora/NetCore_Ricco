using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.DomainModel
{
    public class CategoriaDeProduto:EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override void Validar()
        {
            CampoTextoObrigatorio(nameof(Nome), Nome);
            CampoTextoObrigatorio(nameof(Descricao), Descricao);
            base.Validar();
        }
    }

    public interface ICategoriaDeProduto : IRepositoryBase<CategoriaDeProduto> { }
}
