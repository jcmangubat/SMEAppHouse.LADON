using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class ArticleMetricConfiguration(string schema = "dbo", ModelBuilder builder = null)
    : EntityConfiguration<ArticleMetric, Guid>(builder, prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<ArticleMetric> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.UniqueVisitors);
        entityBuilder.DefineDbField(x => x.Shares);
        entityBuilder.DefineDbField(x => x.TimeOnPage);
        entityBuilder.DefineDbField(x => x.UniqueVisitors);

        entityBuilder.HasOne(p => p.Article)
                    .WithMany(p => p.ArticleMetrics)
                    .HasForeignKey(p => p.MetricArticleId)
                    .IsRequired();
    }
}
