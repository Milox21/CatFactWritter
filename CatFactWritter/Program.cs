using CatFactWritter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

internal class Program
{
    /// <summary>
    /// The main method, which is the entry point of the application.
    /// Sets up the host, configures services, and runs the <see cref="CatFactsManager"/>.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                var apiUrl = "https://catfact.ninja/fact";
                var fileWrittingPath = "F:/repos2/CatFactWritter/CatFactWritter/catfacts.txt";

                // Register HttpClient
                services.AddHttpClient();

                // Register IHttpClientService with implementation HttpClientService
                services.AddTransient<IHttpClientService, HttpClientService>(provider =>
                {
                    var httpClient = provider.GetRequiredService<HttpClient>();
                    return new HttpClientService(httpClient, apiUrl);
                });

                // Register IWritterService with implementation WritterService
                services.AddSingleton<IWritterService>(new WritterService(fileWrittingPath));

                // Register CatFactsManager
                services.AddTransient<CatFactsManager>();
            })
            .Build();

        // Retrieve and run the CatFactsManager service
        var worker = host.Services.GetRequiredService<CatFactsManager>();
        await worker.RunAsync();
    }
}