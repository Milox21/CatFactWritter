using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    /// <summary>
    /// Defines the interface for a service that writes sentences to a file.
    /// </summary>
    internal interface IWritterService
    {
        /// <summary>
        /// Saves the specified sentence to a file.
        /// </summary>
        /// <param name="sentence">The sentence to save to the file.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task SaveToFile(string sentence);
    }

}
