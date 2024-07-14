using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class FeatureProjectConfiguration(string schema = "dbo")
    : EntityConfiguration<FeatureProject, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<FeatureProject> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.Title, true, FieldLengths.General.ExtraLong, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.Slug, true, FieldLengths.General.ExtraLong, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.Description, false, FieldLengths.General.SuperLong, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.ImageCDNUrl, true, FieldLengths.General.URL, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.Location, false, FieldLengths.General.ExtraLong, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.CompletionDate, false);

        base.OnModelCreating(entityBuilder);
    }
}
