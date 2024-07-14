using AutoMapper;
using SMEAppHouse.Core.CodeKits.Tools;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Application.Services;

public class MessageService(IMapper mapper, IMessageRepository messageRepository) : IMessageService
{
    private readonly IMapper _mapper = mapper;
    private readonly IMessageRepository _messageRepository = messageRepository;
    private static readonly string[] separator = ["\r\n", "\r", "\n"];

    public async Task<MessageModel> GetMessageAsync(Guid? id)
    {
        var message = await _messageRepository.GetSingleAsync(p => p.Id == (id ?? Guid.Empty), null);
        var msg = _mapper.Map<MessageModel>(message);
        return msg;
    }

    public async Task<IEnumerable<MessageModel>> GetMessagesAsync()
    {
        var messages = await _messageRepository.GetListAsync();
        var msgs = _mapper.Map<IEnumerable<MessageModel>>(messages);
        return msgs;
    }

    public async Task AddMessageAsync(MessageModel message)
    {
        if (message.SiteMessageSource == Domain.Constants.Rules.SiteMessageSourcesEnum.FromContactUs)
        {
            var htmlContent = HtmlResourceLoader.LoadHtmlResource("ContactUsMessageTemplate.html", "EmailTemplates");
            var msgContent = ConvertTextToHtml(message.ContentText);
            htmlContent = htmlContent.Replace("[content]", msgContent)
                                        .Replace("[sender-name]", message.Name)
                                        .Replace("[sender-phone]", message.MobilePhoneNo);
            message.ContentHtml = htmlContent;
            message.ContentText = $"{message.ContentText}\r\n\r\n{message.Name}\r\n{message.MobilePhoneNo}";
        }

        var msg = _mapper.Map<Domain.Entities.EFModels.Message>(message);
        await _messageRepository.AddAsync(msg);
        await _messageRepository.CommitAsync();
    }


    private static string ConvertTextToHtml(string textContent)
    {
        if (string.IsNullOrEmpty(textContent))
            return string.Empty;

        // Split the text into paragraphs based on newlines
        var paragraphs = textContent
            .Split(separator, StringSplitOptions.None)
            .Where(paragraph => !string.IsNullOrWhiteSpace(paragraph)); // Ignore empty paragraphs

        // Wrap each paragraph in <p> tags
        var htmlParagraphs = paragraphs
            .Select(paragraph => $"<p>{System.Net.WebUtility.HtmlEncode(paragraph)}</p>");

        // Join the paragraphs into a single string
        return string.Join("\n", htmlParagraphs);
    }
}