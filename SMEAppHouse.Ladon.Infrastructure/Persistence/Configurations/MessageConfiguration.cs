using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class MessageConfiguration(string schema = "dbo")
    : EntityConfiguration<Message, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<Message> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.Name, false, FieldLengths.Message.Name);
        entityBuilder.DefineDbField(x => x.EmailAddress, false, FieldLengths.Message.EmailAddress);
        entityBuilder.DefineDbField(x => x.MobilePhoneNo, false, FieldLengths.Message.MobilePhoneNo);
        entityBuilder.DefineDbField(x => x.Subject, true, FieldLengths.Message.Subject);

        //entityBuilder.DefineDbField(x => x.ContentText, true, FieldLengths.Message.ContentText, null, "nvarchar");
        //entityBuilder.DefineDbField(x => x.ContentHtml, true, FieldLengths.Message.ContentHtml, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.ContentText, true, "nvarchar(max)");
        entityBuilder.DefineDbField(x => x.ContentHtml, true, "nvarchar(max)");

        entityBuilder.DefineDbField(x => x.Status, true, null, pb =>
        {
            pb.HasDefaultValue(MessageStatusEnum.New);
        });
        entityBuilder.DefineDbField(x => x.SiteMessageSource, true);

        entityBuilder.DefineDbField(x => x.UserProfileId, false);

        // Foreign keys
        entityBuilder.HasOne(p => p.UserProfile)
            .WithMany(p => p.Messages)
            .IsRequired(false)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);

        base.OnModelCreating(entityBuilder);
    }
}
