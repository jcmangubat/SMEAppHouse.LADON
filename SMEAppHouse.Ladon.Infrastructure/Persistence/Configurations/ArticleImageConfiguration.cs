using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class ArticleImageConfiguration(string schema = "dbo", ModelBuilder builder = null)
    : EntityConfiguration<ArticleImage, Guid>(builder, prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<ArticleImage> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.ImageCDNUrl, true, FieldLengths.General.URL);
    }
}