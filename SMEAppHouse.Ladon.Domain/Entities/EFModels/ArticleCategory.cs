using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ArticleCategory: GuidKeyedEntity
{
    public required string Name { get; set; }
    public virtual IList<Article> Articles { get; set; } = [];
}