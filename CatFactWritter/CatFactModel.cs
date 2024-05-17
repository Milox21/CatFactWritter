using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CatFactWritter
{
    /// <summary>
    /// Represents a model for the response from the cat facts API.
    /// </summary>
    internal class CatFactModel
    {
        /// <summary>
        /// Gets or sets the cat fact.
        /// </summary>
        [JsonPropertyName("fact")]
        public string Fact { get; set; }

        /// <summary>
        /// Gets or sets the length of the cat fact.
        /// </summary>
        [JsonPropertyName("length")]
        public int Length { get; set; }
    }
}
