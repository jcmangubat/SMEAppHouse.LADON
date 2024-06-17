namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IMarkdownService
{
    Task<string> ConvertMarkdownToHtmlAsync(string filePath);
}