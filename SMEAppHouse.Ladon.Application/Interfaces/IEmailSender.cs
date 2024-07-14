using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IEmailSender
{
    Task SendEmailAsync(
        EmailContact sender,
        string subject,
        string textBody,
        string? htmlBody,
        IEnumerable<EmailContact> primaryEmailRecipients,
        IEnumerable<EmailContact>? ccEmailRecipients,
        IEnumerable<EmailContact>? bccEmailRecipients);

    Task SendEmailAsync(
        EmailContact sender,
        string subject,
        string textBody,
        string? htmlBody,
        IEnumerable<EmailContact> primaryEmailRecipients);
}