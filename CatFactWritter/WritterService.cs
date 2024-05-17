using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    /// <summary>
    /// Represents a service to write  a sentence to the file. 
    /// </summary>
    internal class WritterService : IWritterService
    {
        private readonly string fileWrittingPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryWriter"/> class
        /// </summary>
        /// <param name="fileWrittingPath">A path to a file where sentence should be saved</param>
        public WritterService(string fileWrittingPath)
        {
            this.fileWrittingPath = fileWrittingPath;
        }

        /// <summary>
        /// Saves given string to a file.
        /// </summary>
        /// <param name="sentence">The sentence is to be saved</param>
        /// <returns>void</returns>
        public async Task SaveToFile(string sentence)
        {
            using(StreamWriter writter = new(fileWrittingPath, true))
            {
                await writter.WriteLineAsync(sentence);
            }
        }
    }
}
