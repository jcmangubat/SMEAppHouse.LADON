using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Models;

public class BlogPostModel
{
    public Guid? Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime? PublishedDate { get; set; }
    public DateTime? LastModified { get; set; }
    public string? Slug { get; set; }
    public int? Likes { get; set; }
    public int? Hearts { get; set; }
    public int? Views { get; set; }
    public bool? IsFeatured { get; set; }
    public required string? MetaDescription { get; set; }
    public string? CanonicalUrl { get; set; }
    public List<string>? MetaKeywords { get; set; }
    public List<string>? Tags { get; set; }
    public List<string>? Categories { get; set; }
    public List<BlogRelatedAssociation>? RelatedPostsFrom { get; set; }
    public List<BlogRelatedAssociation>? RelatedPostsTo { get; set; }
    public List<BlogComment>? Comments { get; set; }
    public Guid? AuthorUserProfileId { get; set; }
    public string? AuthorName { get; set; }
}
