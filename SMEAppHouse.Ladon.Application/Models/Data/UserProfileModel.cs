using SMEAppHouse.Ladon.Application.Models.Base;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class UserProfileModel : KeyedModel
{
    public Guid IdentityUserId { get; set; }
    public string? ClientCode { get; set; }

    public string? Salutation { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}".Trim();
    public GendersEnum Gender { get; set; }

    public string MobilePhoneNo { get; set; }

    public string? ThumbnailUrl { get; set; }

    public string? ProfileImageUrl { get; set; }

    public string? BusinessInstitutionName { get; set; }
}
