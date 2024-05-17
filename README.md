# CatFactWriter

Internship Project made as a task for Netwise.

## Overview

CatFactWriter is a .NET application that fetches cat facts from an external API and writes them to a file. This project demonstrates the use of dependency injection, HTTP clients, and asynchronous programming in .NET.

## .NET Version

- .NET 6.0

## Used NuGet Packages

- Microsoft.Extensions.DependencyInjection
- Microsoft.Extensions.Hosting
- Microsoft.Extensions.Http

## Project Structure

- **Program.cs**: Entry point of the application. Sets up the host and configures services.
- **CatFactsManager.cs**: Manages the process of fetching and writing cat facts.
- **HttpClientService.cs**: Service responsible for fetching cat facts from the API.
- **WritterService.cs**: Service responsible for writing cat facts to a file.
- **IWritterService.cs**: Interface for the WritterService.
- **IHttpClientService.cs**: Interface for the HttpClientService.
- **CatFactModel.cs**: Model representing the cat fact data.

## Configuration

The application uses the following configuration values:
- `apiUrl`: The URL of the cat facts API.
- `fileWritingPath`: The path to the file where cat facts will be written.

These values are hard-coded in `Program.cs` but can be externalized to a configuration file if needed.
