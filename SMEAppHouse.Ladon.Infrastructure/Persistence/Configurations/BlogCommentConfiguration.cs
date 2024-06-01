using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class BlogCommentConfiguration(string schema = "dbo")
    : EntityConfiguration<BlogComment, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<BlogComment> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.AuthorName, true, FieldLengths.BlogComment.Name);
        entityBuilder.DefineDbField(x => x.Email, true, FieldLengths.BlogComment.Email);
        entityBuilder.DefineDbField(x => x.CommentText, true, FieldLengths.BlogComment.CommentText);

        entityBuilder.DefineDbField(x => x.BlogPostId, true)
            .HasOne(p => p.BlogPost)
            .WithMany(p => p.Comments)
            .HasForeignKey(p => p.BlogPostId)
            .IsRequired();
    }
}
