using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Domain.Repositories;
using IEmailSender = SMEAppHouse.Ladon.Application.Interfaces.IEmailSender;

namespace SMEAppHouse.Ladon.Application.Services;

public class MessageSenderService : IMessageSenderService
{
    private readonly ILogger<MessageSenderService> _logger;
    private readonly ApplicationSettings _applicationSettings;

    private readonly IEmailSender _emailSender;
    private readonly IMessageRepository _messagesRepository;

    public MessageSenderService(ILogger<MessageSenderService> logger,
        ApplicationSettings applicationSettings,
        IEmailSender emailSender,
        IMessageRepository messagesRepository)
    {
        ArgumentNullException.ThrowIfNull(messagesRepository);

        _logger = logger;
        _emailSender=emailSender;
        _applicationSettings = applicationSettings;
        
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

                await _emailSender.SendEmailAsync(
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

    
}
