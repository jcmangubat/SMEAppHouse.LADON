using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class ArticleConfiguration(string schema = "dbo", ModelBuilder builder = null)
    : EntityConfiguration<Article, Guid>(builder, prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<Article> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.Title, true, FieldLengths.Article.Title);
        entityBuilder.DefineDbField(x => x.ArticleType, true);
        entityBuilder.DefineDbField(x => x.ArticleStatus, true);

        entityBuilder.DefineDbField(x => x.Content, false, "nvarchar(max)");
        entityBuilder.DefineDbField(x => x.ContentSourceMDFileName, false, "nvarchar(2000)");
        entityBuilder.DefineDbField(x => x.ContentSourceMDCDNUrl, false, "nvarchar(2000)");

        entityBuilder.DefineDbField(x => x.PublishedDate, false);
        entityBuilder.DefineDbField(x => x.LastModified, false);

        entityBuilder.DefineDbField(x => x.Tags, false, FieldLengths.Article.Tags);
        entityBuilder.DefineDbField(x => x.Slug, false, FieldLengths.Article.Slug, null, "nvarchar");

        entityBuilder.DefineDbField(x => x.Likes, false);
        entityBuilder.DefineDbField(x => x.Hearts, false);
        entityBuilder.DefineDbField(x => x.Views, false);
        entityBuilder.DefineDbField(x => x.IsFeatured, false);
        entityBuilder.DefineDbField(x => x.MetaDescription, false, FieldLengths.Article.MetaDescription, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.ArticleOverview, false, FieldLengths.Article.ArticleOverview, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.MetaKeywords, false, FieldLengths.Article.MetaKeywords, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.CanonicalUrl, false, FieldLengths.Article.CanonicalUrl, null, propertyType: "nvarchar");

        entityBuilder.DefineDbField(x => x.AuthorName, true, FieldLengths.Article.AuthorName, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.AuthorUserProfileId, false)
                    .HasOne(p => p.AuthorUserProfile)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(p => p.AuthorUserProfileId)
                    .IsRequired(false);

        entityBuilder.HasMany(x => x.Comments)
                    .WithOne(p => p.Article)
                    .HasForeignKey(p => p.ArticleId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Cascade);

        entityBuilder.HasMany(x => x.Images)
                    .WithOne(p => p.Article)
                    .HasForeignKey(p => p.ArticleId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Cascade);

        entityBuilder.HasOne(b => b.QuestionAnswer)
                    .WithOne(q => q.RelatedArticle)
                    .HasForeignKey<QuestionAnswer>(q => q.RelatedArticleId)
                    .IsRequired(false);
    }

    public override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArticleAssociation>()
        .HasKey(r => new { r.SourceArticleId, r.TargetArticleId });

        modelBuilder.Entity<ArticleAssociation>()
            .HasOne(r => r.SourceArticle)
            .WithMany(b => b.RelatedPostsFrom) // Navigation property for related posts from this Article document
            .HasForeignKey(r => r.SourceArticleId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ArticleAssociation>()
            .HasOne(r => r.TargetArticle)
            .WithMany(b => b.RelatedPostsTo) // Navigation property for related posts to this Article document
            .HasForeignKey(r => r.TargetArticleId)
            .OnDelete(DeleteBehavior.NoAction);

        // Configure many-to-many relationship with ArticleCategory
        modelBuilder.Entity<Article>()
            .HasMany(bp => bp.ArticleCategories)
            .WithMany(ac => ac.Articles)
            .UsingEntity<ArticleCategoryAssociation>(
                j => j.HasOne(bc => bc.ArticleCategory).WithMany().HasForeignKey(bc => bc.ArticleCategoryId),
                j => j.HasOne(bc => bc.Article).WithMany().HasForeignKey(bc => bc.ArticleId),
                j =>
                {
                    j.HasKey(bc => new { bc.ArticleId, bc.ArticleCategoryId });
                });
    }
}
