using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using SMEAppHouse.Core.CodeKits;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class MessageSenderService : IMessageSenderService
{
    private readonly ILogger<MessageSenderService> _logger;
    private readonly ApplicationSettings _applicationSettings;
    private readonly SMTPSettings _smtpSettings;

    private readonly IMessageRepository _messagesRepository;

    public MessageSenderService(ILogger<MessageSenderService> logger,
        ApplicationSettings applicationSettings,
        SMTPSettings smtpSettings,
        IMessageRepository messagesRepository)
    {
        ArgumentNullException.ThrowIfNull(smtpSettings);
        ArgumentNullException.ThrowIfNull(messagesRepository);

        _logger = logger;
        _applicationSettings = applicationSettings;
        _smtpSettings = smtpSettings;
        _messagesRepository = messagesRepository;
    }

    public async Task SendUnsentMessagesAsync()
    {
        try
        {
            var unsentMessages = _messagesRepository.GetMessages(Domain.Constants.Rules.MessageStatusEnum.New);
            if (unsentMessages == null || unsentMessages.Count == 0)
                return;

            var contactUsRecipients = _applicationSettings.ContactUsRecipients;
            var primaryRecipient = contactUsRecipients.FirstOrDefault(p => p.RecipientType == Domain.Constants.Rules.RecipientTypesEnum.PRIMARY);
            var ccRecipients = contactUsRecipients.Where(p => p.RecipientType == Domain.Constants.Rules.RecipientTypesEnum.CARBONCOPY);
            var bccRecipients = contactUsRecipients.Where(p => p.RecipientType == Domain.Constants.Rules.RecipientTypesEnum.BLINDCARBONCOPY);

            ArgumentNullException.ThrowIfNull(primaryRecipient);

            if (!EmailsAreValid(primaryRecipient, ccRecipients, bccRecipients, out string error))
                throw new Exception(error);

            foreach (var message in unsentMessages)
            {
                //var msgContent = $"{message.ContentText}";
                //msgContent += $"\n\n~BB~{message.EmailAddress}";
                //if (!string.IsNullOrEmpty(message.MobilePhoneNo))
                //    msgContent += $"\nPhone No. {message.MobilePhoneNo}~BB.~";

                await SendEmailAsync(
                     new EmailContact { EmailAddress = message.EmailAddress, Name = message.Name },
                     message.Subject,
                     message.ContentText,
                     message.ContentHtml,
                     [primaryRecipient],
                     ccRecipients, bccRecipients);

                message.Status = Domain.Constants.Rules.MessageStatusEnum.EmailedToSupport;
                await _messagesRepository.UpdateAsync(message);
                await _messagesRepository.CommitAsync();
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions appropriately
            _logger.LogError(message: $"Error sending unsent emails: {ex.Message}", ex);
            throw;
        }
    }

    private static bool EmailsAreValid(EmailContact? primaryRecipient,
                                IEnumerable<EmailContact> ccRecipients,
                                IEnumerable<EmailContact> bccRecipients,
                                out string error)
    {
        error = string.Empty;

        if (primaryRecipient == null)
        {
            error = "No contact information has been defined as primary contact us recipient.";
            return false;
        }

        if (!CodeKit.IsValidEmail(primaryRecipient.EmailAddress))
        {
            error = $"Cannot proceed sending unsent messages since {primaryRecipient.EmailAddress} email address is not valid.";
            return false;
        }

        var invalidCCContacts = string.Join(", ", ccRecipients.Where(e => !CodeKit.IsValidEmail(e.EmailAddress))
                                                .Select(e => e.ToString())).Trim();

        if (!string.IsNullOrEmpty(invalidCCContacts))
        {
            error = $"Cannot proceed sending unsent messages since {invalidCCContacts} carbon copy as email address(es) recipient is or are not valid.";
            return false;
        }

        var invalidBCCContacts = string.Join(", ", bccRecipients.Where(e => !CodeKit.IsValidEmail(e.EmailAddress))
                                                .Select(e => e.ToString())).Trim();

        if (!string.IsNullOrEmpty(invalidBCCContacts))
        {
            error = $"Cannot proceed sending unsent messages since {invalidBCCContacts} blind carbon copy email address(es) recipient is or are not valid.";
            return false;
        }

        return true;
    }

    private async Task SendEmailAsync(
        EmailContact sender,
        string subject,
        string textBody,
        string? htmlBody,
        IEnumerable<EmailContact> primaryEmailRecipients,
        IEnumerable<EmailContact>? ccEmailRecipients,
        IEnumerable<EmailContact>? bccEmailRecipients)
    {
        var smtpHost = _smtpSettings.Host;
        var smtpPort = _smtpSettings.Port;
        var smtpUsername = _smtpSettings.Username;
        var smtpPassword = _smtpSettings.Password;

        ArgumentNullException.ThrowIfNull(sender);
        ArgumentNullException.ThrowIfNull(primaryEmailRecipients);

        // Create email message
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(sender.Name ?? sender.EmailAddress, sender.EmailAddress));

        foreach (var primaryEmailRecipient in primaryEmailRecipients)
            message.To.Add(new MailboxAddress(primaryEmailRecipient.Name ?? primaryEmailRecipient.EmailAddress, primaryEmailRecipient.EmailAddress));

        var allEmailContacts = new List<EmailContact>(primaryEmailRecipients);

        if (ccEmailRecipients != null && ccEmailRecipients.Count() > 0)
        {
            allEmailContacts.AddRange(ccEmailRecipients);
            foreach (var ccEmailRecipient in ccEmailRecipients)
            {
                message.Cc.Add(new MailboxAddress(ccEmailRecipient.Name ?? ccEmailRecipient.EmailAddress, ccEmailRecipient.EmailAddress));
            }
        }

        if (bccEmailRecipients != null && bccEmailRecipients.Count() > 0)
        {
            allEmailContacts.AddRange(bccEmailRecipients);
            foreach (var bccEmailRecipient in bccEmailRecipients)
            {
                message.Bcc.Add(new MailboxAddress(bccEmailRecipient.Name ?? bccEmailRecipient.EmailAddress, bccEmailRecipient.EmailAddress));
            }
        }

        message.Subject = subject;

        // Create the body of the email
        var bodyBuilder = new BodyBuilder
        {
            TextBody = textBody,
            HtmlBody = htmlBody ?? string.Empty,
        };
        message.Body = bodyBuilder.ToMessageBody();

        var msgContacts = string.Join(", ", allEmailContacts);

        try
        {
            // Configure and send the email using MailKit's SmtpClient
            using var client = new SmtpClient();

            client.Connect(smtpHost, smtpPort, true); // SMTP server address and port
            client.Authenticate(smtpUsername, smtpPassword); // SMTP credentials

            await client.SendAsync(message);
            await client.DisconnectAsync(true);

            var logMsg = $"Message sent to {msgContacts} from {sender}";
            _logger.LogInformation(message: logMsg);
        }
        catch (Exception ex)
        {
            // Handle exceptions appropriately
            var logMsg = $"Error sending email to {msgContacts} : {ex.GetExceptionMessages()}";
            _logger.LogError(message: logMsg, ex);
            throw;
        }
    }
}
