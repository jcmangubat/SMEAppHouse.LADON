using SMEAppHouse.Ladon.Application.Models.Base;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ArticleModel : KeyedModel
{
    public new Guid? Id { get; set; }
    public required string Title { get; set; }
    public required ArticleTypesEnum ArticleType { get; set; }
    public required ArticleStatusEnum ArticleStatus { get; set; }
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
    public string? MetaDescription { get; set; }
    public string? ArticleOverview { get; set; }
    public string? CanonicalUrl { get; set; }
    public List<string>? MetaKeywords { get; set; } = [];
    public List<string>? Tags { get; set; } = [];
    public List<ArticleCategoryModel> ArticleCategories { get; set; } = [];
    public List<ArticleAssociationModel>? RelatedPostsFrom { get; set; } = [];
    public List<ArticleAssociationModel>? RelatedPostsTo { get; set; } = [];
    public List<ArticleCommentModel>? Comments { get; set; } = [];
    public List<ArticleImageModel>? Images { get; set; } = [];
    public Guid? AuthorUserProfileId { get; set; }
    public required string AuthorName { get; set; }
    public string? AuthorAvatarImageCDNUrl { get; set; }

    public Guid? QuestionAnswerId { get; set; }
    public virtual QuestionAnswerModel? QuestionAnswer { get; set; }
}
