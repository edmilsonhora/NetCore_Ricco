using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.DomainModel
{
    public abstract class EntityBase
    {
        protected StringBuilder RegrasQuebradas = new StringBuilder();

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string CadastradoPor { get; set; }
        public string AtualizadoPor { get; set; }

        public void Registrar()
        {
            if (Id.Equals(0))
            {
                CadastradoPor = AtualizadoPor;
                DataCadastro = DateTime.Now;
            }

            DataAtualizacao = DateTime.Now;
        }

        public virtual void Validar()
        {
            CampoTextoObrigatorio("Atualizado Por", AtualizadoPor);

            if (RegrasQuebradas.Length > 0)
                throw new ApplicationException(RegrasQuebradas.ToString());
        }

        protected void CampoTextoObrigatorio(string nomeDoCampo, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                RegrasQuebradas.Append($"O campo {nomeDoCampo} é obrigatório.{Environment.NewLine}");
        }
    }
}
