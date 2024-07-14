using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class Subscriber : GuidKeyedEntity
{
    public required string EmailAddress { get; set; }
}
