using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class SubscriberConfiguration(string schema = "dbo") 
    : EntityConfiguration<Subscriber, Guid>(prefixEntityNameToId: true, 
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<Subscriber> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.EmailAddress, true, FieldLengths.General.EmailAddress);

        base.OnModelCreating(entityBuilder);
    }
}
