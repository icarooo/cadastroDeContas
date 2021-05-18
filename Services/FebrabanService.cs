using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ContaBancariaServer.Interfaces;
using ContaBancariaServer.Models;
using Newtonsoft.Json;

namespace ContaBancariaServer.Services
{
    public class FebrabanService : IFebraban
    {
        private HttpClient _httpClient = new HttpClient ();
        public febrabanLista getBancos()
        {

            var content = new StringContent("{	FiltroAssociado: \"Todos\" }", Encoding.UTF8, "application/json");
            var result = _httpClient.PostAsync("https://portal.febraban.org.br/Associado/Index",content).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<febrabanLista>(result.Result);
        }
    }
}