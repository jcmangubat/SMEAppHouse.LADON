using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class FeatureProjectImageConfiguration(string schema = "dbo")
    : EntityConfiguration<FeatureProjectImage, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<FeatureProjectImage> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.ImageCaption, false, FieldLengths.General.SuperLong, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.ImageCDNUrl, true, FieldLengths.General.URL, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.Style, false);

        entityBuilder.HasOne(p => p.FeatureProject)
                     .WithMany(p => p.FeatureProjectImages)
                     .HasForeignKey(p => p.FeatureProjectId)
                     .IsRequired();

        base.OnModelCreating(entityBuilder);
    }
}