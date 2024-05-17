using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CatFactWritter
{
    /// <summary>
    /// Represents a service to get sentece from external api
    /// </summary>
    internal class HttpClientService : IHttpClientService
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientService"/> class.
        /// </summary>
        /// <param name="_httpClient">The HTTP client used to send requests.</param>
        /// <param name="_apiUrl">The URL of the cat facts API.</param>
        public HttpClientService(HttpClient _httpClient, string _apiUrl)
        {
            apiUrl = _apiUrl;
            httpClient = _httpClient;
        }

        /// <summary>
        /// Gets a sentence from the external API.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the cat fact as a string.
        /// </returns>
        /// <exception cref="Exception">
        /// Thrown when the HTTP response is not successful or the content is null.
        /// </exception>
        public async Task<string> GetCatFactSentence()
        {
            using (var response = await httpClient.GetAsync(apiUrl))
            {
                if (response.IsSuccessStatusCode && response.Content != null)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var CatFact = JsonSerializer.Deserialize<CatFactModel>(json);
                    return CatFact?.Fact ?? "Could not return fact";
                }
                else
                {
                    throw new Exception("Response Error " + response.StatusCode);
                }
            }
        }
    }
}
