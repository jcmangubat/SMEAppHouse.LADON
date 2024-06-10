using Microsoft.Identity.Client;
using SMEAppHouse.Core.CodeKits;
using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class BlogPostModel : KeyedModel
{
    public new Guid? Id { get; set; }
    public required string Title { get; set; }

    public string? Content { get; set; }
    public string? ContentSourceMDFileName { get; set; }
    public string? ContentSourceMDCDNUrl { get; set; }

    public DateTime? PublishedDate { get; set; }
    public DateTime? LastModified { get; set; }
    public string? Slug { get; set; }
    public int? Likes { get; set; }
    public int? Hearts { get; set; }
    public int? Views { get; set; }
    public bool? IsFeatured { get; set; }
    public required string? MetaDescription { get; set; }
    public string? CanonicalUrl { get; set; }
    public List<string>? MetaKeywords { get; set; } = [];
    public List<string>? Tags { get; set; } = [];
    public List<ArticleCategoryModel> ArticleCategories { get; set; } = [];
    public List<BlogRelatedAssociationModel>? RelatedPostsFrom { get; set; } = [];
    public List<BlogRelatedAssociationModel>? RelatedPostsTo { get; set; } = [];
    public List<BlogPostCommentModel>? Comments { get; set; } = [];
    public List<BlogPostImageModel>? Images { get; set; } = [];
    public Guid? AuthorUserProfileId { get; set; }
    public required string AuthorName { get; set; }
    public string? AuthorAvatarImageCDNUrl { get; set; }

    public Guid? QuestionAnswerId { get; set; }
    public virtual QuestionAnswerModel? QuestionAnswer { get; set; }



    public static string MakeSlug(string title)
    {
        var cleanedTitle = title.Trim().Replace(".", "");
        cleanedTitle = CodeKit.URLSafeString(cleanedTitle);
        if (!cleanedTitle.Any(p => p == ' ')) // already a slug
            return cleanedTitle;
        var titleParts = title.Split(' ').Select(p => p.Trim().ToLower()).ToList();
        var slug = CodeKit.URLSafeString(string.Join('-', titleParts));
        return slug;
    }
}
