using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class ClientTestimonyConfiguration(string schema = "dbo")
    : EntityConfiguration<ClientTestimony, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<ClientTestimony> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.ClientName, true, FieldLengths.ClientTestimony.ClientName);
        entityBuilder.DefineDbField(x => x.ClientProfession, true, FieldLengths.ClientTestimony.ClientProfession);
        entityBuilder.DefineDbField(x => x.ClientBusinessName, true, FieldLengths.ClientTestimony.ClientBusinessName);
        entityBuilder.DefineDbField(x => x.Remarks, true, FieldLengths.ClientTestimony.Remarks);

        entityBuilder.DefineDbField(x => x.ClientThumnailUrl, false, FieldLengths.ClientTestimony.ClientThumnailUrl);
        entityBuilder.DefineDbField(x => x.ProjectImageUrl, false, FieldLengths.ClientTestimony.ProjectImageUrl);

        entityBuilder.DefineDbField(x => x.UserProfileId, false);
        entityBuilder.DefineDbField(x => x.IsActive, false);

        entityBuilder.HasOne(p => p.UserProfile)
                    .WithMany(p => p.ClientTestimonies)
                    .HasForeignKey(p => p.UserProfileId)
                    .IsRequired(false);

        base.OnModelCreating(entityBuilder);
    }
}
