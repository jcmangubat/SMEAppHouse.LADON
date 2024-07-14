using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ArticleMetric : GuidKeyedEntity
{
    public int? UniqueVisitors { get; set; }
    public int? Shares { get; set; }
    public TimeSpan? TimeOnPage { get; set; }
    public DateTime? Date { get; set; }

    public required Guid MetricArticleId { get; set; }
    public required Article Article { get; set; }
}