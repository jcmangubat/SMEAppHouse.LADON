using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogPost : GuidKeyedEntity
{
    /// <summary>
    /// The title of the blog post.
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// The main content of the blog post.
    /// </summary>
    public required string Content { get; set; }

    /// <summary>
    /// The date and time when the blog post was published.
    /// </summary>
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// The date and time when the blog post was last modified.
    /// </summary>
    public DateTime? LastModified { get; set; }


    /// <summary>
    /// A URL-friendly version of the title for use in the post's URL.
    /// </summary>
    public string? Slug { get; set; }

    /// <summary>
    /// The number of likes as reactions received by the blog post.
    /// </summary>
    public int? Likes { get; set; }

    /// <summary>
    /// The number of hearts as reactions received by the blog post.
    /// </summary>
    public int? Hearts { get; set; }

    /// <summary>
    /// The number of views or page visits for the blog post.
    /// </summary>
    public int? Views { get; set; }

    /// <summary>
    /// A flag indicating whether the blog post is featured or highlighted on the blog's homepage.
    /// </summary>
    public bool? IsFeatured { get; set; }

    /// <summary>
    /// A brief summary or description of the blog post for search engine optimization (SEO) purposes.
    /// </summary>
    public string? MetaDescription { get; set; }

    /// <summary>
    /// The canonical URL of the blog post, used to indicate the preferred version of the post for search engines.
    /// </summary>
    public string? CanonicalUrl { get; set; }

    /// <summary>
    /// Keywords or phrases relevant to the blog post for SEO purposes.
    /// </summary>
    public List<string>? MetaKeywords { get; set; }

    /// <summary>
    /// Keywords or labels associated with the blog post for categorization or search purposes.
    /// </summary>
    public List<string>? Tags { get; set; }

    /// <summary>
    /// Categories or topics to which the blog post belongs.
    /// </summary>
    public virtual ICollection<BlogPostCategory>? BlogPostCategories { get; set; }

    /// <summary>
    /// Navigation property representing the related blog posts. 
    /// A collection of other blog posts that are related or similar to this post.
    /// </summary>
    public virtual List<BlogRelatedAssociation>? RelatedPostsFrom { get; set; } // Navigation property for related posts
    public virtual List<BlogRelatedAssociation>? RelatedPostsTo { get; set; } // Navigation property for related posts

    /// <summary>
    /// A collection of comments or feedback submitted by readers.
    /// </summary>
    public virtual List<BlogComment>? Comments { get; set; } = [];

    /// <summary>
    /// The author or creator of the blog post.
    /// </summary>
    public Guid? AuthorUserProfileId { get; set; }
    public virtual UserProfileModel? AuthorUserProfile { get; set; } // Navigation property
    public string? AuthorName { get; set; }
}
