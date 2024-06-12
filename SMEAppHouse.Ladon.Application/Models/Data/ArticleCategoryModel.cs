using SMEAppHouse.Ladon.Application.Models.Base;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ArticleCategoryModel : KeyedModel
{
    public required string Name { get; set; }
    public virtual IList<Article> Articles { get; set; } = [];
}