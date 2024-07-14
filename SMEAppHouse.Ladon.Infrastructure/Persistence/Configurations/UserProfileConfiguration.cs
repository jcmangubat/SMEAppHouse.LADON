using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class UserProfileConfiguration(string schema = "dbo") 
    : EntityConfiguration<UserProfile, Guid>(prefixEntityNameToId: true, 
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<UserProfile> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.IdentityUserId, true);
        entityBuilder.DefineDbField(x => x.ClientCode, false, 10);
        entityBuilder.DefineDbField(x => x.Salutation, false, 10);
        entityBuilder.DefineDbField(x => x.FirstName, true, 20);
        entityBuilder.DefineDbField(x => x.LastName, true, 20);
        entityBuilder.DefineDbField(x => x.Gender, true);
        entityBuilder.DefineDbField(x => x.MobilePhoneNo, false, 20);
        entityBuilder.DefineDbField(x => x.ThumbnailUrl, false, 200);
        entityBuilder.DefineDbField(x => x.ProfileImageUrl, false, 200);
        entityBuilder.DefineDbField(x => x.BusinessInstitutionName, false, 120);

        entityBuilder.HasIndex(u => new { u.FirstName, u.LastName });

        //entityBuilder.HasOne(p => p.ApplicationUser)
        //                .WithMany(p => p.Addresses)
        //                .HasForeignKey(p => p.ApplicationUserId)
        //                .IsRequired();
    }
}
