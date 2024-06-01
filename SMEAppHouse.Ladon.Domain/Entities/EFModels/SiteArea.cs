using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class SiteArea : GuidKeyedEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
}