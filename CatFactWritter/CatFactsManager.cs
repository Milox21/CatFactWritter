using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    /// <summary>
    /// Manages the retrieval and saving of cat facts.
    /// </summary>
    internal class CatFactsManager
    {
        private readonly IHttpClientService httpClientService;
        private readonly IWritterService writterService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CatFactsManager"/> class.
        /// </summary>
        /// <param name="_httpClientService">The service used to fetch cat facts.</param>
        /// <param name="_writterService">The service used to write cat facts to a file.</param>
        public CatFactsManager(IHttpClientService _httpClientService, IWritterService _writterService)
        {
            httpClientService = _httpClientService;
            writterService = _writterService;
        }

        /// <summary>
        /// Runs the process of downloading and writing a cat fact.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task RunAsync()
        {
            var data = await httpClientService.GetCatFactSentence();

            await writterService.SaveToFile(data);

            Console.WriteLine("Cat Fact Saved");
        }
    }
}
