using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Ladon.Application.Models;
using System.Text;
using HttpMethod = System.Net.Http.HttpMethod;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class ArticleGeneratorService : IArticleGeneratorService
{
    private readonly OpenAICredentials _credentials;
    private readonly ILogger<ArticleGeneratorService> _logger;
    
    public ArticleGeneratorService(ILogger<ArticleGeneratorService> logger, OpenAICredentials credentials)
    {
        _logger = logger;
        _credentials = credentials;
    }

    public async Task<(bool Success, string? article)> GenerateAsync(string prompt)
    {
        try
        {
            // Prepare the HTTP request
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_credentials.ApiKey}");

            var request = new HttpRequestMessage(HttpMethod.Post, _credentials.ApiUrl)
            {
                Content = new StringContent(
                            $"{{ \"prompt\": \"{prompt}\", \"max_tokens\": 1000 }}",
                            Encoding.UTF8,
                            "application/json")
            };

            // Send the request and get the response
            HttpResponseMessage response = await httpClient.SendAsync(request);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody); // Output the generated article
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}
