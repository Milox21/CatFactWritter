using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    public class WritterService : IWritterService
    {
        private readonly string fileWrittingPath;

        public WritterService(string fileWrittingPath)
        {
            this.fileWrittingPath = fileWrittingPath;
        }

        public async Task SaveToFile(string sentence)
        {
            using(StreamWriter writter = new(fileWrittingPath))
            {
                await writter.WriteLineAsync(sentence);
            }
        }
    }
}
