using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class ArticleCommentConfiguration(string schema = "dbo")
    : EntityConfiguration<ArticleComment, Guid>(prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<ArticleComment> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.AuthorName, false, FieldLengths.ArticleComment.Name);
        entityBuilder.DefineDbField(x => x.Email, false, FieldLengths.ArticleComment.Email);
        entityBuilder.DefineDbField(x => x.CommentText, true, FieldLengths.ArticleComment.CommentText);
        entityBuilder.DefineDbField(x => x.Likes, false);
        entityBuilder.DefineDbField(x => x.Dislikes, false);

        entityBuilder.DefineDbField(x => x.ArticleId, true)
            .HasOne(p => p.Article)
            .WithMany(p => p.Comments)
            .HasForeignKey(p => p.ArticleId)
            .IsRequired();

        entityBuilder.HasOne(p => p.UserProfile)
                        .WithMany(p => p.ArticleComments)
                        .HasForeignKey(p => p.UserProfileId)
                        .IsRequired(false);

        entityBuilder.HasOne(c => c.ParentArticleComment)
            .WithMany(c => c.ArticleCommentReplies)
            .HasForeignKey(c => c.ParentArticleCommentId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
