using Newtonsoft.Json;
using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class Message : GuidKeyedEntity
{
    public required string Subject { get; set; }
    public required string ContentText { get; set; }
    public string? ContentHtml { get; set; }
    public MessageStatusEnum Status { get; set; }

    public required string Name { get; set; }
    public required string EmailAddress { get; set; }
    public string? MobilePhoneNo { get; set; }

    public SiteMessageSourcesEnum SiteMessageSource { get; set; }

    public Guid? UserProfileId { get; set; }
    public virtual UserProfile? UserProfile { get; set; }

}
