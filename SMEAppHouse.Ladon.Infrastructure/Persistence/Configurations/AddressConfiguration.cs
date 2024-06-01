using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class AddressConfiguration(string schema = "dbo")
    : EntityConfiguration<Address, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<Address> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.AddressLine1, true, 60);
        entityBuilder.DefineDbField(x => x.AddressLine2, false, 60);
        entityBuilder.DefineDbField(x => x.City, true, 20);
        entityBuilder.DefineDbField(x => x.Region, false, 20);
        entityBuilder.DefineDbField(x => x.Country, true, 20);
        entityBuilder.DefineDbField(x => x.PostalCode, true, 10);
        entityBuilder.DefineDbField(x => x.AddressType, true);

        entityBuilder.DefineDbField(x => x.UserProfileId, true);

        entityBuilder.HasOne(p => p.UserProfile)
                        .WithMany(p => p.Addresses)
                        .HasForeignKey(p => p.UserProfileId)
                        .IsRequired();
    }
}

