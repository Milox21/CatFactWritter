using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CatFactWritter
{
    internal class HttpClientService : IHttpClientService
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;
        public HttpClientService(HttpClient _httpClient, string _apiUrl) 
        {
            apiUrl = _apiUrl;
            httpClient = _httpClient;
        }
        public async Task<string> GetSentence()
        {
            using (var response = await httpClient.GetAsync(apiUrl))
            { 
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var CatFact =  JsonSerializer.Deserialize<CatFactModel>(json);
                    return CatFact.Fact;
                }
                else
                {
                    throw new Exception("Response Error " + response.StatusCode);
                }
            }
        }
    }
}
