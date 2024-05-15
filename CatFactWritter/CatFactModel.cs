using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CatFactWritter
{
    internal class CatFactModel
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; }


        [JsonPropertyName("lenght")]
        public int FactLength { get; set; }
    }
}
