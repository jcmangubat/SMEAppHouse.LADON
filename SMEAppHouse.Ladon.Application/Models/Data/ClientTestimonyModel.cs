using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ClientTestimonyModel :  KeyedModel
{
    public required string ClientName { get; set; }
    public required string ClientProfession { get; set; }
    public required string ClientBusinessName { get; set; }
    public required string Remarks { get; set; }

    public string? ClientThumnailUrl { get; set; }
    public string? ProjectImageUrl { get; set; }

    public Guid? UserProfileId { get; set; }
    public virtual UserProfileModel? UserProfileModel { get; set; }
}