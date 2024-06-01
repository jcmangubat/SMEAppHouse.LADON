using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class SiteAreaConfiguration(string schema = "dbo")
    : EntityConfiguration<SiteArea, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<SiteArea> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.Code, true, 10);
        entityBuilder.DefineDbField(x => x.Name, true, 30);

        base.OnModelCreating(entityBuilder);
    }
}
