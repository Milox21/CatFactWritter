using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    /// <summary>
    /// Defines the interface for the HTTP client service.
    /// </summary>
    internal interface IHttpClientService
    {
        /// <summary>
        /// Gets a sentence (cat fact) from the external API.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the cat fact as a string.
        /// </returns>
        Task<string> GetCatFactSentence();
    }
}
