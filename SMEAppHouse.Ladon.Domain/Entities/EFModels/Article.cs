using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class Article : GuidKeyedEntity
{
    /// <summary>
    /// The title of the article.
    /// </summary>
    public required string Title { get; set; }

    public required ArticleTypesEnum ArticleType { get; set; }

    public required ArticleStatusEnum ArticleStatus { get; set; }

    /// <summary>
    /// The main content of the article.
    /// </summary>
    public string? Content { get; set; }

    public string? ContentSourceMDFileName { get; set; }

    public string? ContentSourceMDCDNUrl { get; set; }

    /// <summary>
    /// The date and time when the article was published.
    /// </summary>
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// The date and time when the article was last modified.
    /// </summary>
    public DateTime? LastModified { get; set; }


    /// <summary>
    /// A URL-friendly version of the title for use in the post's URL.
    /// </summary>
    public string? Slug { get; set; }

    /// <summary>
    /// The number of likes as reactions received by the article.
    /// </summary>
    public int? Likes { get; set; }

    /// <summary>
    /// The number of hearts as reactions received by the article.
    /// </summary>
    public int? Hearts { get; set; }

    /// <summary>
    /// The number of views or page visits for the article.
    /// </summary>
    public int? Views { get; set; }

    /// <summary>
    /// A flag indicating whether the article is featured or highlighted on the article's homepage.
    /// </summary>
    public bool? IsFeatured { get; set; }

    /// <summary>
    /// A brief summary or description of the article for search engine optimization (SEO) purposes.
    /// </summary>
    public string? MetaDescription { get; set; }

    public string? ArticleOverview { get; set; }

    /// <summary>
    /// The canonical URL of the article, used to indicate the preferred version of the post for search engines.
    /// </summary>
    public string? CanonicalUrl { get; set; }

    /// <summary>
    /// Keywords or phrases relevant to the article for SEO purposes.
    /// </summary>
    public IList<string>? MetaKeywords { get; set; } = [];

    /// <summary>
    /// Keywords or labels associated with the article for categorization or search purposes.
    /// </summary>
    public IList<string>? Tags { get; set; } = [];

    /// <summary>
    /// Categories or topics to which the article belongs.
    /// </summary>
    public virtual IList<ArticleCategory> ArticleCategories { get; set; } = [];

    /// <summary>
    /// Navigation property representing the related articles. 
    /// A collection of other articles that are related or similar to this post.
    /// </summary>
    public virtual IList<ArticleAssociation>? RelatedPostsFrom { get; set; } = [];
    public virtual IList<ArticleAssociation>? RelatedPostsTo { get; set; } = [];

    /// <summary>
    /// A collection of comments or feedback submitted by readers.
    /// </summary>
    public virtual IList<ArticleComment>? Comments { get; set; } = [];

    public virtual IList<ArticleImage>? Images { get; set; } = [];

    /// <summary>
    /// The author or creator of the article.
    /// </summary>
    public Guid? AuthorUserProfileId { get; set; }
    public virtual UserProfile? AuthorUserProfile { get; set; } // Navigation property
    public required string AuthorName { get; set; }
    public string? AuthorAvatarImageCDNUrl { get; set; }

    // Foreign key for the one-to-one relationship
    public Guid? QuestionAnswerId { get; set; }

    // Navigation property for the one-to-one relationship
    public virtual QuestionAnswer? QuestionAnswer { get; set; }

    public virtual IList<ArticleMetric>? ArticleMetrics { get; set; } = [];
}
