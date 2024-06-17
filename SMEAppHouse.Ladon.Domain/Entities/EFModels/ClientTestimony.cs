using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ClientTestimony : GuidKeyedEntity
{
    public required string ClientName { get; set; }
    public required string ClientProfession { get; set; }
    public required string ClientBusinessName { get; set; }
    public required string Remarks { get; set; }

    public string? ClientThumnailUrl { get; set; }
    public string? ProjectImageUrl { get; set; }

    public Guid? UserProfileId { get; set; }
    public virtual UserProfile? UserProfile { get; set; }
}