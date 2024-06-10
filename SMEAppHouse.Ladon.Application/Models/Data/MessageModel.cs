using System.ComponentModel.DataAnnotations;
using SMEAppHouse.Ladon.Application.Models.Base;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class MessageModel : KeyedModel, IValidatableObject
{
    [Required]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    public required string EmailAddress { get; set; }

    public string? MobilePhoneNo { get; set; }

    [Required]
    public required string Subject { get; set; }

    [Required]
    public required string ContentText { get; set; }

    public string? ContentHtml { get; set; }

    [Required]
    public required SiteMessageSourcesEnum SiteMessageSource { get; set; }

    public Guid? UserProfileId { get; set; }
    public virtual UserProfileModel? UserProfile { get; set; }


    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        if (!new EmailAddressAttribute().IsValid(EmailAddress))
            results.Add(new ValidationResult("Invalid email address", [nameof(EmailAddress)]));

        return results;
    }
}
