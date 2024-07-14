using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class QuoteRequestAttachmentConfiguration(string schema = "dbo")
    : EntityConfiguration<QuoteRequestAttachment, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<QuoteRequestAttachment> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.AssetCDNUrl, true, FieldLengths.QuoteRequestAttachment.AssetCDNUrl, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.OriginalFilename, true, FieldLengths.QuoteRequestAttachment.OriginalFilename, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.QuoteRequestId, true);

        entityBuilder.HasOne(p => p.QuoteRequest)
                     .WithMany(p => p.Attachments)
                     .HasForeignKey(p => p.QuoteRequestId)
                     .IsRequired();

        base.OnModelCreating(entityBuilder);
    }
}
