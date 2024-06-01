using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ClientTestimony : GuidKeyedEntity
{
    public string ClientName { get; set; }
    public string? ClientProfession { get; set; }
    public string? ClientBusinessName { get; set; }
    public string Remarks { get; set; }

    public string? ClientThumnailUrl { get; set; }
    public string? ProjectImageUrl { get; set; }

    public Guid? UserProfileId { get; set; }
    public virtual UserProfileModel? UserProfile { get; set; }
}