using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Ricco.DomainModel;

namespace Ricco.DataAccess.APIAzFunctions
{
    internal class BaseAPI<T> where T : EntityBase
    {
        public HttpClient HttpClient { get; set; }

        public BaseAPI()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("");
            HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpContent Get(string url)
        {
            HttpResponseMessage response = HttpClient.GetAsync(url).Result;
            return response.Content;

        }

        public HttpContent Post()
        {

        }
    }
}
