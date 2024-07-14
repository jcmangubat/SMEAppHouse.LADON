using Markdig;
using SMEAppHouse.Ladon.Application.Interfaces;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class MarkdownService: IMarkdownService
{
    public async Task<string> ConvertMarkdownToHtmlAsync(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Markdown file not found.", filePath);
        }

        string markdown = await File.ReadAllTextAsync(filePath);
        string html = Markdown.ToHtml(markdown);
        return html;
    }
}