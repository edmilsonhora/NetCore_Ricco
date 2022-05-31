using Ricco.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ricco.DataAccess.APIAzFunctions
{
    internal class CategoriaDeProdutosAPI : BaseAPI, ICategoriaDeProduto
    {
        public void Excluir(int id)
        {
            HttpResponseMessage response = HttpClient.GetAsync("").Result;
            HttpContent content = response.Content;
            string str = content.ReadAsStringAsync().Result;
        }

        public CategoriaDeProduto ObterPor(int id)
        {
            HttpResponseMessage response = HttpClient.GetAsync("").Result;
            HttpContent content = response.Content;
            string str = content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<CategoriaDeProduto>(str);
        }

        public List<CategoriaDeProduto> ObterTodos()
        {
            HttpResponseMessage response = HttpClient.GetAsync("").Result;
            HttpContent content = response.Content;
            string str = content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<List<CategoriaDeProduto>>(str);
        }

        public void Salvar(CategoriaDeProduto entity)
        {
            HttpContent strContent = new StringContent(JsonSerializer.Serialize(entity));
            var response = HttpClient.PostAsync("", strContent).Result;
            if (response.IsSuccessStatusCode)
            {

            }
        }
    }
}
