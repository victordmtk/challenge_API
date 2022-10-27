using challengeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace challengeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViaCepController : ControllerBase
    {
        

        [HttpGet("{cepInformed}")]
        public async Task<ViaCep> GetCep(string cepInformed)
        {
            var BaseUrl = new Uri($"https://viacep.com.br/ws/{cepInformed}/json/");
            
            using (HttpClient client = new HttpClient { BaseAddress = BaseUrl} )
            {
                var cepInfo = await client.GetFromJsonAsync<ViaCep>("");
                return cepInfo;
            }
        }
    }
}
