using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ArticleMetricModel : KeyedModel
{
    public int?  UniqueVisitors { get; set; }
    public int? Shares { get; set; }
    public TimeSpan? TimeOnPage { get; set; }
    public DateTime? Date { get; set; }

    public required Guid ArticleId { get; set; }
    public required ArticleModel ArticleArticleModel { get; set; }
}