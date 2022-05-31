using Ricco.ApplicationService.Views;
using Ricco.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.ApplicationService.Adapters
{
    internal static class CategoriaDeProdutoAdapter
    {
        public static List<CategoriaDeProdutoView> ConvertToView(this List<CategoriaDeProduto> list)
        {
            var novaLista = new List<CategoriaDeProdutoView>();

            foreach (var item in list)
            {
                novaLista.Add(item.ConvertToView());
            }

            return novaLista;
        }

        public static CategoriaDeProdutoView ConvertToView(this CategoriaDeProduto item)
        {
            if (item == null)
                return new CategoriaDeProdutoView();

            return new CategoriaDeProdutoView()
            {
                Id = item.Id,
                Nome = item.Nome,
                CadastradoPor = item.CadastradoPor,
                AtualizadoPor = item.AtualizadoPor,
                DataAtualizacao = item.DataAtualizacao.ToShortDateString(),
                DataCadastro = item.DataCadastro.ToShortDateString(),

            };
        }

    }
}
