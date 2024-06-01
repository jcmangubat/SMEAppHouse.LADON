using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogCategory: GuidKeyedEntity
{
    public required string Name { get; set; }
    public virtual ICollection<BlogPostCategory>? BlogPostCategories { get; set; }
}