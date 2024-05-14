using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    internal class HttpClientService : IHttpClientService
    {
        //TODO: implementation of accepting a sentence from api, and json extraction
        public Task<string> GetCatFactAsync()
        {
            throw new NotImplementedException();
        }
    }
}
