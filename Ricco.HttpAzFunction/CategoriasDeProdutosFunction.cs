using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Ricco.HttpAzFunction.Models;
using Ricco.DomainModel;

namespace Ricco.HttpAzFunction
{
    public static class CategoriasDeProdutosFunction
    {
        [FunctionName("CategoriaDeProduto-Salvar")]
        public static async Task<IActionResult> Salvar([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
        {
            try
            {

                string conteudo = await new StreamReader(req.Body).ReadToEndAsync();
                var data = JsonConvert.DeserializeObject<CategoriaDeProduto>(conteudo);

                return new OkObjectResult(true);



            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }

        }

        [FunctionName("CategoriaDeProduto-Excluir")]
        public static async Task<IActionResult> Excluir([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            try
            {

                string id = req.Query["id"];

                string conteudo = await new StreamReader(req.Body).ReadToEndAsync();
                var data = id; //JsonConvert.DeserializeObject<CategoriaDeProduto>(conteudo);

                return new OkObjectResult(true);



            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }

        }

        [FunctionName("CategoriaDeProduto-ObterPor")]
        public static async Task<IActionResult> ObterPor([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            try
            {

                string id = req.Query["id"];

                string conteudo = await new StreamReader(req.Body).ReadToEndAsync();
                var data = id; //JsonConvert.DeserializeObject<CategoriaDeProduto>(conteudo);

                return new OkObjectResult(true);



            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }

        }

        [FunctionName("CategoriaDeProduto-ObterTodos")]
        public static async Task<IActionResult> ObterTodos([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            try
            {

                string conteudo = await new StreamReader(req.Body).ReadToEndAsync();
                //var data = id; //JsonConvert.DeserializeObject<CategoriaDeProduto>(conteudo);

                return new OkObjectResult(true);



            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }

        }
    }

}
