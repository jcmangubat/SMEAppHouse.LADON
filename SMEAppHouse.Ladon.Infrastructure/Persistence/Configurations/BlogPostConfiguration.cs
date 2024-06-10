using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class BlogPostConfiguration(string schema = "dbo", ModelBuilder builder = null)
    : EntityConfiguration<BlogPost, Guid>(builder, prefixEntityNameToId: true,
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityBuilder"></param>
    public override void OnModelCreating(EntityTypeBuilder<BlogPost> entityBuilder)
    {
        base.OnModelCreating(entityBuilder);

        entityBuilder.DefineDbField(x => x.Title, true, FieldLengths.BlogPost.Title);

        entityBuilder.DefineDbField(x => x.Content, false, "nvarchar(max)");
        entityBuilder.DefineDbField(x => x.ContentSourceMDFileName, false, "nvarchar(2000)");
        entityBuilder.DefineDbField(x => x.ContentSourceMDCDNUrl, false, "nvarchar(2000)");

        entityBuilder.DefineDbField(x => x.PublishedDate, false);
        entityBuilder.DefineDbField(x => x.LastModified, false);

        entityBuilder.DefineDbField(x => x.Tags, false, FieldLengths.BlogPost.Tags);
        entityBuilder.DefineDbField(x => x.Slug, false, FieldLengths.BlogPost.Slug, null, "nvarchar");

        entityBuilder.DefineDbField(x => x.Likes, false);
        entityBuilder.DefineDbField(x => x.Hearts, false);
        entityBuilder.DefineDbField(x => x.Views, false);
        entityBuilder.DefineDbField(x => x.IsFeatured, false);
        entityBuilder.DefineDbField(x => x.MetaDescription, false, FieldLengths.BlogPost.MetaDescription, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.MetaKeywords, false, FieldLengths.BlogPost.MetaKeywords, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.CanonicalUrl, false, FieldLengths.BlogPost.CanonicalUrl, null, propertyType: "nvarchar");

        entityBuilder.DefineDbField(x => x.AuthorName, true, FieldLengths.BlogPost.AuthorName, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.AuthorUserProfileId, false)
                    .HasOne(p => p.AuthorUserProfile)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(p => p.AuthorUserProfileId)
                    .IsRequired(false);

        entityBuilder.HasMany(x => x.Comments)
                    .WithOne(p => p.BlogPost)
                    .HasForeignKey(p => p.BlogPostId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Cascade);

        entityBuilder.HasMany(x => x.Images)
                    .WithOne(p => p.BlogPost)
                    .HasForeignKey(p => p.BlogPostId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Cascade);

        entityBuilder.HasOne(b => b.QuestionAnswer)
                    .WithOne(q => q.RelatedBlogPost)
                    .HasForeignKey<QuestionAnswer>(q => q.RelatedBlogPostId)
                    .IsRequired(false);
    }

    public override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogRelatedAssociation>()
        .HasKey(r => new { r.SourceBlogPostId, r.TargetBlogPostId });

        modelBuilder.Entity<BlogRelatedAssociation>()
            .HasOne(r => r.SourceBlogPost)
            .WithMany(b => b.RelatedPostsFrom) // Navigation property for related posts from this blog document
            .HasForeignKey(r => r.SourceBlogPostId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<BlogRelatedAssociation>()
            .HasOne(r => r.TargetBlogPost)
            .WithMany(b => b.RelatedPostsTo) // Navigation property for related posts to this blog document
            .HasForeignKey(r => r.TargetBlogPostId)
            .OnDelete(DeleteBehavior.NoAction);

        // Configure many-to-many relationship with ArticleCategory
        modelBuilder.Entity<BlogPost>()
            .HasMany(bp => bp.ArticleCategories)
            .WithMany(ac => ac.BlogPosts)
            .UsingEntity<BlogPostArticleCategory>(
                j => j.HasOne(bc => bc.ArticleCategory).WithMany().HasForeignKey(bc => bc.ArticleCategoryId),
                j => j.HasOne(bc => bc.BlogPost).WithMany().HasForeignKey(bc => bc.BlogPostId),
                j =>
                {
                    j.HasKey(bc => new { bc.BlogPostId, bc.ArticleCategoryId });
                });
    }
}
