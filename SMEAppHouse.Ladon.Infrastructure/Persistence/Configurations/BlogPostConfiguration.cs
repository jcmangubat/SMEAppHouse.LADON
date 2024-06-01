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
        entityBuilder.DefineDbField(x => x.Content, true, "nvarchar(max)");
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

        entityBuilder.DefineDbField(x => x.AuthorName, false, FieldLengths.BlogPost.AuthorName, null, "nvarchar");
        entityBuilder.DefineDbField(x => x.AuthorUserProfileId, false)
                    .HasOne(p => p.AuthorUserProfile)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(p => p.AuthorUserProfileId)
                    .IsRequired(false);

        //public List<BlogComment> Comments { get; set; }
        entityBuilder.HasMany(x => x.Comments)
                        .WithOne(p => p.BlogPost)
                        .HasForeignKey(p => p.BlogPostId)
                        .IsRequired(false)
                        .OnDelete(DeleteBehavior.Cascade);

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


        modelBuilder.Entity<BlogPostCategory>()
        .HasKey(bpc => new { bpc.BlogPostId, bpc.BlogCategoryId });

        modelBuilder.Entity<BlogPostCategory>()
            .HasOne(bpc => bpc.BlogPost)
            .WithMany(bp => bp.BlogPostCategories)
            .HasForeignKey(bpc => bpc.BlogPostId);

        modelBuilder.Entity<BlogPostCategory>()
            .HasOne(bpc => bpc.BlogCategory)
            .WithMany(bc => bc.BlogPostCategories)
            .HasForeignKey(bpc => bpc.BlogCategoryId);
    }
}
