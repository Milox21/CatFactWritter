using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    internal interface IHttpClientService
    {
        Task<string> GetSentence();
    }
}
